namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists personas from the Anam API.

    [TestMethod]
    public async Task ListPersonas()
    {
        var client = GetAuthenticatedClient();

        var response = await client.Personas.ListPersonasAsync(
            page: 1,
            perPage: 10);

        response.Data.Should().NotBeNull();
    }
}
