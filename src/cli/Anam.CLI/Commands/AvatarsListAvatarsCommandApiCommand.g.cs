#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class AvatarsListAvatarsCommandApiCommand
{
    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page number for pagination.",
    };

    private static Option<int?> PerPage { get; } = new(
        name: @"--per-page")
    {
        Description = @"Number of avatars per page (max 100).",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search term to filter avatars by display name.",
    };

    private static Option<bool?> OnlyOneShot { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--only-one-shot",
        description: @"Only return one-shot avatars.");

                    private static string FormatResponse(ParseResult parseResult, global::Anam.ListAvatarsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.ListAvatarsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-avatars", @"List avatars
Returns a paginated list of all avatars.");
                        command.Options.Add(Page);
                        command.Options.Add(PerPage);
                        command.Options.Add(Search);
                        command.Options.Add(OnlyOneShot);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var page = parseResult.GetValue(Page);
                        var perPage = parseResult.GetValue(PerPage);
                        var search = parseResult.GetValue(Search);
                        var onlyOneShot = parseResult.GetValue(OnlyOneShot);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Avatars.ListAvatarsAsync(
                                    page: page,
                                    perPage: perPage,
                                    search: search,
                                    onlyOneShot: onlyOneShot,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Anam.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Anam.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}