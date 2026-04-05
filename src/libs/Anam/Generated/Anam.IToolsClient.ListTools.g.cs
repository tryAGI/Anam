#nullable enable

namespace Anam
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List tools<br/>
        /// Returns a list of all tools for the organization.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ListToolsResponse> ListToolsAsync(
            int? page = default,
            int? perPage = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}