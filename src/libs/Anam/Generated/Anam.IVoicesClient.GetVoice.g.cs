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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Voice> GetVoiceAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}