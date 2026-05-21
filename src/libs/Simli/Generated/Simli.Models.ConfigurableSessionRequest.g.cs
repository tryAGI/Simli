
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurableSessionRequest
    {
        /// <summary>
        /// Default Value: tmp9i8bbq7c
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faceId")]
        public string? FaceId { get; set; }

        /// <summary>
        /// Default Value: Cartesia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.TtsProviderJsonConverter))]
        public global::Simli.TtsProvider? TtsProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsAPIKey")]
        public string? TtsAPIKey { get; set; }

        /// <summary>
        /// Default Value: sonic-turbo-2025-03-07
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsModel")]
        public string? TtsModel { get; set; }

        /// <summary>
        /// Default Value: a167e0f3-df7e-4d52-a9c3-f949145efdab
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: You are Chatbot, a friendly, helpful robot. Your goal is to demonstrate your capabilities in a succinct way. Your output will be converted to audio so don't include special characters in your answers. Respond to what the user said in a creative and helpful way, but keep your responses brief.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessage")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSessionLength")]
        public int? MaxSessionLength { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxIdleTime")]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customLLMConfig")]
        public global::Simli.CustomLLMConfig? CustomLLMConfig { get; set; }

        /// <summary>
        /// Default Value: {"model":"gpt-4o-mini","provider":"OpenAI"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmConfig")]
        public global::Simli.LLMConfig? LlmConfig { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTranscript")]
        public bool? CreateTranscript { get; set; }

        /// <summary>
        /// Default Value: artalk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.SimliModelsJsonConverter))]
        public global::Simli.SimliModels? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableSessionRequest" /> class.
        /// </summary>
        /// <param name="faceId">
        /// Default Value: tmp9i8bbq7c
        /// </param>
        /// <param name="ttsProvider">
        /// Default Value: Cartesia
        /// </param>
        /// <param name="ttsAPIKey"></param>
        /// <param name="ttsModel">
        /// Default Value: sonic-turbo-2025-03-07
        /// </param>
        /// <param name="voiceId">
        /// Default Value: a167e0f3-df7e-4d52-a9c3-f949145efdab
        /// </param>
        /// <param name="systemPrompt">
        /// Default Value: You are Chatbot, a friendly, helpful robot. Your goal is to demonstrate your capabilities in a succinct way. Your output will be converted to audio so don't include special characters in your answers. Respond to what the user said in a creative and helpful way, but keep your responses brief.
        /// </param>
        /// <param name="firstMessage"></param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="customLLMConfig"></param>
        /// <param name="llmConfig">
        /// Default Value: {"model":"gpt-4o-mini","provider":"OpenAI"}
        /// </param>
        /// <param name="createTranscript">
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// Default Value: artalk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurableSessionRequest(
            string? faceId,
            global::Simli.TtsProvider? ttsProvider,
            string? ttsAPIKey,
            string? ttsModel,
            string? voiceId,
            string? systemPrompt,
            string? firstMessage,
            int? maxSessionLength,
            int? maxIdleTime,
            string? language,
            global::Simli.CustomLLMConfig? customLLMConfig,
            global::Simli.LLMConfig? llmConfig,
            bool? createTranscript,
            global::Simli.SimliModels? model)
        {
            this.FaceId = faceId;
            this.TtsProvider = ttsProvider;
            this.TtsAPIKey = ttsAPIKey;
            this.TtsModel = ttsModel;
            this.VoiceId = voiceId;
            this.SystemPrompt = systemPrompt;
            this.FirstMessage = firstMessage;
            this.MaxSessionLength = maxSessionLength;
            this.MaxIdleTime = maxIdleTime;
            this.Language = language;
            this.CustomLLMConfig = customLLMConfig;
            this.LlmConfig = llmConfig;
            this.CreateTranscript = createTranscript;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableSessionRequest" /> class.
        /// </summary>
        public ConfigurableSessionRequest()
        {
        }

    }
}