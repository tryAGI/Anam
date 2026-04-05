
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLlmRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl> Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CreateLlmRequestLlmFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anam.CreateLlmRequestLlmFormat LlmFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningEffort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningEffortJsonConverter))]
        public global::Anam.CreateLlmRequestReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningFormatJsonConverter))]
        public global::Anam.CreateLlmRequestReasoningFormat? ReasoningFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLlmRequest" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="urls"></param>
        /// <param name="llmFormat"></param>
        /// <param name="modelName"></param>
        /// <param name="secret"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="reasoningFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLlmRequest(
            string displayName,
            global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl> urls,
            global::Anam.CreateLlmRequestLlmFormat llmFormat,
            string modelName,
            string secret,
            string? description,
            object? metadata,
            global::Anam.CreateLlmRequestReasoningEffort? reasoningEffort,
            global::Anam.CreateLlmRequestReasoningFormat? reasoningFormat)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.LlmFormat = llmFormat;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.Metadata = metadata;
            this.ReasoningEffort = reasoningEffort;
            this.ReasoningFormat = reasoningFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLlmRequest" /> class.
        /// </summary>
        public CreateLlmRequest()
        {
        }
    }
}