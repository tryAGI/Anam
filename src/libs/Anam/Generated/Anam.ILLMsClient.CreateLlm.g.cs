#nullable enable

namespace Anam
{
    public partial interface ILLMsClient
    {
        /// <summary>
        /// Create LLM<br/>
        /// Create a new LLM configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateLlmAsync(

            global::Anam.CreateLlmRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create LLM<br/>
        /// Create a new LLM configuration.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="urls"></param>
        /// <param name="llmFormat"></param>
        /// <param name="modelName"></param>
        /// <param name="secret"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="reasoningFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateLlmAsync(
            string displayName,
            global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl> urls,
            global::Anam.CreateLlmRequestLlmFormat llmFormat,
            string modelName,
            string secret,
            string? description = default,
            object? metadata = default,
            global::Anam.CreateLlmRequestReasoningEffort? reasoningEffort = default,
            global::Anam.CreateLlmRequestReasoningFormat? reasoningFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}