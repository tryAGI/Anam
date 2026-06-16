#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class ShareLinksDeleteShareLinkCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"Share link ID.",
    };

    public static Command Create()
    {
        var command = new Command(@"delete-share-link", @"Delete share link
Delete a share link by ID.");
                        command.Arguments.Add(Id);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.ShareLinks.DeleteShareLinkAsync(
                                    id: id,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}