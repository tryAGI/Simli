/*
order: 20
title: Create Session Token
slug: session-token

Creates a Compose session token for WebRTC avatar streaming.
*/

namespace Simli.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateSessionToken()
    {
        using var client = GetAuthenticatedClient();

        //// Get available faces first
        var faces = await client.GetFacesAsync();
        faces.Should().NotBeNull();

        var faceId =
            Environment.GetEnvironmentVariable("SIMLI_FACE_ID") is { Length: > 0 } configuredFaceId
                ? configuredFaceId
                : faces.FirstOrDefault()?.Id.ToString()
                    ?? throw new AssertInconclusiveException("SIMLI_FACE_ID is required when the account has no custom faces.");

        //// Create a Compose session token for realtime avatar streaming
        var response = await client.StartAudioToVideoSessionComposeTokenPostAsync(
            faceId: faceId);

        response.Should().NotBeNull();
        response.SessionToken.Should().NotBeNullOrEmpty();
    }
}
