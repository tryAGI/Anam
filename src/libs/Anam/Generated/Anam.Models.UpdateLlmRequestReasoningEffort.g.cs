
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateLlmRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLlmRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLlmRequestReasoningEffort value)
        {
            return value switch
            {
                UpdateLlmRequestReasoningEffort.Default => "default",
                UpdateLlmRequestReasoningEffort.High => "high",
                UpdateLlmRequestReasoningEffort.Low => "low",
                UpdateLlmRequestReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLlmRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "default" => UpdateLlmRequestReasoningEffort.Default,
                "high" => UpdateLlmRequestReasoningEffort.High,
                "low" => UpdateLlmRequestReasoningEffort.Low,
                "medium" => UpdateLlmRequestReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}