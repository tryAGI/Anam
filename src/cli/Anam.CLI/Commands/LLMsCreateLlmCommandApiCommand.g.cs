#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class LLMsCreateLlmCommandApiCommand
{
    private static Option<string> DisplayName { get; } = new(
        name: @"--display-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl>> Urls { get; } = new(
        name: @"--urls")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::Anam.CreateLlmRequestLlmFormat> LlmFormat { get; } = new(
        name: @"--llm-format")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> ModelName { get; } = new(
        name: @"--model-name")
    {
        Description = @"",
        Required = true,
    };

    private static Option<string> Secret { get; } = new(
        name: @"--secret")
    {
        Description = @"",
        Required = true,
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"",
    };

    private static Option<global::Anam.CreateLlmRequestReasoningEffort?> ReasoningEffort { get; } = new(
        name: @"--reasoning-effort")
    {
        Description = @"",
    };

    private static Option<global::Anam.CreateLlmRequestReasoningFormat?> ReasoningFormat { get; } = new(
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
        var command = new Command(@"create-llm", @"Create LLM
Create a new LLM configuration.");
                        command.Options.Add(DisplayName);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Urls);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.CreateLlmRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var displayName = parseResult.GetRequiredValue(DisplayName);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var urls = parseResult.GetRequiredValue(Urls);
                        var llmFormat = parseResult.GetRequiredValue(LlmFormat);
                        var modelName = parseResult.GetRequiredValue(ModelName);
                        var secret = parseResult.GetRequiredValue(Secret);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var reasoningEffort = CliRuntime.WasSpecified(parseResult, ReasoningEffort) ? parseResult.GetValue(ReasoningEffort) : (__requestBase is { } __ReasoningEffortBaseValue ? __ReasoningEffortBaseValue.ReasoningEffort : default);
                        var reasoningFormat = CliRuntime.WasSpecified(parseResult, ReasoningFormat) ? parseResult.GetValue(ReasoningFormat) : (__requestBase is { } __ReasoningFormatBaseValue ? __ReasoningFormatBaseValue.ReasoningFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.LLMs.CreateLlmAsync(
                                    displayName: displayName,
                                    description: description,
                                    urls: urls,
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