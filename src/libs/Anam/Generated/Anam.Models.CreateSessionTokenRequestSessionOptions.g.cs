
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionTokenRequestSessionOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionReplay")]
        public global::Anam.CreateSessionTokenRequestSessionOptionsSessionReplay? SessionReplay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestSessionOptions" /> class.
        /// </summary>
        /// <param name="sessionReplay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionTokenRequestSessionOptions(
            global::Anam.CreateSessionTokenRequestSessionOptionsSessionReplay? sessionReplay)
        {
            this.SessionReplay = sessionReplay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestSessionOptions" /> class.
        /// </summary>
        public CreateSessionTokenRequestSessionOptions()
        {
        }
    }
}