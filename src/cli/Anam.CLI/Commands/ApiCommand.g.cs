#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AuthApiGroupCommand.Create());
                         command.Subcommands.Add(AvatarsApiGroupCommand.Create());
                         command.Subcommands.Add(KnowledgeApiGroupCommand.Create());
                         command.Subcommands.Add(LLMsApiGroupCommand.Create());
                         command.Subcommands.Add(PersonasApiGroupCommand.Create());
                         command.Subcommands.Add(SessionsApiGroupCommand.Create());
                         command.Subcommands.Add(ShareLinksApiGroupCommand.Create());
                         command.Subcommands.Add(ToolsApiGroupCommand.Create());
                         command.Subcommands.Add(VoicesApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}