namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists available voices from the Anam API.

    [TestMethod]
    public async Task ListVoices()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Voices.ListVoicesAsync(
            page: 1,
            perPage: 10);

        response.Data.Should().NotBeNull();
    }
}
