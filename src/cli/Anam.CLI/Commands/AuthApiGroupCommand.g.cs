#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class AuthApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"auth", @"Auth endpoint commands.");
                         command.Subcommands.Add(AuthCreateSessionTokenCommandApiCommand.Create());
        return command;
    }
}