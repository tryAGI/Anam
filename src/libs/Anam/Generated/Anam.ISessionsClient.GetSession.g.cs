#nullable enable

namespace Anam
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get session<br/>
        /// Returns a session by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Session> GetSessionAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}