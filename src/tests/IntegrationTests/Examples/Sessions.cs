namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists sessions from the Anam API.

    [TestMethod]
    public async Task ListSessions()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Sessions.ListSessionsAsync(
            page: 1,
            perPage: 10);

        response.Data.Should().NotBeNull();
    }
}
