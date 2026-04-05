/*
order: 40
title: Active Sessions
slug: active-sessions

Gets the current active session count.
*/

namespace Simli.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ActiveSessions()
    {
        using var client = GetAuthenticatedClient();

        //// Check the number of currently active sessions
        var response = await client.GetRatelimiterSessionsAsync();

        response.Should().NotBeNull();
        Console.WriteLine($"Active sessions: {response.CurrentUsage ?? 0}");
    }
}
