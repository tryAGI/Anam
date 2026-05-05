#nullable enable

namespace Anam
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create tool<br/>
        /// Create a new tool for function calling in persona sessions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Tool> CreateToolAsync(

            global::Anam.CreateToolRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tool<br/>
        /// Create a new tool for function calling in persona sessions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.AutoSDKHttpResponse<global::Anam.Tool>> CreateToolAsResponseAsync(

            global::Anam.CreateToolRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create tool<br/>
        /// Create a new tool for function calling in persona sessions.
        /// </summary>
        /// <param name="name">
        /// Unique name for the tool (pattern [a-zA-Z0-9_.-]+).
        /// </param>
        /// <param name="description">
        /// Description of what the tool does.
        /// </param>
        /// <param name="type">
        /// Type of tool.
        /// </param>
        /// <param name="config">
        /// Type-specific configuration for the tool.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Tool> CreateToolAsync(
            string name,
            string description,
            global::Anam.CreateToolRequestType type,
            object? config = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}