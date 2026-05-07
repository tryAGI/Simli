using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Simli.Realtime;

/// <summary>
/// Typed extension methods for the Simli P2P WebSocket channel.
/// Adds strongly-typed send/receive operations for WebRTC signaling and audio streaming.
/// </summary>
public sealed partial class SimliPeerToPeerRealtimeClient
{
    /// <summary>
    /// Connects to the Simli P2P WebSocket endpoint using a session token.
    /// The session token is obtained via the REST API's compose/token endpoint.
    /// </summary>
    /// <param name="sessionToken">Session token from the /compose/token endpoint.</param>
    /// <param name="enableSfu">Whether to route traffic through Cloudflare SFU for improved reliability.</param>
    /// <param name="uri">Optional base WebSocket URI override.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task ConnectAsync(
        string sessionToken,
        bool enableSfu = false,
        Uri? uri = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(sessionToken);

        var baseUrl = uri?.ToString() ?? DefaultBaseUrl;
        var separator = baseUrl.Contains('?', StringComparison.Ordinal) ? "&" : "?";
        var sfuValue = enableSfu ? "true" : "false";
        var fullUrl = $"{baseUrl}{separator}session_token={Uri.EscapeDataString(sessionToken)}&enableSFU={sfuValue}";

        await ConnectAsync(uri: new Uri(fullUrl), cancellationToken: cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a WebRTC SDP offer to the server. This must be the first message sent
    /// within 30 seconds of opening the WebSocket connection.
    /// </summary>
    /// <param name="sdp">The SDP offer string from RTCPeerConnection.createOffer().</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task SendOfferAsync(
        string sdp,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(sdp);

        var escapedSdp = JsonEncodedText.Encode(sdp).ToString();
        var offer = $$"""{"type":"offer","sdp":"{{escapedSdp}}"}""";
        await SendAsync(offer, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a binary audio chunk for the avatar to lipsync to.
    /// Audio should be PCM16 format at the sample rate configured in the session.
    /// </summary>
    /// <param name="pcm16Audio">The raw PCM16 audio bytes.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task SendAudioAsync(
        ReadOnlyMemory<byte> pcm16Audio,
        CancellationToken cancellationToken = default)
    {
        await SendAsync(
            new ArraySegment<byte>(pcm16Audio.ToArray()),
            System.Net.WebSockets.WebSocketMessageType.Binary,
            endOfMessage: true,
            cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends the "SKIP" signal to make the avatar stop speaking immediately
    /// and ignore all previously sent audio.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task SendClearBufferAsync(
        CancellationToken cancellationToken = default)
    {
        await SendAsync("SKIP", cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends the "DONE" signal to tell the server that the final segment of audio
    /// has been sent and that it should close after playing it back.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    public async Task SendFinalMessageAsync(
        CancellationToken cancellationToken = default)
    {
        await SendAsync("DONE", cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Receives events from the server as an async enumerable.
    /// Events include the SDP answer, server signals (START, ACK, STOP, SPEAK, SILENT),
    /// and error/termination messages.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>An async enumerable of <see cref="SimliServerEvent"/>.</returns>
    public async IAsyncEnumerable<SimliServerEvent> ReceiveEventsAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (!IsConnected)
        {
            yield break;
        }

        var buffer = new byte[64 * 1024]; // 64KB buffer
        var arraySegment = new ArraySegment<byte>(buffer);

        while (_clientWebSocket.State == System.Net.WebSockets.WebSocketState.Open)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                yield break;
            }

            System.Net.WebSockets.WebSocketReceiveResult result;

            try
            {
                result = await _clientWebSocket.ReceiveAsync(arraySegment, cancellationToken).ConfigureAwait(false);
            }
            catch (System.Net.WebSockets.WebSocketException)
            {
                yield break;
            }
            catch (OperationCanceledException)
            {
                yield break;
            }

            if (result.MessageType == System.Net.WebSockets.WebSocketMessageType.Text)
            {
                var text = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                yield return SimliServerEventParser.Parse(text);
            }
            else if (result.MessageType == System.Net.WebSockets.WebSocketMessageType.Close)
            {
                await _clientWebSocket.CloseAsync(
                    closeStatus: System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
                    statusDescription: "Closing",
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                yield break;
            }
        }
    }
}
