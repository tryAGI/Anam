
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLlmRequestLlmFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AdvancedVoice,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        GroqOpenai,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLlmRequestLlmFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLlmRequestLlmFormat value)
        {
            return value switch
            {
                CreateLlmRequestLlmFormat.AdvancedVoice => "advanced_voice",
                CreateLlmRequestLlmFormat.AzureOpenai => "azure_openai",
                CreateLlmRequestLlmFormat.Gemini => "gemini",
                CreateLlmRequestLlmFormat.GroqOpenai => "groq_openai",
                CreateLlmRequestLlmFormat.None => "none",
                CreateLlmRequestLlmFormat.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLlmRequestLlmFormat? ToEnum(string value)
        {
            return value switch
            {
                "advanced_voice" => CreateLlmRequestLlmFormat.AdvancedVoice,
                "azure_openai" => CreateLlmRequestLlmFormat.AzureOpenai,
                "gemini" => CreateLlmRequestLlmFormat.Gemini,
                "groq_openai" => CreateLlmRequestLlmFormat.GroqOpenai,
                "none" => CreateLlmRequestLlmFormat.None,
                "openai" => CreateLlmRequestLlmFormat.Openai,
                _ => null,
            };
        }
    }
}