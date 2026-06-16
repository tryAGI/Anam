#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal sealed record VoiceDetectionOptionsOptionSet(
    Option<double?> EndOfSpeechSensitivity,
                     Option<double?> SilenceBeforeSkipTurnSeconds,
                     Option<double?> SilenceBeforeSessionEndSeconds,
                     Option<double?> SilenceBeforeAutoEndTurnSeconds,
                     Option<double?> SpeechEnhancementLevel)
{
    public static VoiceDetectionOptionsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new VoiceDetectionOptionsOptionSet(
                        EndOfSpeechSensitivity: new Option<double?>($"--{normalizedPrefix}end-of-speech-sensitivity")
                {
                    Description = @"Sensitivity for detecting end of speech, between 0 (least sensitive) and 1 (most sensitive).",
                },
                SilenceBeforeSkipTurnSeconds: new Option<double?>($"--{normalizedPrefix}silence-before-skip-turn-seconds")
                {
                    Description = @"Duration of silence (in seconds) before the current user turn is skipped.",
                },
                SilenceBeforeSessionEndSeconds: new Option<double?>($"--{normalizedPrefix}silence-before-session-end-seconds")
                {
                    Description = @"Duration of silence (in seconds) before the session is automatically ended.",
                },
                SilenceBeforeAutoEndTurnSeconds: new Option<double?>($"--{normalizedPrefix}silence-before-auto-end-turn-seconds")
                {
                    Description = @"Duration of silence (in seconds) before the user turn is automatically ended.",
                },
                SpeechEnhancementLevel: new Option<double?>($"--{normalizedPrefix}speech-enhancement-level")
                {
                    Description = @"Level of speech enhancement to apply, 0 (no speech enhancement) 1 (max speech enhancement).",
                }
        );
    }
}