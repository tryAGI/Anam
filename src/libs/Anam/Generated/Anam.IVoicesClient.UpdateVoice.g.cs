#nullable enable

namespace Anam
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update voice<br/>
        /// Update a voice by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> UpdateVoiceAsync(
            global::System.Guid id,

            global::Anam.UpdateVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Update a voice by ID.
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> UpdateVoiceAsync(
            global::System.Guid id,
            string displayName,
            string? providerModelId = default,
            global::Anam.UpdateVoiceRequestGender? gender = default,
            string? country = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}