#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class ShareLinksApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"share-links", @"ShareLinks endpoint commands.");
                         command.Subcommands.Add(ShareLinksCreateShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksDeleteShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksGetShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksListShareLinksCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksUpdateShareLinkCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}