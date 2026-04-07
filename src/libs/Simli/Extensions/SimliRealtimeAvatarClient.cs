using System.Runtime.CompilerServices;
using Simli.Realtime;
using tryAGI.RealtimeAvatar;

namespace Simli;

/// <summary>
/// Adapter that wraps <see cref="SimliPeerToPeerRealtimeClient"/> to implement <see cref="IRealtimeAvatarClient"/>.
/// Note: Simli's P2P client is WebSocket-based for signaling. Video/audio frames come via WebRTC
/// after SDP negotiation, which requires an external WebRTC stack. This adapter exposes
/// text-to-speech via the REST API and audio streaming via WebSocket.
/// </summary>
public sealed class SimliRealtimeAvatarClient : IRealtimeAvatarClient
{
    private readonly SimliPeerToPeerRealtimeClient _wsClient;
    private readonly SimliClient? _restClient;
    private bool _disposed;

    /// <summary>
    /// Creates a new adapter wrapping a connected P2P WebSocket client.
    /// </summary>
    /// <param name="wsClient">A connected <see cref="SimliPeerToPeerRealtimeClient"/>.</param>
    /// <param name="restClient">Optional REST client for text-to-speech via static video generation.</param>
    public SimliRealtimeAvatarClient(SimliPeerToPeerRealtimeClient wsClient, SimliClient? restClient = null)
    {
        ArgumentNullException.ThrowIfNull(wsClient);
        _wsClient = wsClient;
        _restClient = restClient;
    }

    /// <inheritdoc />
    public bool IsConnected => _wsClient.IsConnected;

    /// <inheritdoc />
    public Task SendTextAsync(string text, CancellationToken cancellationToken = default)
    {
        // Simli's realtime path is audio-in -> video-out. Text requires TTS conversion first.
        throw new NotSupportedException(
            "Simli realtime sessions use audio input only. Use SendAudioAsync with PCM16 audio, " +
            "or use SimliClient.StaticAudio.GenerateStaticVideoAsync for text-to-video.");
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
        // Simli delivers video via WebRTC (not WebSocket). The WebSocket only carries signaling events.
        // Video frames require a WebRTC peer connection (SIPSorcery or browser).
        // This method yields nothing -- consumers should use the WebRTC track from SDP negotiation.
        await Task.CompletedTask.ConfigureAwait(false);
        yield break;
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<AvatarAudioFrame> ReceiveAudioFramesAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        // Same as video -- audio comes via WebRTC track, not WebSocket.
        await Task.CompletedTask.ConfigureAwait(false);
        yield break;
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (_disposed) return;
        _disposed = true;
        await _wsClient.DisposeAsync().ConfigureAwait(false);
    }
}
