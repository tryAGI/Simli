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

        //// ConnectAsync only returns after authenticated ICE/DTLS media establishment.
        avatar.IsConnected.Should().BeTrue();

        //// Bootstrap Simli output with a short PCM16 silence chunk.
        var silentAudio = new byte[6000];
        await avatar.SendAudioAsync(silentAudio);

        //// Require actual authenticated media from the real provider.
        using var mediaTimeout = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var audioFrame = await avatar.ReceiveAudioFramesAsync(mediaTimeout.Token).FirstAsync(mediaTimeout.Token);
        audioFrame.Data.Should().NotBeEmpty();
        audioFrame.Codec.Should().Be("OPUS");

        var videoFrame = await avatar.ReceiveVideoFramesAsync(mediaTimeout.Token).FirstAsync(mediaTimeout.Token);
        videoFrame.Data.Should().NotBeEmpty();
    }
}
