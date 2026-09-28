#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class LLMsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"llms", @"LLMs endpoint commands.");
                         command.Subcommands.Add(LLMsCreateLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsDeleteLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsGetLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsListLlmsCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsUpdateLlmCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}