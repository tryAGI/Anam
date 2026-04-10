#nullable enable

namespace Anam
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get voice<br/>
        /// Returns a voice by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> GetVoiceAsync(
            global::System.Guid id,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}