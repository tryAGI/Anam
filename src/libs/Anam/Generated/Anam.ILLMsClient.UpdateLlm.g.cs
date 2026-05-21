#nullable enable

namespace Anam
{
    public partial interface ILLMsClient
    {
        /// <summary>
        /// Update LLM<br/>
        /// Update an LLM configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Llm> UpdateLlmAsync(
            string id,

            global::Anam.UpdateLlmRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update LLM<br/>
        /// Update an LLM configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.AutoSDKHttpResponse<global::Anam.Llm>> UpdateLlmAsResponseAsync(
            string id,

            global::Anam.UpdateLlmRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update LLM<br/>
        /// Update an LLM configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="url"></param>
        /// <param name="llmFormat"></param>
        /// <param name="modelName"></param>
        /// <param name="secret"></param>
        /// <param name="metadata"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="reasoningFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Llm> UpdateLlmAsync(
            string id,
            string? displayName = default,
            string? description = default,
            string? url = default,
            global::Anam.UpdateLlmRequestLlmFormat? llmFormat = default,
            string? modelName = default,
            string? secret = default,
            object? metadata = default,
            global::Anam.UpdateLlmRequestReasoningEffort? reasoningEffort = default,
            global::Anam.UpdateLlmRequestReasoningFormat? reasoningFormat = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}