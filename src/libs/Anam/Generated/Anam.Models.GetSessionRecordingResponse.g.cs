
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSessionRecordingResponse
    {
        /// <summary>
        /// Presigned URL to download the recording (expires in 1 hour).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUrl")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionRecordingResponse" /> class.
        /// </summary>
        /// <param name="recordingUrl">
        /// Presigned URL to download the recording (expires in 1 hour).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSessionRecordingResponse(
            string? recordingUrl)
        {
            this.RecordingUrl = recordingUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionRecordingResponse" /> class.
        /// </summary>
        public GetSessionRecordingResponse()
        {
        }

    }
}