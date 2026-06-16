#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class PersonasUpdatePersonaCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"Persona ID.",
    };

    private static Option<global::System.Guid?> RequestId { get; } = new(
        name: @"--id")
    {
        Description = @"Unique identifier for the persona.",
    };
    private static readonly PersonaConfigOptionSet PersonaConfigOptionSetOptions = PersonaConfigOptionSet.Create();

    private static readonly VoiceDetectionOptionsOptionSet VoiceDetectionOptionsOptions = VoiceDetectionOptionsOptionSet.Create(@"voice-detection");
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

                    private static string FormatResponse(ParseResult parseResult, global::Anam.PersonaConfig value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.PersonaConfig value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"update-persona", @"Update persona
Update a persona by ID.");
                        command.Arguments.Add(Id);
                        command.Options.Add(RequestId);                        command.Options.Add(PersonaConfigOptionSetOptions.NameOption);
                        command.Options.Add(PersonaConfigOptionSetOptions.DescriptionOption);
                        command.Options.Add(PersonaConfigOptionSetOptions.AvatarId);
                        command.Options.Add(PersonaConfigOptionSetOptions.AvatarModel);
                        command.Options.Add(PersonaConfigOptionSetOptions.VoiceId);
                        command.Options.Add(PersonaConfigOptionSetOptions.LlmId);
                        command.Options.Add(PersonaConfigOptionSetOptions.SystemPrompt);
                        command.Options.Add(PersonaConfigOptionSetOptions.SkipGreeting);
                        command.Options.Add(PersonaConfigOptionSetOptions.ZeroDataRetention);
                        command.Options.Add(PersonaConfigOptionSetOptions.LanguageCode);
                        command.Options.Add(PersonaConfigOptionSetOptions.ToolIds);
                        command.Options.Add(PersonaConfigOptionSetOptions.CreatedAt);
                        command.Options.Add(PersonaConfigOptionSetOptions.UpdatedAt);                        command.Options.Add(VoiceDetectionOptionsOptions.EndOfSpeechSensitivity);
                        command.Options.Add(VoiceDetectionOptionsOptions.SilenceBeforeSkipTurnSeconds);
                        command.Options.Add(VoiceDetectionOptionsOptions.SilenceBeforeSessionEndSeconds);
                        command.Options.Add(VoiceDetectionOptionsOptions.SilenceBeforeAutoEndTurnSeconds);
                        command.Options.Add(VoiceDetectionOptionsOptions.SpeechEnhancementLevel);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.PersonaConfig>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var requestId = CliRuntime.WasSpecified(parseResult, RequestId) ? parseResult.GetValue(RequestId) : (__requestBase is { } __RequestIdBaseValue ? __RequestIdBaseValue.Id : default);                        var name = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.NameOption) ? parseResult.GetValue(PersonaConfigOptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var description = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.DescriptionOption) ? parseResult.GetValue(PersonaConfigOptionSetOptions.DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var avatarId = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.AvatarId) ? parseResult.GetValue(PersonaConfigOptionSetOptions.AvatarId) : (__requestBase is { } __AvatarIdBaseValue ? __AvatarIdBaseValue.AvatarId : default);
                        var avatarModel = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.AvatarModel) ? parseResult.GetValue(PersonaConfigOptionSetOptions.AvatarModel) : (__requestBase is { } __AvatarModelBaseValue ? __AvatarModelBaseValue.AvatarModel : default);
                        var voiceId = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.VoiceId) ? parseResult.GetValue(PersonaConfigOptionSetOptions.VoiceId) : (__requestBase is { } __VoiceIdBaseValue ? __VoiceIdBaseValue.VoiceId : default);
                        var llmId = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.LlmId) ? parseResult.GetValue(PersonaConfigOptionSetOptions.LlmId) : (__requestBase is { } __LlmIdBaseValue ? __LlmIdBaseValue.LlmId : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.SystemPrompt) ? parseResult.GetValue(PersonaConfigOptionSetOptions.SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                        var skipGreeting = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.SkipGreeting) ? parseResult.GetValue(PersonaConfigOptionSetOptions.SkipGreeting) : (__requestBase is { } __SkipGreetingBaseValue ? __SkipGreetingBaseValue.SkipGreeting : default);
                        var zeroDataRetention = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.ZeroDataRetention) ? parseResult.GetValue(PersonaConfigOptionSetOptions.ZeroDataRetention) : (__requestBase is { } __ZeroDataRetentionBaseValue ? __ZeroDataRetentionBaseValue.ZeroDataRetention : default);
                        var languageCode = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.LanguageCode) ? parseResult.GetValue(PersonaConfigOptionSetOptions.LanguageCode) : (__requestBase is { } __LanguageCodeBaseValue ? __LanguageCodeBaseValue.LanguageCode : default);
                        var toolIds = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.ToolIds) ? parseResult.GetValue(PersonaConfigOptionSetOptions.ToolIds) : (__requestBase is { } __ToolIdsBaseValue ? __ToolIdsBaseValue.ToolIds : default);
                        var createdAt = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.CreatedAt) ? parseResult.GetValue(PersonaConfigOptionSetOptions.CreatedAt) : (__requestBase is { } __CreatedAtBaseValue ? __CreatedAtBaseValue.CreatedAt : default);
                        var updatedAt = CliRuntime.WasSpecified(parseResult, PersonaConfigOptionSetOptions.UpdatedAt) ? parseResult.GetValue(PersonaConfigOptionSetOptions.UpdatedAt) : (__requestBase is { } __UpdatedAtBaseValue ? __UpdatedAtBaseValue.UpdatedAt : default);

                        var __VoiceDetectionOptionsBase = __requestBase is { } __VoiceDetectionOptionsBaseValue ? __VoiceDetectionOptionsBaseValue.VoiceDetectionOptions : default;                        var voiceDetectionOptionsEndOfSpeechSensitivity = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.EndOfSpeechSensitivity) ? parseResult.GetValue(VoiceDetectionOptionsOptions.EndOfSpeechSensitivity) : (__VoiceDetectionOptionsBase is { } __VoiceDetectionOptionsendOfSpeechSensitivityBaseValue ? __VoiceDetectionOptionsendOfSpeechSensitivityBaseValue.EndOfSpeechSensitivity : default);
                        var voiceDetectionOptionsSilenceBeforeSkipTurnSeconds = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeSkipTurnSeconds) ? parseResult.GetValue(VoiceDetectionOptionsOptions.SilenceBeforeSkipTurnSeconds) : (__VoiceDetectionOptionsBase is { } __VoiceDetectionOptionssilenceBeforeSkipTurnSecondsBaseValue ? __VoiceDetectionOptionssilenceBeforeSkipTurnSecondsBaseValue.SilenceBeforeSkipTurnSeconds : default);
                        var voiceDetectionOptionsSilenceBeforeSessionEndSeconds = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeSessionEndSeconds) ? parseResult.GetValue(VoiceDetectionOptionsOptions.SilenceBeforeSessionEndSeconds) : (__VoiceDetectionOptionsBase is { } __VoiceDetectionOptionssilenceBeforeSessionEndSecondsBaseValue ? __VoiceDetectionOptionssilenceBeforeSessionEndSecondsBaseValue.SilenceBeforeSessionEndSeconds : default);
                        var voiceDetectionOptionsSilenceBeforeAutoEndTurnSeconds = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeAutoEndTurnSeconds) ? parseResult.GetValue(VoiceDetectionOptionsOptions.SilenceBeforeAutoEndTurnSeconds) : (__VoiceDetectionOptionsBase is { } __VoiceDetectionOptionssilenceBeforeAutoEndTurnSecondsBaseValue ? __VoiceDetectionOptionssilenceBeforeAutoEndTurnSecondsBaseValue.SilenceBeforeAutoEndTurnSeconds : default);
                        var voiceDetectionOptionsSpeechEnhancementLevel = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SpeechEnhancementLevel) ? parseResult.GetValue(VoiceDetectionOptionsOptions.SpeechEnhancementLevel) : (__VoiceDetectionOptionsBase is { } __VoiceDetectionOptionsspeechEnhancementLevelBaseValue ? __VoiceDetectionOptionsspeechEnhancementLevelBaseValue.SpeechEnhancementLevel : default);
                        var __VoiceDetectionOptionsSpecified = CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.EndOfSpeechSensitivity) || CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeSkipTurnSeconds) || CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeSessionEndSeconds) || CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SilenceBeforeAutoEndTurnSeconds) || CliRuntime.WasSpecified(parseResult, VoiceDetectionOptionsOptions.SpeechEnhancementLevel);
                        var voiceDetectionOptions =
                            __VoiceDetectionOptionsSpecified || __VoiceDetectionOptionsBase is not null
                                ? new global::Anam.VoiceDetectionOptions
                                {
	                                EndOfSpeechSensitivity = voiceDetectionOptionsEndOfSpeechSensitivity,
                                SilenceBeforeSkipTurnSeconds = voiceDetectionOptionsSilenceBeforeSkipTurnSeconds,
                                SilenceBeforeSessionEndSeconds = voiceDetectionOptionsSilenceBeforeSessionEndSeconds,
                                SilenceBeforeAutoEndTurnSeconds = voiceDetectionOptionsSilenceBeforeAutoEndTurnSeconds,
                                SpeechEnhancementLevel = voiceDetectionOptionsSpeechEnhancementLevel,

                                }
                                : __VoiceDetectionOptionsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Personas.UpdatePersonaAsync(
                                    id: id,
                                    requestId: requestId,
                                    name: name,
                                    description: description,
                                    avatarId: avatarId,
                                    avatarModel: avatarModel,
                                    voiceId: voiceId,
                                    llmId: llmId,
                                    systemPrompt: systemPrompt,
                                    skipGreeting: skipGreeting,
                                    zeroDataRetention: zeroDataRetention,
                                    languageCode: languageCode,
                                    toolIds: toolIds,
                                    createdAt: createdAt,
                                    updatedAt: updatedAt,
                                    voiceDetectionOptions: voiceDetectionOptions,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Anam.SourceGenerationContext.Default,
                                        @"ToolIds",
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