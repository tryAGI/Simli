
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        public global::System.Guid? FaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AgentUpdateVoiceProviderJsonConverter))]
        public global::Simli.AgentUpdateVoiceProvider? VoiceProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public global::System.Guid? VoiceId { get; set; }

        /// <summary>
        /// Example: sonic-english
        /// </summary>
        /// <example>sonic-english</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_model")]
        public string? VoiceModel { get; set; }

        /// <summary>
        /// Example: gpt-4o-mini
        /// </summary>
        /// <example>gpt-4o-mini</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// The URL of the custom LLM to use<br/>
        /// Example: https://api.example.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.example.com/v1/chat/completions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_endpoint")]
        public string? LlmEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public global::System.Guid? Emotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_idle_time")]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_session_length")]
        public int? MaxSessionLength { get; set; }

        /// <summary>
        /// The provider of the LLM used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AgentUpdateLlmProviderJsonConverter))]
        public global::Simli.AgentUpdateLlmProvider? LlmProvider { get; set; }

        /// <summary>
        /// Timestamp when the agent was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the agent was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdate" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="name"></param>
        /// <param name="firstMessage"></param>
        /// <param name="prompt"></param>
        /// <param name="voiceProvider"></param>
        /// <param name="voiceId"></param>
        /// <param name="voiceModel">
        /// Example: sonic-english
        /// </param>
        /// <param name="llmModel">
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="llmEndpoint">
        /// The URL of the custom LLM to use<br/>
        /// Example: https://api.example.com/v1/chat/completions
        /// </param>
        /// <param name="language"></param>
        /// <param name="emotion"></param>
        /// <param name="maxIdleTime"></param>
        /// <param name="maxSessionLength"></param>
        /// <param name="llmProvider">
        /// The provider of the LLM used by the agent
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the agent was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the agent was updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdate(
            global::System.Guid? faceId,
            string? name,
            string? firstMessage,
            string? prompt,
            global::Simli.AgentUpdateVoiceProvider? voiceProvider,
            global::System.Guid? voiceId,
            string? voiceModel,
            string? llmModel,
            string? llmEndpoint,
            string? language,
            global::System.Guid? emotion,
            int? maxIdleTime,
            int? maxSessionLength,
            global::Simli.AgentUpdateLlmProvider? llmProvider,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.FaceId = faceId;
            this.Name = name;
            this.FirstMessage = firstMessage;
            this.Prompt = prompt;
            this.VoiceProvider = voiceProvider;
            this.VoiceId = voiceId;
            this.VoiceModel = voiceModel;
            this.LlmModel = llmModel;
            this.LlmEndpoint = llmEndpoint;
            this.Language = language;
            this.Emotion = emotion;
            this.MaxIdleTime = maxIdleTime;
            this.MaxSessionLength = maxSessionLength;
            this.LlmProvider = llmProvider;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdate" /> class.
        /// </summary>
        public AgentUpdate()
        {
        }

    }
}