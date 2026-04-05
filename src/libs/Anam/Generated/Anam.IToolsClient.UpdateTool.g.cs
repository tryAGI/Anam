#nullable enable

namespace Anam
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Update tool<br/>
        /// Update an existing tool.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Tool> UpdateToolAsync(
            global::System.Guid id,

            global::Anam.UpdateToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update tool<br/>
        /// Update an existing tool.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// Updated name for the tool.
        /// </param>
        /// <param name="description">
        /// Updated description of what the tool does.
        /// </param>
        /// <param name="type"></param>
        /// <param name="config">
        /// Updated type-specific configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.Tool> UpdateToolAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            global::Anam.UpdateToolRequestType? type = default,
            object? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}