#nullable enable

namespace Anam
{
    public partial interface ILLMsClient
    {
        /// <summary>
        /// Get LLM<br/>
        /// Get a specific LLM by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task GetLlmAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}