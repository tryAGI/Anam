
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionTokenRequestSessionOptionsSessionReplay
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableSessionReplay")]
        public bool? EnableSessionReplay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestSessionOptionsSessionReplay" /> class.
        /// </summary>
        /// <param name="enableSessionReplay">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionTokenRequestSessionOptionsSessionReplay(
            bool? enableSessionReplay)
        {
            this.EnableSessionReplay = enableSessionReplay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionTokenRequestSessionOptionsSessionReplay" /> class.
        /// </summary>
        public CreateSessionTokenRequestSessionOptionsSessionReplay()
        {
        }

    }
}