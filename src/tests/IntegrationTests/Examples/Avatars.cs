namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists available avatars from the Anam API.

    [TestMethod]
    public async Task ListAvatars()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Avatars.ListAvatarsAsync(
            page: 1,
            perPage: 10);

        response.Data.Should().NotBeNull();
    }
}
