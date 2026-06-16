#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class SessionsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"sessions", @"Sessions endpoint commands.");
                         command.Subcommands.Add(SessionsGetSessionCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetSessionRecordingCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsGetSessionTranscriptCommandApiCommand.Create());
                         command.Subcommands.Add(SessionsListSessionsCommandApiCommand.Create());
        return command;
    }
}