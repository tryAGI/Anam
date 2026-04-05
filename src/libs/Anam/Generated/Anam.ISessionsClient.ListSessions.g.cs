#nullable enable

namespace Anam
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List sessions<br/>
        /// Returns a paginated list of all sessions for the organization.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="search"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="personaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task ListSessionsAsync(
            int? page = default,
            int? perPage = default,
            string? search = default,
            global::System.Guid? apiKeyId = default,
            global::System.Guid? personaId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}