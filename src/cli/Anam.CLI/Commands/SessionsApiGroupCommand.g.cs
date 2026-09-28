#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class SessionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"sessions", @"Sessions endpoint commands.");
                         command.Subcommands.Add(SessionsGetSessionCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetSessionRecordingCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetSessionTranscriptCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsListSessionsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}