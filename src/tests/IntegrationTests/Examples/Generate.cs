/*
order: 10
title: List Faces
slug: list-faces

Lists all available avatar faces for the authenticated user.
*/

namespace Simli.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListFaces()
    {
        using var client = GetAuthenticatedClient();

        //// List all available avatar faces
        var faces = await client.GetFacesAsync();

        faces.Should().NotBeNull();
        Console.WriteLine($"Found {faces.Count} face(s)");
        foreach (var face in faces)
        {
            Console.WriteLine($"  Face ID: {face.Id}, Version: {face.SimliVersion}, Created: {face.CreatedAt}");
        }
    }
}
