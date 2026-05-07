#pragma warning disable CS3001 // Argument type is not CLS-compliant
#pragma warning disable CS3002 // Return type is not CLS-compliant
#pragma warning disable CS3003 // Type is not CLS-compliant
#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA1031 // Do not catch general exception types

using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using Simli.Realtime;
using SIPSorcery.Net;
using SIPSorceryMedia.Abstractions;
using tryAGI.RealtimeAvatar;

namespace Simli;

/// <summary>
/// Adapter wrapping <see cref="SimliPeerToPeerRealtimeClient"/> with SIPSorcery WebRTC
/// to implement <see cref="IRealtimeAvatarClient"/> with full video/audio frame delivery.
/// </summary>
public sealed class SimliRealtimeAvatarClient : IRealtimeAvatarClient
{
    private readonly SimliPeerToPeerRealtimeClient _wsClient;
    private readonly RTCPeerConnection _peerConnection;
    private readonly Channel<AvatarVideoFrame> _videoFrames = Channel.CreateBounded<AvatarVideoFrame>(
        new BoundedChannelOptions(128)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true,
            SingleWriter = true,
        });
    private readonly Channel<AvatarAudioFrame> _audioFrames = Channel.CreateBounded<AvatarAudioFrame>(
        new BoundedChannelOptions(256)
        {
            FullMode = BoundedChannelFullMode.DropOldest,
            SingleReader = true,
            SingleWriter = true,
        });
    private bool _disposed;

    private SimliRealtimeAvatarClient(
        SimliPeerToPeerRealtimeClient wsClient,
        RTCPeerConnection peerConnection)
    {
        _wsClient = wsClient;
        _peerConnection = peerConnection;
    }

    /// <summary>
    /// Creates and connects a Simli realtime avatar session.
    /// Handles WebSocket signaling, SDP exchange, and WebRTC peer connection setup.
    /// </summary>
    /// <param name="restClient">The Simli REST client for obtaining session tokens and ICE servers.</param>
    /// <param name="faceId">The avatar face ID to stream.</param>
    /// <param name="enableSfu">Whether to use Cloudflare SFU routing.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    public static async Task<SimliRealtimeAvatarClient> ConnectAsync(
        SimliClient restClient,
        string faceId,
        bool enableSfu = false,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(restClient);
        ArgumentNullException.ThrowIfNull(faceId);

        // 1. Get session token from REST API
        var tokenResponse = await restClient.StartAudioToVideoSessionComposeTokenPostAsync(
            faceId: faceId,
            cancellationToken: cancellationToken).ConfigureAwait(false);
        var sessionToken = tokenResponse.SessionToken
            ?? throw new InvalidOperationException("No session token returned.");

        // 2. Get ICE servers from REST API
        var iceServers = new List<RTCIceServer>();
        try
        {
            var iceResponse = await restClient.GetIceServersComposeIceGetAsync(
                cancellationToken: cancellationToken).ConfigureAwait(false);
            foreach (var server in iceResponse)
            {
                if (server.Urls is not { Length: > 0 })
                {
                    continue;
                }

                iceServers.Add(new RTCIceServer
                {
                    urls = server.Urls,
                    username = server.Username,
                    credential = server.Credential,
                });
            }
        }
        catch
        {
            // ICE server fetch is optional -- STUN/TURN may not be needed for direct connections
        }

        // 3. Create WebRTC peer connection
        var config = new RTCConfiguration { iceServers = iceServers };
        var pc = new RTCPeerConnection(config);

        // 4. Create WebSocket client and connect
        var wsClient = new SimliPeerToPeerRealtimeClient();
        await wsClient.ConnectAsync(sessionToken, enableSfu, cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        var session = new SimliRealtimeAvatarClient(wsClient, pc);

        // 5. Wire up video frame receiver
        pc.OnVideoFrameReceived += (IPEndPoint _, uint timestamp, byte[] encodedData, VideoFormat format) =>
        {
            session._videoFrames.Writer.TryWrite(new AvatarVideoFrame(
                encodedData, format.FormatName ?? "H264", timestamp));
        };

        // 6. Wire up audio frame receiver
        pc.OnAudioFrameReceived += (EncodedAudioFrame frame) =>
        {
            session._audioFrames.Writer.TryWrite(new AvatarAudioFrame(
                frame.EncodedAudio, frame.AudioFormat.FormatName ?? "OPUS", frame.DurationMilliSeconds));
        };

        // 7. Create SDP offer and send via WebSocket
        var offer = pc.createOffer();
        await pc.setLocalDescription(offer).ConfigureAwait(false);
        await wsClient.SendOfferAsync(offer.sdp, cancellationToken).ConfigureAwait(false);

        // 8. Listen for SDP answer from WebSocket events (background task)
        _ = Task.Run(async () =>
        {
            try
            {
                await foreach (var evt in wsClient.ReceiveEventsAsync(cancellationToken).ConfigureAwait(false))
                {
                    if (evt.Type == SimliServerEventType.Answer && evt.Sdp is not null)
                    {
                        var remoteAnswer = new RTCSessionDescriptionInit
                        {
                            type = RTCSdpType.answer,
                            sdp = evt.Sdp,
                        };
                        pc.setRemoteDescription(remoteAnswer);
                    }
                }
            }
            catch
            {
                // Connection closed or cancelled
            }
        }, cancellationToken);

        return session;
    }

    /// <inheritdoc />
    public bool IsConnected => _wsClient.IsConnected &&
        _peerConnection.iceConnectionState == RTCIceConnectionState.connected;

    /// <inheritdoc />
    public Task SendTextAsync(string text, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException(
            "Simli realtime sessions use audio input only. Use SendAudioAsync with PCM16 audio, " +
            "or use SimliClient.AudioToVideoInterfaceStaticAudioPostAsync for text-to-video.");
    }

    /// <inheritdoc />
    public async Task SendAudioAsync(ReadOnlyMemory<byte> pcm16Audio, CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        await _wsClient.SendAudioAsync(pcm16Audio, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<AvatarVideoFrame> ReceiveVideoFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        await foreach (var frame in _videoFrames.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return frame;
        }
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<AvatarAudioFrame> ReceiveAudioFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        await foreach (var frame in _audioFrames.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            yield return frame;
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_disposed) return;
        _disposed = true;

        _peerConnection.close();
        _peerConnection.Dispose();
        _videoFrames.Writer.TryComplete();
        _audioFrames.Writer.TryComplete();

        await _wsClient.DisposeAsync().ConfigureAwait(false);
    }
}
