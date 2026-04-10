#nullable enable

namespace Anam
{
    public partial interface IShareLinksClient
    {
        /// <summary>
        /// List share links<br/>
        /// Returns a list of all share links for the organization.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 20
        /// </param>
        /// <param name="search"></param>
        /// <param name="personaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ListShareLinksResponse> ListShareLinksAsync(
            int? page = default,
            int? perPage = default,
            string? search = default,
            global::System.Guid? personaId = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}