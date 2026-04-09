
#nullable enable

namespace Anam
{
    public partial class PersonasClient
    {


        private static readonly global::Anam.EndPointSecurityRequirement s_CreatePersonaSecurityRequirement0 =
            new global::Anam.EndPointSecurityRequirement
            {
                Authorizations = new global::Anam.EndPointAuthorizationRequirement[]
                {                    new global::Anam.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Anam.EndPointSecurityRequirement[] s_CreatePersonaSecurityRequirements =
            new global::Anam.EndPointSecurityRequirement[]
            {                s_CreatePersonaSecurityRequirement0,
            };
        partial void PrepareCreatePersonaArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Anam.PersonaConfig request);
        partial void PrepareCreatePersonaRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Anam.PersonaConfig request);
        partial void ProcessCreatePersonaResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePersonaResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create persona<br/>
        /// Create a new persona with avatar, voice, LLM, and system prompt configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anam.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anam.PersonaConfig> CreatePersonaAsync(

            global::Anam.PersonaConfig request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePersonaArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Anam.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePersonaSecurityRequirements,
                operationName: "CreatePersonaAsync");

            var __pathBuilder = new global::Anam.PathBuilder(
                path: "/v1/personas",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreatePersonaRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreatePersonaResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Anam.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Anam.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Anam.ApiException(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreatePersonaResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Anam.PersonaConfig.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Anam.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Anam.PersonaConfig.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Anam.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create persona<br/>
        /// Create a new persona with avatar, voice, LLM, and system prompt configuration.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the persona.
        /// </param>
        /// <param name="name">
        /// Name of the persona.
        /// </param>
        /// <param name="description">
        /// Description of the persona.
        /// </param>
        /// <param name="avatarId">
        /// The avatar to use.
        /// </param>
        /// <param name="avatarModel">
        /// Avatar model version.
        /// </param>
        /// <param name="voiceId">
        /// The voice to use.
        /// </param>
        /// <param name="llmId">
        /// The LLM to use.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt for the LLM.
        /// </param>
        /// <param name="skipGreeting">
        /// Whether to skip the greeting message.
        /// </param>
        /// <param name="zeroDataRetention">
        /// When true, session data is not stored after the conversation ends.
        /// </param>
        /// <param name="voiceDetectionOptions">
        /// Options for voice activity detection during user speech input.
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1 language code override for transcription.
        /// </param>
        /// <param name="toolIds">
        /// Array of tool IDs to attach to the persona.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Anam.PersonaConfig> CreatePersonaAsync(
            global::System.Guid? id = default,
            string? name = default,
            string? description = default,
            string? avatarId = default,
            global::Anam.PersonaConfigAvatarModel? avatarModel = default,
            string? voiceId = default,
            string? llmId = default,
            string? systemPrompt = default,
            bool? skipGreeting = default,
            bool? zeroDataRetention = default,
            global::Anam.VoiceDetectionOptions? voiceDetectionOptions = default,
            string? languageCode = default,
            global::System.Collections.Generic.IList<string>? toolIds = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? updatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Anam.PersonaConfig
            {
                Id = id,
                Name = name,
                Description = description,
                AvatarId = avatarId,
                AvatarModel = avatarModel,
                VoiceId = voiceId,
                LlmId = llmId,
                SystemPrompt = systemPrompt,
                SkipGreeting = skipGreeting,
                ZeroDataRetention = zeroDataRetention,
                VoiceDetectionOptions = voiceDetectionOptions,
                LanguageCode = languageCode,
                ToolIds = toolIds,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
            };

            return await CreatePersonaAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}