#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class VoicesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"voices", @"Voices endpoint commands.");
                         command.Subcommands.Add(VoicesCreateVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesDeleteVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesGetVoiceCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesListVoicesCommandApiCommand.Create());
                         command.Subcommands.Add(VoicesUpdateVoiceCommandApiCommand.Create());
        return command;
    }
}