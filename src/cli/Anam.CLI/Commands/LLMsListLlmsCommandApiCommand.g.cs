#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class LLMsListLlmsCommandApiCommand
{
    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page number for pagination.",
    };

    private static Option<int?> PerPage { get; } = new(
        name: @"--per-page")
    {
        Description = @"Number of items per page.",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search term to filter LLMs.",
    };

    private static Option<bool?> IncludeDefaults { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-defaults",
        description: @"Include default LLMs in the response.");

                    private static string FormatResponse(ParseResult parseResult, global::Anam.ListLlmsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.ListLlmsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-llms", @"List LLMs
Returns a list of all LLMs available to the organization.");
                        command.Options.Add(Page);
                        command.Options.Add(PerPage);
                        command.Options.Add(Search);
                        command.Options.Add(IncludeDefaults);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var page = parseResult.GetValue(Page);
                        var perPage = parseResult.GetValue(PerPage);
                        var search = parseResult.GetValue(Search);
                        var includeDefaults = parseResult.GetValue(IncludeDefaults);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LLMs.ListLlmsAsync(
                                    page: page,
                                    perPage: perPage,
                                    search: search,
                                    includeDefaults: includeDefaults,
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