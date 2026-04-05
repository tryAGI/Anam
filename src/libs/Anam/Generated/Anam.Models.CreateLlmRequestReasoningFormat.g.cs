
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLlmRequestReasoningFormat
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
    public static class CreateLlmRequestReasoningFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLlmRequestReasoningFormat value)
        {
            return value switch
            {
                CreateLlmRequestReasoningFormat.Hidden => "hidden",
                CreateLlmRequestReasoningFormat.Parsed => "parsed",
                CreateLlmRequestReasoningFormat.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLlmRequestReasoningFormat? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => CreateLlmRequestReasoningFormat.Hidden,
                "parsed" => CreateLlmRequestReasoningFormat.Parsed,
                "raw" => CreateLlmRequestReasoningFormat.Raw,
                _ => null,
            };
        }
    }
}