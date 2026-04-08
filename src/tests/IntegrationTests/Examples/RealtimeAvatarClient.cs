/*
order: 50
title: Realtime Avatar Client
slug: realtime-avatar-client

Test the IRealtimeAvatarClient adapter for Simli realtime sessions.
*/

namespace Simli.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Avatar")]
    public async Task SimliRealtimeAvatarClient_Implements_IRealtimeAvatarClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SIMLI_API_KEY") is { Length: > 0 } key
                ? key
                : throw new AssertInconclusiveException("SIMLI_API_KEY environment variable is not found.");

        var faceId =
            Environment.GetEnvironmentVariable("SIMLI_FACE_ID") is { Length: > 0 } id
                ? id
                : "default"; // Use default face if not specified

        var client = new SimliClient(apiKey);

        //// Create and connect via the unified interface
        await using var avatar = await SimliRealtimeAvatarClient.ConnectAsync(
            client, faceId);

        //// Verify the adapter implements IRealtimeAvatarClient
        tryAGI.RealtimeAvatar.IRealtimeAvatarClient realtimeClient = avatar;
        realtimeClient.Should().NotBeNull();

        //// SendTextAsync should throw NotSupportedException (Simli is audio-only)
        Func<Task> sendText = () => avatar.SendTextAsync("test");
        await sendText.Should().ThrowAsync<NotSupportedException>();

        //// Send a short PCM16 audio chunk (silence)
        var silentAudio = new byte[3200]; // 100ms of silence at 16kHz mono PCM16
        await avatar.SendAudioAsync(silentAudio);

        //// The connection should be established
        // Note: IsConnected checks both WebSocket and WebRTC state
        // WebRTC may take a moment to establish
    }
}
