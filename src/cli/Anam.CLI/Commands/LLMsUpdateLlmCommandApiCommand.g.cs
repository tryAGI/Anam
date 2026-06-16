#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class LLMsUpdateLlmCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"The LLM ID.",
    };

    private static Option<string?> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<string?> Url { get; } = new(
        name: @"--url")
    {
        Description = @"",
    };

    private static Option<global::Anam.UpdateLlmRequestLlmFormat?> LlmFormat { get; } = new(
        name: @"--llm-format")
    {
        Description = @"",
    };

    private static Option<string?> ModelName { get; } = new(
        name: @"--model-name")
    {
        Description = @"",
    };

    private static Option<string?> Secret { get; } = new(
        name: @"--secret")
    {
        Description = @"",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<global::Anam.UpdateLlmRequestReasoningEffort?> ReasoningEffort { get; } = new(
        name: @"--reasoning-effort")
    {
        Description = @"",
    };

    private static Option<global::Anam.UpdateLlmRequestReasoningFormat?> ReasoningFormat { get; } = new(
        name: @"--reasoning-format")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Anam.Llm value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.Llm value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-llm", @"Update LLM
Update an LLM configuration.");
                        command.Arguments.Add(Id);
                        command.Options.Add(DisplayName);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Url);
                        command.Options.Add(LlmFormat);
                        command.Options.Add(ModelName);
                        command.Options.Add(Secret);
                        command.Options.Add(Metadata);
                        command.Options.Add(ReasoningEffort);
                        command.Options.Add(ReasoningFormat);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.UpdateLlmRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var displayName = CliRuntime.WasSpecified(parseResult, DisplayName) ? parseResult.GetValue(DisplayName) : (__requestBase is { } __DisplayNameBaseValue ? __DisplayNameBaseValue.DisplayName : default);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var url = CliRuntime.WasSpecified(parseResult, Url) ? parseResult.GetValue(Url) : (__requestBase is { } __UrlBaseValue ? __UrlBaseValue.Url : default);
                        var llmFormat = CliRuntime.WasSpecified(parseResult, LlmFormat) ? parseResult.GetValue(LlmFormat) : (__requestBase is { } __LlmFormatBaseValue ? __LlmFormatBaseValue.LlmFormat : default);
                        var modelName = CliRuntime.WasSpecified(parseResult, ModelName) ? parseResult.GetValue(ModelName) : (__requestBase is { } __ModelNameBaseValue ? __ModelNameBaseValue.ModelName : default);
                        var secret = CliRuntime.WasSpecified(parseResult, Secret) ? parseResult.GetValue(Secret) : (__requestBase is { } __SecretBaseValue ? __SecretBaseValue.Secret : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var reasoningEffort = CliRuntime.WasSpecified(parseResult, ReasoningEffort) ? parseResult.GetValue(ReasoningEffort) : (__requestBase is { } __ReasoningEffortBaseValue ? __ReasoningEffortBaseValue.ReasoningEffort : default);
                        var reasoningFormat = CliRuntime.WasSpecified(parseResult, ReasoningFormat) ? parseResult.GetValue(ReasoningFormat) : (__requestBase is { } __ReasoningFormatBaseValue ? __ReasoningFormatBaseValue.ReasoningFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LLMs.UpdateLlmAsync(
                                    id: id,
                                    displayName: displayName,
                                    description: description,
                                    url: url,
                                    llmFormat: llmFormat,
                                    modelName: modelName,
                                    secret: secret,
                                    metadata: metadata,
                                    reasoningEffort: reasoningEffort,
                                    reasoningFormat: reasoningFormat,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Anam.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}