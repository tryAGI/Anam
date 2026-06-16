#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class ToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tools", @"Tools endpoint commands.");
                         command.Subcommands.Add(ToolsCreateToolCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsDeleteToolCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsGetToolCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsListToolsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsUpdateToolCommandApiCommand.Create());
        return command;
    }
}