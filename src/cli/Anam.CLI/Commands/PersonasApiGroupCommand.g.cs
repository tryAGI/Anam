#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class PersonasApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"personas", @"Personas endpoint commands.");
                         command.Subcommands.Add(PersonasCreatePersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasDeletePersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasGetPersonaCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasListPersonasCommandApiCommand.Create());
                         command.Subcommands.Add(PersonasUpdatePersonaCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}