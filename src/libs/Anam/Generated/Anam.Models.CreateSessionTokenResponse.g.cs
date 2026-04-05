
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionTokenResponse
    {
        /// <summary>
        /// The session token for client-side use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionToken")]
        public string? SessionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenResponse" /> class.
        /// </summary>
        /// <param name="sessionToken">
        /// The session token for client-side use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionTokenResponse(
            string? sessionToken)
        {
            this.SessionToken = sessionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenResponse" /> class.
        /// </summary>
        public CreateSessionTokenResponse()
        {
        }
    }
}