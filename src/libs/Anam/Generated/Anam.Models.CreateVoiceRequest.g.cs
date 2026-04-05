
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceRequest
    {
        /// <summary>
        /// Display name for the cloned voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Audio file to clone the voice from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioFile { get; set; }

        /// <summary>
        /// Audio file to clone the voice from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFilename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFilename { get; set; }

        /// <summary>
        /// Optional description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Language code for the voice.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Whether to enhance the voice quality.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance")]
        public bool? Enhance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name for the cloned voice.
        /// </param>
        /// <param name="audioFile">
        /// Audio file to clone the voice from.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to clone the voice from.
        /// </param>
        /// <param name="description">
        /// Optional description of the voice.
        /// </param>
        /// <param name="language">
        /// Language code for the voice.<br/>
        /// Default Value: en
        /// </param>
        /// <param name="enhance">
        /// Whether to enhance the voice quality.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceRequest(
            string name,
            byte[] audioFile,
            string audioFilename,
            string? description,
            string? language,
            bool? enhance)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AudioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            this.AudioFilename = audioFilename ?? throw new global::System.ArgumentNullException(nameof(audioFilename));
            this.Description = description;
            this.Language = language;
            this.Enhance = enhance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        public CreateVoiceRequest()
        {
        }
    }
}