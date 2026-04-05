
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Simli.JsonConverters.AgentResponseVoiceProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentResponseVoiceProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AgentResponseLlmProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentResponseLlmProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AgentRequestVoiceProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentRequestVoiceProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AgentRequestLlmProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentRequestLlmProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AgentUpdateVoiceProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentUpdateVoiceProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AgentUpdateLlmProviderJsonConverter),

            typeof(global::Simli.JsonConverters.AgentUpdateLlmProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AudioToVideoRequestAudioFormatJsonConverter),

            typeof(global::Simli.JsonConverters.AudioToVideoRequestAudioFormatNullableJsonConverter),

            typeof(global::Simli.JsonConverters.GoogleModelsJsonConverter),

            typeof(global::Simli.JsonConverters.GoogleModelsNullableJsonConverter),

            typeof(global::Simli.JsonConverters.LlmProviderJsonConverter),

            typeof(global::Simli.JsonConverters.LlmProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.OpenAIModelsJsonConverter),

            typeof(global::Simli.JsonConverters.OpenAIModelsNullableJsonConverter),

            typeof(global::Simli.JsonConverters.SimliModelsJsonConverter),

            typeof(global::Simli.JsonConverters.SimliModelsNullableJsonConverter),

            typeof(global::Simli.JsonConverters.TtsProviderJsonConverter),

            typeof(global::Simli.JsonConverters.TtsProviderNullableJsonConverter),

            typeof(global::Simli.JsonConverters.CharacterVersionJsonConverter),

            typeof(global::Simli.JsonConverters.CharacterVersionNullableJsonConverter),

            typeof(global::Simli.JsonConverters.TrinityVersionJsonConverter),

            typeof(global::Simli.JsonConverters.TrinityVersionNullableJsonConverter),

            typeof(global::Simli.JsonConverters.AnyOfJsonConverter<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>),

            typeof(global::Simli.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Simli.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.FacesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.FacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentResponseVoiceProvider), TypeInfoPropertyName = "AgentResponseVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentResponseLlmProvider), TypeInfoPropertyName = "AgentResponseLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentRequestVoiceProvider), TypeInfoPropertyName = "AgentRequestVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentRequestLlmProvider), TypeInfoPropertyName = "AgentRequestLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentUpdateVoiceProvider), TypeInfoPropertyName = "AgentUpdateVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AgentUpdateLlmProvider), TypeInfoPropertyName = "AgentUpdateLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AudioToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AudioToVideoRequestAudioFormat), TypeInfoPropertyName = "AudioToVideoRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.ConfigurableSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.TtsProvider), TypeInfoPropertyName = "TtsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.CustomLLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.LLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.SimliModels), TypeInfoPropertyName = "SimliModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.GoogleModels), TypeInfoPropertyName = "GoogleModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AnyOf<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>), TypeInfoPropertyName = "AnyOfOpenAIModelsGoogleModelsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.OpenAIModels), TypeInfoPropertyName = "OpenAIModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.LlmProvider), TypeInfoPropertyName = "LlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.LiveKitInitializationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.SessionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.StartStreamingSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.TokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.HistoryRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.BodyGenerateFaceIDAPIFacesLegacyCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.CharacterVersion), TypeInfoPropertyName = "CharacterVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.BodyEnqueueGSAGenerationFacesGsCreatePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.TrinityVersion), TypeInfoPropertyName = "TrinityVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.GetIceServersComposeIceGetResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.GetIceServersComposeIceGetResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.StartAudioToVideoSessionComposeTokenPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.AudioToVideoInterfaceStaticAudioPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.FacesResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.InitIntegrationsLivekitAgentsPostResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.GetHistorySessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.HistoryRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Simli.GetRatelimiterSessionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Simli.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.GetIceServersComposeIceGetResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.FacesResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.HistoryRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Simli.AgentResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}