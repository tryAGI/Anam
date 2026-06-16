#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class ShareLinksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"share-links", @"ShareLinks endpoint commands.");
                         command.Subcommands.Add(ShareLinksCreateShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksDeleteShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksGetShareLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksListShareLinksCommandApiCommand.Create());
                         command.Subcommands.Add(ShareLinksUpdateShareLinkCommandApiCommand.Create());
        return command;
    }
}