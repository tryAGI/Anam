#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Anam;

/// <summary>
/// MEAI AIFunction tool extensions for AnamClient.
/// </summary>
public static class AnamClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that creates a session token for client-side use.
    /// </summary>
    public static AIFunction AsCreateSessionTokenTool(this AnamClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional identifier for the session")] string? clientLabel,
                   [Description("Optional persona ID to use an existing persona")] string? personaId,
                   CancellationToken cancellationToken) =>
            {
                var personaConfig = personaId is { Length: > 0 }
                    ? new CreateSessionTokenRequestPersonaConfig
                    {
                        PersonaId = personaId,
                    }
                    : null;

                var response = await client.Auth.CreateSessionTokenAsync(
                    clientLabel: clientLabel,
                    personaConfig: personaConfig,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.SessionToken,
                };
            },
            name: "Anam_CreateSessionToken",
            description: "Create a temporary session token for client-side Anam avatar use. The token is valid for 1 hour. Optionally specify a persona to use.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available voices.
    /// </summary>
    public static AIFunction AsListVoicesTool(this AnamClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Page number for pagination (default 1)")] int? page,
                   [Description("Number of voices per page, max 100 (default 10)")] int? perPage,
                   [Description("Search term to filter voices by display name")] string? search,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Voices.ListVoicesAsync(
                    page: page,
                    perPage: perPage,
                    search: search,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Voices = response.Data?.Select(v => new
                    {
                        v.Id,
                        v.DisplayName,
                        v.Provider,
                        v.Gender,
                        v.Country,
                        v.Description,
                        v.SampleUrl,
                    }),
                    response.Meta,
                };
            },
            name: "Anam_ListVoices",
            description: "List available Anam voices with optional search and pagination. Returns voice details including provider, gender, and country.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available avatars.
    /// </summary>
    public static AIFunction AsListAvatarsTool(this AnamClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Page number for pagination (default 1)")] int? page,
                   [Description("Number of avatars per page, max 100 (default 10)")] int? perPage,
                   [Description("Search term to filter avatars by display name")] string? search,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Avatars.ListAvatarsAsync(
                    page: page,
                    perPage: perPage,
                    search: search,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Avatars = response.Data?.Select(a => new
                    {
                        a.Id,
                        a.DisplayName,
                        a.VariantName,
                        a.ImageUrl,
                    }),
                    response.Meta,
                };
            },
            name: "Anam_ListAvatars",
            description: "List available Anam avatars with optional search and pagination. Returns avatar details including display name, variant, and image URL.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists personas.
    /// </summary>
    public static AIFunction AsListPersonasTool(this AnamClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Page number for pagination (default 1)")] int? page,
                   [Description("Number of personas per page, max 100 (default 10)")] int? perPage,
                   [Description("Search term to filter personas by name")] string? search,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Personas.ListPersonasAsync(
                    page: page,
                    perPage: perPage,
                    search: search,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Data,
                    response.Meta,
                };
            },
            name: "Anam_ListPersonas",
            description: "List all Anam personas with optional search and pagination. Personas combine an avatar, voice, LLM, and system prompt into a deployable AI character.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches a knowledge group using vector similarity.
    /// The knowledgeGroupId is captured at creation time so the LLM only needs to provide a query.
    /// </summary>
    public static AIFunction AsSearchKnowledgeTool(
        this AnamClient client,
        string knowledgeGroupId)
    {
        return AIFunctionFactory.Create(
            async ([Description("The search query text to find similar content")] string query,
                   [Description("Maximum number of results to return (default 5)")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Knowledge.SearchKnowledgeGroupAsync(
                    id: knowledgeGroupId,
                    query: query,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Results = response.Results?.Select(r => new
                    {
                        r.Content,
                        r.Score,
                        r.DocumentId,
                        r.Metadata,
                    }),
                };
            },
            name: "Anam_SearchKnowledge",
            description: "Search for similar content in an Anam knowledge group using vector similarity. Returns matched content chunks with similarity scores and source document IDs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the transcript of a session.
    /// </summary>
    public static AIFunction AsGetSessionTranscriptTool(this AnamClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The session ID (UUID) to get the transcript for")] string sessionId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Sessions.GetSessionTranscriptAsync(
                    id: Guid.Parse(sessionId),
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.SessionId,
                    response.PersonaName,
                    response.StartTime,
                    response.EndTime,
                    response.DurationMs,
                    response.TotalMessages,
                    Messages = response.Messages?.Select(m => new
                    {
                        m.Role,
                        m.Message,
                        m.Timestamp,
                        m.SpeakingDurationSeconds,
                        m.WasInterrupted,
                    }),
                };
            },
            name: "Anam_GetSessionTranscript",
            description: "Get the conversation transcript for an Anam avatar session by ID. Returns all messages with roles, timestamps, and speaking durations.");
    }
}
