#nullable enable

namespace Anam
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Create a new voice by cloning from an audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> CreateVoiceAsync(

            global::Anam.CreateVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Create a new voice by cloning from an audio file.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> CreateVoiceAsync(
            string name,
            byte[] audioFile,
            string audioFilename,
            string? description = default,
            string? language = default,
            bool? enhance = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}