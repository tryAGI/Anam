
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateLlmRequestReasoningFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Parsed,
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLlmRequestReasoningFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLlmRequestReasoningFormat value)
        {
            return value switch
            {
                UpdateLlmRequestReasoningFormat.Hidden => "hidden",
                UpdateLlmRequestReasoningFormat.Parsed => "parsed",
                UpdateLlmRequestReasoningFormat.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLlmRequestReasoningFormat? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => UpdateLlmRequestReasoningFormat.Hidden,
                "parsed" => UpdateLlmRequestReasoningFormat.Parsed,
                "raw" => UpdateLlmRequestReasoningFormat.Raw,
                _ => null,
            };
        }
    }
}