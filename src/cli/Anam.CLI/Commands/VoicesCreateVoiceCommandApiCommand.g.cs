#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class VoicesCreateVoiceCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Display name for the cloned voice.",
    };

    private static Option<byte[]> AudioFile { get; } = new(
        name: @"--audio-file")
    {
        Description = @"Audio file to clone the voice from.",
        Required = true,
    };

    private static Option<string> AudioFilename { get; } = new(
        name: @"--audio-filename")
    {
        Description = @"Audio file to clone the voice from.",
        Required = true,
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Optional description of the voice.",
    };

    private static Option<string?> Language { get; } = new(
        name: @"--language")
    {
        Description = @"Language code for the voice.",
    };

    private static Option<bool?> Enhance { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enhance",
        description: @"Whether to enhance the voice quality.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Anam.Voice value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.Voice value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-voice", @"Create voice
Create a new voice by cloning from an audio file.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(AudioFile);
                        command.Options.Add(AudioFilename);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(Language);
                        command.Options.Add(Enhance);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.CreateVoiceRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var audioFile = parseResult.GetRequiredValue(AudioFile);
                        var audioFilename = parseResult.GetRequiredValue(AudioFilename);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var language = CliRuntime.WasSpecified(parseResult, Language) ? parseResult.GetValue(Language) : (__requestBase is { } __LanguageBaseValue ? __LanguageBaseValue.Language : default);
                        var enhance = CliRuntime.WasSpecified(parseResult, Enhance) ? parseResult.GetValue(Enhance) : (__requestBase is { } __EnhanceBaseValue ? __EnhanceBaseValue.Enhance : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Voices.CreateVoiceAsync(
                                    name: name,
                                    audioFile: audioFile,
                                    audioFilename: audioFilename,
                                    description: description,
                                    language: language,
                                    enhance: enhance,
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