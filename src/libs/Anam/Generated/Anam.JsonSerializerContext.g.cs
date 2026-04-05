
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Anam.JsonConverters.CartesiaSonic3VoiceGenerationOptionsEmotionJsonConverter),

            typeof(global::Anam.JsonConverters.CartesiaSonic3VoiceGenerationOptionsEmotionNullableJsonConverter),

            typeof(global::Anam.JsonConverters.VoiceGenderJsonConverter),

            typeof(global::Anam.JsonConverters.VoiceGenderNullableJsonConverter),

            typeof(global::Anam.JsonConverters.ToolTypeJsonConverter),

            typeof(global::Anam.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::Anam.JsonConverters.TranscriptMessageRoleJsonConverter),

            typeof(global::Anam.JsonConverters.TranscriptMessageRoleNullableJsonConverter),

            typeof(global::Anam.JsonConverters.PersonaConfigAvatarModelJsonConverter),

            typeof(global::Anam.JsonConverters.PersonaConfigAvatarModelNullableJsonConverter),

            typeof(global::Anam.JsonConverters.CreateSessionTokenRequestPersonaConfigAvatarModelJsonConverter),

            typeof(global::Anam.JsonConverters.CreateSessionTokenRequestPersonaConfigAvatarModelNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateVoiceRequestGenderJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateVoiceRequestGenderNullableJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestLlmFormatJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestLlmFormatNullableJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningEffortJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningEffortNullableJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningFormatJsonConverter),

            typeof(global::Anam.JsonConverters.CreateLlmRequestReasoningFormatNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestLlmFormatJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestLlmFormatNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningEffortJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningEffortNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningFormatJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateLlmRequestReasoningFormatNullableJsonConverter),

            typeof(global::Anam.JsonConverters.CreateToolRequestTypeJsonConverter),

            typeof(global::Anam.JsonConverters.CreateToolRequestTypeNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateToolRequestTypeJsonConverter),

            typeof(global::Anam.JsonConverters.UpdateToolRequestTypeNullableJsonConverter),

            typeof(global::Anam.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.VoiceDetectionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ElevenLabsV1VoiceGenerationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ElevenLabsV2VoiceGenerationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CartesiaSonic3VoiceGenerationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CartesiaSonic3VoiceGenerationOptionsEmotion), TypeInfoPropertyName = "CartesiaSonic3VoiceGenerationOptionsEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.VoiceGender), TypeInfoPropertyName = "VoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.Avatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.TranscriptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.TranscriptMessageRole), TypeInfoPropertyName = "TranscriptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.SessionTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.TranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.PersonaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.PersonaConfigAvatarModel), TypeInfoPropertyName = "PersonaConfigAvatarModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenRequestPersonaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenRequestPersonaConfigAvatarModel), TypeInfoPropertyName = "CreateSessionTokenRequestPersonaConfigAvatarModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenRequestSessionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenRequestSessionOptionsSessionReplay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateVoiceRequestGender), TypeInfoPropertyName = "UpdateVoiceRequestGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateAvatarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestLlmFormat), TypeInfoPropertyName = "CreateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningEffort), TypeInfoPropertyName = "CreateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningFormat), TypeInfoPropertyName = "CreateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestLlmFormat), TypeInfoPropertyName = "UpdateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningEffort), TypeInfoPropertyName = "UpdateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningFormat), TypeInfoPropertyName = "UpdateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateToolRequestType), TypeInfoPropertyName = "CreateToolRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateToolRequestType), TypeInfoPropertyName = "UpdateToolRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateShareLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateShareLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateKnowledgeGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateKnowledgeGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.SearchKnowledgeGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UploadKnowledgeGroupDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateKnowledgeDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateSessionTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListAvatarsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.Avatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListPersonasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.PersonaConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListLlmsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.ListLlmsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListLlmsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.GetSessionRecordingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.GetKnowledgeDocumentDownloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.TranscriptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.CreateLlmRequestUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.Avatar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.PersonaConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.ListLlmsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.Tool>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}