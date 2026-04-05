
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLlmRequestReasoningEffort
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
    public static class CreateLlmRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLlmRequestReasoningEffort value)
        {
            return value switch
            {
                CreateLlmRequestReasoningEffort.Default => "default",
                CreateLlmRequestReasoningEffort.High => "high",
                CreateLlmRequestReasoningEffort.Low => "low",
                CreateLlmRequestReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLlmRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateLlmRequestReasoningEffort.Default,
                "high" => CreateLlmRequestReasoningEffort.High,
                "low" => CreateLlmRequestReasoningEffort.Low,
                "medium" => CreateLlmRequestReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}