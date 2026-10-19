
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Simli.FacesRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.FacesResponse? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponse? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponseVoiceProvider? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponseLlmProvider? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequestVoiceProvider? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequestLlmProvider? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdate? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdateVoiceProvider? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdateLlmProvider? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoRequestAudioFormat? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CameraSetting? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ConfigurableSessionRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TtsProvider? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnimationId? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CustomLLMConfig? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LLMConfig? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SimliModels? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GoogleModels? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HTTPValidationError? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.ValidationError>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ValidationError? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnyOf<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.OpenAIModels? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LlmProvider? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LiveKitInitializationRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionDetails? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartStreamingSessionRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TokenRequest? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.AnyOf<string, int?>>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnyOf<string, int?>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HistoryRecord? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.Error? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyGenerateFaceIDAPIFacesLegacyCreatePost? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CharacterVersion? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyEnqueueGSAGenerationFacesGsCreatePost? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyPreprocessImageFacesTrinityPreprocessPost? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGenerationState? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGeneration? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGenerationStatus? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.TrinityGeneration>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityVersion? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.GetIceServersComposeIceGetResponseItem>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetIceServersComposeIceGetResponseItem? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartAudioToVideoSessionComposeTokenPostResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoInterfaceStaticAudioPostResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.FacesResponse>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.InitIntegrationsLivekitAgentsPostResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetHistorySessionsResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.HistoryRecord>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetRatelimiterSessionsResponse? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.AgentResponse>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CreatePipecatSessionTokenAutoTokenPostResponse? Type67 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.ValidationError>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.AnyOf<string, int?>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.TrinityGeneration>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.GetIceServersComposeIceGetResponseItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.FacesResponse>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.HistoryRecord>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.AgentResponse>? ListType7 { get; set; }
    }
}