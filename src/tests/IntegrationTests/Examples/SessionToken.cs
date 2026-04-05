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
        faces.Count.Should().BeGreaterThan(0, "at least one face is required");

        var faceId = faces[0].Id.ToString();

        //// Create a Compose session token for realtime avatar streaming
        var response = await client.StartAudioToVideoSessionComposeTokenPostAsync(
            faceId: faceId);

        response.Should().NotBeNull();
        response.SessionToken.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Session token: {response.SessionToken}");
    }
}
