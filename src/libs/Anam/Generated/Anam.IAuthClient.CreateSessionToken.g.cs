#nullable enable

namespace Anam
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create session token<br/>
        /// Creates a temporary session token for client-side use. The session token is valid for 1 hour.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.CreateSessionTokenResponse> CreateSessionTokenAsync(

            global::Anam.CreateSessionTokenRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session token<br/>
        /// Creates a temporary session token for client-side use. The session token is valid for 1 hour.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.AutoSDKHttpResponse<global::Anam.CreateSessionTokenResponse>> CreateSessionTokenAsResponseAsync(

            global::Anam.CreateSessionTokenRequest request,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session token<br/>
        /// Creates a temporary session token for client-side use. The session token is valid for 1 hour.
        /// </summary>
        /// <param name="clientLabel">
        /// Identifier for the session.
        /// </param>
        /// <param name="personaConfig">
        /// Persona configuration. Either provide inline config or a personaId.
        /// </param>
        /// <param name="sessionOptions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anam.CreateSessionTokenResponse> CreateSessionTokenAsync(
            string? clientLabel = default,
            global::Anam.CreateSessionTokenRequestPersonaConfig? personaConfig = default,
            global::Anam.CreateSessionTokenRequestSessionOptions? sessionOptions = default,
            global::Anam.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}