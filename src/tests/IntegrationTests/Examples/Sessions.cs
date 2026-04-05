namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists sessions from the Anam API.

    [TestMethod]
    public async Task ListSessions()
    {
        var client = GetAuthenticatedClient();

        // Sessions endpoint returns void (no response body in spec)
        await client.Sessions.ListSessionsAsync(
            page: 1,
            perPage: 10);
    }
}
