#nullable enable

namespace Anam
{
    public partial interface ILLMsClient
    {
        /// <summary>
        /// List LLMs<br/>
        /// Returns a list of all LLMs available to the organization.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="search"></param>
        /// <param name="includeDefaults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.ListLlmsResponse> ListLlmsAsync(
            int? page = default,
            int? perPage = default,
            string? search = default,
            bool? includeDefaults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}