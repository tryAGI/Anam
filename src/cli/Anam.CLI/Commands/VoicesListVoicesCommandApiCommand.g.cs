#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class VoicesListVoicesCommandApiCommand
{
    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page number for pagination.",
    };

    private static Option<int?> PerPage { get; } = new(
        name: @"--per-page")
    {
        Description = @"Number of voices per page (max 100).",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search term to filter voices by display name.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Anam.ListVoicesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.ListVoicesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-voices", @"List voices
Returns a paginated list of all voices.");
                        command.Options.Add(Page);
                        command.Options.Add(PerPage);
                        command.Options.Add(Search);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var page = parseResult.GetValue(Page);
                        var perPage = parseResult.GetValue(PerPage);
                        var search = parseResult.GetValue(Search);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.ListVoicesAsync(
                                    page: page,
                                    perPage: perPage,
                                    search: search,
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