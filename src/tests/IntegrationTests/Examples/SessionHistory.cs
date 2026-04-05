/*
order: 30
title: Session History
slug: session-history

Retrieves session history for the authenticated user.
*/

namespace Simli.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SessionHistory()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve session history
        var response = await client.GetHistorySessionsAsync();

        response.Should().NotBeNull();
        Console.WriteLine($"Found {response.Sessions?.Count ?? 0} session(s)");
        if (response.Sessions is { Count: > 0 })
        {
            foreach (var session in response.Sessions)
            {
                Console.WriteLine($"  Session ID: {session.Id}, Duration: {session.SessionTotalTime:F1}s");
            }
        }
    }
}
