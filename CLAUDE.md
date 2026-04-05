# CLAUDE.md -- Anam SDK

## Overview

Auto-generated C# SDK for [Anam](https://anam.ai/) -- realtime AI avatar platform for building interactive conversational experiences with photorealistic digital humans. Covers personas, voices, avatars, sessions, tools (function calling), knowledge groups (RAG), LLM configs, and share links.

OpenAPI spec created manually from the official Anam API documentation at `https://anam.ai/docs/api-reference` (also available as Swagger at `https://api.anam.ai/swagger.json`).

## Build & Test

```bash
dotnet build Anam.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard Bearer token authentication:

```csharp
var client = new AnamClient(apiKey); // ANAM_API_KEY env var
```

## Key Files

- `src/libs/Anam/openapi.yaml` -- OpenAPI 3.0.3 spec (manually authored)
- `src/libs/Anam/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Anam/Generated/` -- **Never edit** -- auto-generated code (~250 files)
- `src/libs/Anam/Extensions/AnamClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new AnamClient(apiKey);

// Auth
client.Auth.CreateSessionTokenAsync(...)       // Create temporary session token

// Avatars
client.Avatars.ListAvatarsAsync(...)           // List avatars
client.Avatars.CreateAvatarAsync(...)          // Create custom avatar

// Voices
client.Voices.ListVoicesAsync(...)             // List voices
client.Voices.GetVoiceAsync(...)               // Get voice by ID
client.Voices.CreateVoiceAsync(...)            // Clone voice from audio
client.Voices.UpdateVoiceAsync(...)            // Update voice
client.Voices.DeleteVoiceAsync(...)            // Delete voice

// Personas
client.Personas.ListPersonasAsync(...)         // List personas
client.Personas.CreatePersonaAsync(...)        // Create persona
client.Personas.GetPersonaAsync(...)           // Get persona
client.Personas.UpdatePersonaAsync(...)        // Update persona
client.Personas.DeletePersonaAsync(...)        // Delete persona

// Sessions
client.Sessions.ListSessionsAsync(...)         // List sessions
client.Sessions.GetSessionAsync(...)           // Get session
client.Sessions.GetSessionTranscriptAsync(...) // Get transcript
client.Sessions.GetSessionRecordingAsync(...)  // Get recording URL

// LLMs
client.LLMs.ListLlmsAsync(...)                // List LLM configs
client.LLMs.CreateLlmAsync(...)               // Create LLM config
client.LLMs.UpdateLlmAsync(...)               // Update LLM config
client.LLMs.DeleteLlmAsync(...)               // Delete LLM config

// Tools (function calling)
client.Tools.ListToolsAsync(...)               // List tools
client.Tools.CreateToolAsync(...)              // Create tool
client.Tools.UpdateToolAsync(...)              // Update tool
client.Tools.DeleteToolAsync(...)              // Delete tool

// Knowledge (RAG)
client.Knowledge.ListKnowledgeGroupsAsync(...) // List knowledge groups
client.Knowledge.CreateKnowledgeGroupAsync(...) // Create group
client.Knowledge.SearchKnowledgeGroupAsync(...) // Vector search
client.Knowledge.UploadKnowledgeGroupDocumentAsync(...) // Upload document

// Share Links
client.ShareLinks.ListShareLinksAsync(...)     // List share links
client.ShareLinks.CreateShareLinkAsync(...)    // Create share link
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateSessionTokenTool()` -- Create temporary session token for client-side avatar use
- `AsListVoicesTool()` -- List available voices with search and pagination
- `AsListAvatarsTool()` -- List available avatars with search and pagination
- `AsListPersonasTool()` -- List personas combining avatar, voice, LLM, and prompt
- `AsGetSessionTranscriptTool()` -- Get conversation transcript for a session
