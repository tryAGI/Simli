using Microsoft.Extensions.AI;

namespace Simli;

/// <summary>
/// Extensions for using SimliClient as MEAI tools with any IChatClient.
/// </summary>
public static class SimliToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a Simli Compose session token
    /// for starting a WebRTC-based avatar streaming session,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Simli client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsCreateSessionTokenTool(
        this SimliClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string faceId, CancellationToken cancellationToken) =>
            {
                var response = await client.StartAudioToVideoSessionComposeTokenPostAsync(
                    faceId: faceId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.SessionToken is { Length: > 0 } token
                    ? $"Session token created: {token}"
                    : "Failed to create session token.";
            },
            name: "SimliCreateSessionToken",
            description: "Creates a temporary Simli Compose session token for a given face ID. The token is used to start a WebRTC-based realtime avatar video streaming session.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a static video from audio,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Simli client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateStaticVideoTool(
        this SimliClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string faceId, string audioBase64, string audioFormat, CancellationToken cancellationToken) =>
            {
                var format = audioFormat.ToUpperInvariant() switch
                {
                    "PCM16" => AudioToVideoRequestAudioFormat.Pcm16,
                    "PCM32" => AudioToVideoRequestAudioFormat.Pcm32,
                    "WAV" => AudioToVideoRequestAudioFormat.Wav,
                    "MP3" => AudioToVideoRequestAudioFormat.Mp3,
                    "OGG" => AudioToVideoRequestAudioFormat.Ogg,
                    _ => AudioToVideoRequestAudioFormat.Pcm16,
                };

                var response = await client.AudioToVideoInterfaceStaticAudioPostAsync(
                    faceId: faceId,
                    audioBase64: audioBase64,
                    audioFormat: format,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string>();
                if (response.HlsUrl is { Length: > 0 } hlsUrl)
                {
                    parts.Add($"HLS URL: {hlsUrl}");
                }
                if (response.Mp4Url is { Length: > 0 } mp4Url)
                {
                    parts.Add($"MP4 URL: {mp4Url}");
                }

                return parts.Count > 0
                    ? string.Join("\n", parts)
                    : "Video generation started but no URLs returned yet.";
            },
            name: "SimliGenerateStaticVideo",
            description: "Generates a static avatar video from base64-encoded audio. Returns HLS and MP4 URLs for the generated video. Supported audio formats: pcm16, pcm32, wav, mp3, ogg.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all available avatar faces,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Simli client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListFacesTool(
        this SimliClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var faces = await client.GetFacesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if (faces is not { Count: > 0 })
                {
                    return "No faces found.";
                }

                var parts = new List<string> { $"Found {faces.Count} face(s):" };
                foreach (var face in faces)
                {
                    var entry = $"- ID: {face.Id}, Version: {face.SimliVersion}";
                    entry += $", Created: {face.CreatedAt:yyyy-MM-dd}";
                    parts.Add(entry);
                }

                return string.Join("\n", parts);
            },
            name: "SimliListFaces",
            description: "Lists all available avatar faces for the authenticated user. Returns face IDs, Simli versions, and creation dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves session history,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Simli client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetSessionHistoryTool(
        this SimliClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.GetHistorySessionsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if (response.Sessions is not { Count: > 0 })
                {
                    return "No session history found.";
                }

                var parts = new List<string> { $"Found {response.Sessions.Count} session(s):" };
                foreach (var session in response.Sessions)
                {
                    var entry = $"- ID: {session.Id}, Duration: {session.SessionTotalTime:F1}s";
                    entry += $", Start: {session.StartTime:yyyy-MM-dd HH:mm:ss}";
                    entry += $", End: {session.EndTime:yyyy-MM-dd HH:mm:ss}";
                    if (session.ApiKeyName is { Length: > 0 } keyName)
                    {
                        entry += $", Key: {keyName}";
                    }
                    parts.Add(entry);
                }

                return string.Join("\n", parts);
            },
            name: "SimliGetSessionHistory",
            description: "Retrieves session history for the authenticated Simli user. Returns session IDs, durations, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks the current active session count,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Simli client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetActiveSessionCountTool(
        this SimliClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.GetRatelimiterSessionsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Active sessions: {response.CurrentUsage ?? 0}";
            },
            name: "SimliGetActiveSessionCount",
            description: "Gets the current number of active Simli avatar streaming sessions for the authenticated user.");
    }
}
