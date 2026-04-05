#nullable enable

namespace Anam
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get tool<br/>
        /// Get a tool by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Tool> GetToolAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}