#pragma warning disable CS3001 // Argument type is not CLS-compliant
#pragma warning disable CS3002 // Return type is not CLS-compliant
#pragma warning disable CS3003 // Type is not CLS-compliant
#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA1031 // Do not catch general exception types
#pragma warning disable CA2000 // Ownership is transferred to the returned adapter

using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using Simli.Realtime;
using tryAGI.RealtimeAvatar;
using tryAGI.WebRTC;

namespace Simli;

/// <summary>
/// Adapter wrapping <see cref="SimliPeerToPeerRealtimeClient"/> with tryAGI.WebRTC
/// to implement <see cref="IRealtimeAvatarClient"/> with full video/audio frame delivery.
/// </summary>
public sealed class SimliRealtimeAvatarClient : IRealtimeAvatarClient
{
    private readonly SimliPeerToPeerRealtimeClient _wsClient;
    private readonly PeerConnection _peerConnection;
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
        PeerConnection peerConnection)
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

        // 2. Create the owned WebRTC transport on the interface used for Internet traffic.
        using var routeProbe = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        routeProbe.Connect(new IPEndPoint(IPAddress.Parse("1.1.1.1"), 53));
        var localAddress = ((IPEndPoint)routeProbe.LocalEndPoint!).Address;
        var pc = new PeerConnection(new PeerConnectionOptions
        {
            LocalEndPoint = new IPEndPoint(localAddress, 0),
            DataChannels = false,
            AudioDirection = SdpDirection.ReceiveOnly,
            VideoDirection = SdpDirection.ReceiveOnly,
            VideoCodecs =
            [
                // Prefer one deterministic hardware-decodable format. Simli otherwise
                // answers with every offered codec, while this transport selects one.
                new() { Codec = VideoCodec.H264, PayloadType = 102, H264ProfileLevelId = "42e01f", H264PacketizationMode = 1, H264LevelAsymmetryAllowed = true },
            ],
        });

        // 4. Create WebSocket client and connect
        var wsClient = new SimliPeerToPeerRealtimeClient();
        await wsClient.ConnectAsync(sessionToken, enableSfu, cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        var session = new SimliRealtimeAvatarClient(wsClient, pc);

        // 5. Drain authenticated encoded media into the public avatar queues.
        _ = PumpMediaAsync(session, pc, cancellationToken);

        // 6. Create SDP offer and send via WebSocket.
        var offer = pc.CreateOffer();
        await wsClient.SendOfferAsync(offer, cancellationToken).ConfigureAwait(false);

        // 7. Keep signaling alive, but do not report a connected adapter until WebRTC is established.
        var connected = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        _ = Task.Run(async () =>
        {
            try
            {
                await foreach (var evt in wsClient.ReceiveEventsAsync(cancellationToken).ConfigureAwait(false))
                {
                    if (evt.Type == SimliServerEventType.Answer && evt.Sdp is not null)
                    {
                        try
                        {
                            pc.SetRemoteAnswer(evt.Sdp);
                        }
                        catch (FormatException exception)
                        {
                            var shape = string.Join(',', evt.Sdp.Split('\n').Select(line =>
                            {
                                var trimmed = line.TrimEnd('\r');
                                if (trimmed.StartsWith("a=", StringComparison.Ordinal))
                                {
                                    var colon = trimmed.IndexOf(':', StringComparison.Ordinal);
                                    return colon < 0 ? trimmed : trimmed[..colon];
                                }
                                if (trimmed.StartsWith("m=", StringComparison.Ordinal))
                                {
                                    var space = trimmed.IndexOf(' ', StringComparison.Ordinal);
                                    return space < 0 ? trimmed : trimmed[..space];
                                }
                                return trimmed.Length >= 2 ? trimmed[..2] : trimmed;
                            }));
                            throw new FormatException($"Unsupported Simli SDP shape: {shape}", exception);
                        }
                        catch (InvalidOperationException exception)
                        {
                            var parsed = SdpSessionDescription.Parse(evt.Sdp);
                            var shape = $"bundle={string.Join(',', parsed.BundleMids)};" + string.Join(';', parsed.Media.Select(media =>
                                $"{media.Kind}:{media.Mid}[{string.Join(',', media.Formats)}]/{media.Direction}/{media.Setup}/" +
                                $"ext={string.Join(',', media.HeaderExtensions.Select(x => $"{x.Key}:{x.Value}"))}/" +
                                string.Join(',', media.Codecs.Select(codec => $"{codec.PayloadType}:{codec.Name}/{codec.ClockRate}/{codec.Channels}:{codec.FormatParameters}"))));
                            throw new InvalidOperationException($"Unsupported Simli SDP negotiation: {shape}", exception);
                        }
                        await pc.ConnectAsync(cancellationToken).ConfigureAwait(false);
                        connected.TrySetResult(true);
                    }
                }
            }
            catch (Exception exception)
            {
                connected.TrySetException(exception);
            }
        }, cancellationToken);

        try
        {
            await connected.Task.WaitAsync(TimeSpan.FromSeconds(30), cancellationToken).ConfigureAwait(false);
            return session;
        }
        catch
        {
            await session.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    /// <inheritdoc />
    public bool IsConnected => _wsClient.IsConnected &&
        _peerConnection.State == PeerConnectionState.Connected;

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

    private static async Task PumpMediaAsync(
        SimliRealtimeAvatarClient session,
        PeerConnection peer,
        CancellationToken cancellationToken)
    {
        var audio = Task.Run(async () =>
        {
            await foreach (var packet in peer.ReceiveAudioAsync(cancellationToken).ConfigureAwait(false))
            {
                session._audioFrames.Writer.TryWrite(new AvatarAudioFrame(packet.Payload, "OPUS", 20));
            }
        }, cancellationToken);
        var video = Task.Run(async () =>
        {
            await foreach (var frame in peer.ReceiveVideoAsync(cancellationToken).ConfigureAwait(false))
            {
                session._videoFrames.Writer.TryWrite(new AvatarVideoFrame(
                    frame.Payload, frame.Codec.ToString().ToUpperInvariant(), frame.Timestamp));
            }
        }, cancellationToken);
        await Task.WhenAll(audio, video).ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_disposed) return;
        _disposed = true;

        await _peerConnection.DisposeAsync().ConfigureAwait(false);
        _videoFrames.Writer.TryComplete();
        _audioFrames.Writer.TryComplete();

        await _wsClient.DisposeAsync().ConfigureAwait(false);
    }
}
