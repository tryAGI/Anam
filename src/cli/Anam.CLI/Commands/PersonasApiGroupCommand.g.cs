#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class PersonasApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"personas", @"Personas endpoint commands.");
                         command.Subcommands.Add(PersonasCreatePersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasDeletePersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasGetPersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasListPersonasCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasUpdatePersonaCommandApiCommand.Create());
        return command;
    }
}