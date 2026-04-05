
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVoiceRequest
    {
        /// <summary>
        /// New display name for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// New provider model ID for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModelId")]
        public string? ProviderModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anam.JsonConverters.UpdateVoiceRequestGenderJsonConverter))]
        public global::Anam.UpdateVoiceRequestGender? Gender { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// New display name for the voice.
        /// </param>
        /// <param name="providerModelId">
        /// New provider model ID for the voice.
        /// </param>
        /// <param name="gender"></param>
        /// <param name="country">
        /// ISO 3166-1 alpha-2 country code.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceRequest(
            string displayName,
            string? providerModelId,
            global::Anam.UpdateVoiceRequestGender? gender,
            string? country,
            string? description)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ProviderModelId = providerModelId;
            this.Gender = gender;
            this.Country = country;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceRequest" /> class.
        /// </summary>
        public UpdateVoiceRequest()
        {
        }
    }
}