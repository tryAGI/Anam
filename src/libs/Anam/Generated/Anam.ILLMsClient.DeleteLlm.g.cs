#nullable enable

namespace Anam
{
    public partial interface ILLMsClient
    {
        /// <summary>
        /// Delete LLM<br/>
        /// Delete an LLM configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLlmAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}