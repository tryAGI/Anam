#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class AuthApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"auth", @"Auth endpoint commands.");
                         command.Subcommands.Add(AuthCreateSessionTokenCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}