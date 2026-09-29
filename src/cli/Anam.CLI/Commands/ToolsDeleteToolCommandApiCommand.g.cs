#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class ToolsDeleteToolCommandApiCommand
{
    private static Argument<global::System.Guid> Id { get; } = new(
        name: @"id")
    {
        Description = @"Tool ID.",
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-tool", @"Delete tool
Delete a tool (soft-deleted).");
                        command.Arguments.Add(Id);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Tools.DeleteToolAsync(
                                    id: id,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}