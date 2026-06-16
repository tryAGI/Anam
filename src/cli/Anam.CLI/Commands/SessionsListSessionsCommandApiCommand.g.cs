#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class SessionsListSessionsCommandApiCommand
{
    private static Option<int?> Page { get; } = new(
        name: @"--page")
    {
        Description = @"Page number for pagination.",
    };

    private static Option<int?> PerPage { get; } = new(
        name: @"--per-page")
    {
        Description = @"Number of items per page (max 100).",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search term to filter sessions by ID or client label.",
    };

    private static Option<global::System.Guid?> ApiKeyId { get; } = new(
        name: @"--api-key-id")
    {
        Description = @"Filter sessions by API key ID.",
    };

    private static Option<global::System.Guid?> PersonaId { get; } = new(
        name: @"--persona-id")
    {
        Description = @"Filter sessions by persona ID.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Anam.ListSessionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.ListSessionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"list-sessions", @"List sessions
Returns a paginated list of all sessions for the organization.");
                        command.Options.Add(Page);
                        command.Options.Add(PerPage);
                        command.Options.Add(Search);
                        command.Options.Add(ApiKeyId);
                        command.Options.Add(PersonaId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var page = parseResult.GetValue(Page);
                        var perPage = parseResult.GetValue(PerPage);
                        var search = parseResult.GetValue(Search);
                        var apiKeyId = parseResult.GetValue(ApiKeyId);
                        var personaId = parseResult.GetValue(PersonaId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Sessions.ListSessionsAsync(
                                    page: page,
                                    perPage: perPage,
                                    search: search,
                                    apiKeyId: apiKeyId,
                                    personaId: personaId,
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