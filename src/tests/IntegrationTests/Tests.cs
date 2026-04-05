namespace Anam.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AnamClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ANAM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ANAM_API_KEY environment variable is not found.");

        var client = new AnamClient(apiKey);
        
        return client;
    }
}
