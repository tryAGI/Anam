namespace Anam.IntegrationTests;

public partial class Tests
{
    //// Lists AIFunction tools available for use with an IChatClient.

    [TestMethod]
    public void CreateAIFunctionTools()
    {
        var client = GetAuthenticatedClient();

        var tools = new[]
        {
            client.AsCreateSessionTokenTool(),
            client.AsListVoicesTool(),
            client.AsListAvatarsTool(),
            client.AsListPersonasTool(),
            client.AsGetSessionTranscriptTool(),
        };

        tools.Length.Should().Be(5);
        foreach (var tool in tools)
        {
            tool.Name.Should().StartWith("Anam_");
            tool.Description.Should().NotBeNullOrEmpty();
        }
    }
}
