
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLlmRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.UpdateLlmRequestLlmFormatJsonConverter))]
        public global::Anam.UpdateLlmRequestLlmFormat? LlmFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningEffortJsonConverter))]
        public global::Anam.UpdateLlmRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningFormatJsonConverter))]
        public global::Anam.UpdateLlmRequestReasoningFormat? ReasoningFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLlmRequest" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="url"></param>
        /// <param name="llmFormat"></param>
        /// <param name="modelName"></param>
        /// <param name="secret"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="reasoningFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLlmRequest(
            string? displayName,
            string? description,
            string? url,
            global::Anam.UpdateLlmRequestLlmFormat? llmFormat,
            string? modelName,
            string? secret,
            object? metadata,
            global::Anam.UpdateLlmRequestReasoningEffort? reasoningEffort,
            global::Anam.UpdateLlmRequestReasoningFormat? reasoningFormat)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Url = url;
            this.LlmFormat = llmFormat;
            this.ModelName = modelName;
            this.Secret = secret;
            this.Metadata = metadata;
            this.ReasoningEffort = reasoningEffort;
            this.ReasoningFormat = reasoningFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLlmRequest" /> class.
        /// </summary>
        public UpdateLlmRequest()
        {
        }
    }
}