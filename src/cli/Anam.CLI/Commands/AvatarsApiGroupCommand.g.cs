#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class AvatarsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"avatars", @"Avatars endpoint commands.");
                         command.Subcommands.Add(AvatarsCreateAvatarCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsDeleteAvatarCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsGetAvatarCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsListAvatarsCommandApiCommand.Create());
                         command.Subcommands.Add(AvatarsUpdateAvatarCommandApiCommand.Create());
        return command;
    }
}