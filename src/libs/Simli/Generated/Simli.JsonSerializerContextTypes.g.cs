
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Simli.FaceAccess? Type0 { get; set; }
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
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.FacePatchRequest? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.FacesResponse? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponseVoiceProvider? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentResponseLlmProvider? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequestVoiceProvider? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentRequestLlmProvider? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdate? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdateVoiceProvider? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AgentUpdateLlmProvider? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoRequestAudioFormat? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CameraSetting? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ConfigurableSessionRequest? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TtsProvider? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnimationId? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CustomLLMConfig? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LLMConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SimliModels? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GoogleModels? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HTTPValidationError? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.ValidationError>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ValidationError? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnyOf<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.OpenAIModels? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LlmProvider? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.LiveKitInitializationRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionDetails? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartStreamingSessionRequest? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TokenRequest? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.AnyOf<string, int?>>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AnyOf<string, int?>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HistoryRecord? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HistoryRecordSimliModel? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.ModelUse>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ModelUse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetrics? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.HistoryRecordMeteredUsage? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.MeterUsage? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.EstimatedCost? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ModelUseRole? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.EstimatedCostByServiceUSD? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.MeterUsageListPricesPerMillion? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsStartup? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsSpeech? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsTurns? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsReplies? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsUsage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsUsageLlm? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsUsageTts? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SessionMetricsUsageStt? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.Error? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyEnqueueGSAGenerationFacesGsCreatePost? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyPreprocessImageFacesTrinityPreprocessPost? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AssetKind? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.Asset? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ListedAsset? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.ListedAssetVariant2? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.BodyUploadAssetAssetsKindPost? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGenerationState? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGeneration? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityGenerationStatus? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.TrinityGeneration>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.TrinityVersion? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SignStaticUrlStaticAudioSignPostRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.GetIceServersComposeIceGetResponseItem>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetIceServersComposeIceGetResponseItem? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartAudioToVideoSessionComposeTokenPostResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartAudioToVideoSessionComposeTokenPostResponse2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.StartAudioToVideoSessionComposeTokenPostResponse3? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.SignStaticUrlStaticAudioSignPostResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.AudioToVideoInterfaceStaticAudioPostResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.EnqueueGSAGenerationFacesGsCreatePostResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.FacesResponse>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.ListedAsset>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.InitIntegrationsLivekitAgentsPostResponse? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetHistorySessionsResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.HistoryRecord>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.GetRatelimiterSessionsResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Simli.AgentResponse>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CreatePipecatSessionTokenAutoTokenPostResponse? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CreatePipecatSessionTokenAutoTokenPostResponseModel? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Simli.CreatePipecatSessionTokenAutoTokenPostResponse2? Type98 { get; set; }

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
        public global::System.Collections.Generic.List<global::Simli.ModelUse>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.TrinityGeneration>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.GetIceServersComposeIceGetResponseItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.FacesResponse>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.ListedAsset>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.HistoryRecord>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Simli.AgentResponse>? ListType9 { get; set; }
    }
}