#nullable enable

namespace Anam
{
    public partial interface IPersonasClient
    {
        /// <summary>
        /// List personas<br/>
        /// Returns a paginated list of all personas.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ListPersonasResponse> ListPersonasAsync(
            int? page = default,
            int? perPage = default,
            string? search = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}