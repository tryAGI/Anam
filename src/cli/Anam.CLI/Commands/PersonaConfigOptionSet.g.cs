#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal sealed record PersonaConfigOptionSet(
    Option<global::System.Guid?> Id,
                     Option<string?> NameOption,
                     Option<string?> DescriptionOption,
                     Option<string?> AvatarId,
                     Option<global::Anam.PersonaConfigAvatarModel?> AvatarModel,
                     Option<string?> VoiceId,
                     Option<string?> LlmId,
                     Option<string?> SystemPrompt,
                     Option<bool?> SkipGreeting,
                     Option<bool?> ZeroDataRetention,
                     Option<string?> LanguageCode,
                     Option<global::System.Collections.Generic.IList<string>?> ToolIds,
                     Option<global::System.DateTime?> CreatedAt,
                     Option<global::System.DateTime?> UpdatedAt)
{
    public static PersonaConfigOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PersonaConfigOptionSet(
                        Id: new Option<global::System.Guid?>($"--{normalizedPrefix}id")
                {
                    Description = @"Unique identifier for the persona.",
                },
                NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"Name of the persona.",
                },
                DescriptionOption: new Option<string?>($"--{normalizedPrefix}description")
                {
                    Description = @"Description of the persona.",
                },
                AvatarId: new Option<string?>($"--{normalizedPrefix}avatar-id")
                {
                    Description = @"The avatar to use.",
                },
                AvatarModel: new Option<global::Anam.PersonaConfigAvatarModel?>($"--{normalizedPrefix}avatar-model")
                {
                    Description = @"Avatar model version.",
                },
                VoiceId: new Option<string?>($"--{normalizedPrefix}voice-id")
                {
                    Description = @"The voice to use.",
                },
                LlmId: new Option<string?>($"--{normalizedPrefix}llm-id")
                {
                    Description = @"The LLM to use.",
                },
                SystemPrompt: new Option<string?>($"--{normalizedPrefix}system-prompt")
                {
                    Description = @"System prompt for the LLM.",
                },
                SkipGreeting: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}skip-greeting", description: @"Whether to skip the greeting message."),
                ZeroDataRetention: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}zero-data-retention", description: @"When true, session data is not stored after the conversation ends."),
                LanguageCode: new Option<string?>($"--{normalizedPrefix}language-code")
                {
                    Description = @"ISO 639-1 language code override for transcription.",
                },
                ToolIds: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}tool-ids")
                {
                    Description = @"Array of tool IDs to attach to the persona.",
                },
                CreatedAt: new Option<global::System.DateTime?>($"--{normalizedPrefix}created-at")
                {
                    Description = @"",
                },
                UpdatedAt: new Option<global::System.DateTime?>($"--{normalizedPrefix}updated-at")
                {
                    Description = @"",
                }
        );
    }
}