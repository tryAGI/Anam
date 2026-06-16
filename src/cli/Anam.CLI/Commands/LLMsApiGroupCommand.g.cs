#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class LLMsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"llms", @"LLMs endpoint commands.");
                         command.Subcommands.Add(LLMsCreateLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsDeleteLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsGetLlmCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsListLlmsCommandApiCommand.Create());
                         command.Subcommands.Add(LLMsUpdateLlmCommandApiCommand.Create());
        return command;
    }
}