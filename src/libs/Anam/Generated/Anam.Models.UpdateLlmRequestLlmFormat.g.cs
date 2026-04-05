
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateLlmRequestLlmFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        GroqOpenai,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLlmRequestLlmFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLlmRequestLlmFormat value)
        {
            return value switch
            {
                UpdateLlmRequestLlmFormat.Anthropic => "anthropic",
                UpdateLlmRequestLlmFormat.AzureOpenai => "azure_openai",
                UpdateLlmRequestLlmFormat.Custom => "custom",
                UpdateLlmRequestLlmFormat.GroqOpenai => "groq_openai",
                UpdateLlmRequestLlmFormat.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLlmRequestLlmFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateLlmRequestLlmFormat.Anthropic,
                "azure_openai" => UpdateLlmRequestLlmFormat.AzureOpenai,
                "custom" => UpdateLlmRequestLlmFormat.Custom,
                "groq_openai" => UpdateLlmRequestLlmFormat.GroqOpenai,
                "openai" => UpdateLlmRequestLlmFormat.Openai,
                _ => null,
            };
        }
    }
}