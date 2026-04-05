namespace Simli.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SimliClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SIMLI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SIMLI_API_KEY environment variable is not found.");

        var client = new SimliClient(apiKey);
        
        return client;
    }
}
