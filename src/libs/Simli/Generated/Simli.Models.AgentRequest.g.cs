
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FaceId { get; set; }

        /// <summary>
        /// Default Value: Untitled Agent
        /// </summary>
        /// <default>"Untitled Agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; } = "Untitled Agent";

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AgentRequestVoiceProviderJsonConverter))]
        public global::Simli.AgentRequestVoiceProvider? VoiceProvider { get; set; }

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
        /// Unique identifier for the owner of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

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
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_idle_time")]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_session_length")]
        public int? MaxSessionLength { get; set; }

        /// <summary>
        /// The provider of the LLM used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AgentRequestLlmProviderJsonConverter))]
        public global::Simli.AgentRequestLlmProvider? LlmProvider { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="name">
        /// Default Value: Untitled Agent
        /// </param>
        /// <param name="firstMessage"></param>
        /// <param name="prompt"></param>
        /// <param name="voiceProvider"></param>
        /// <param name="voiceId"></param>
        /// <param name="voiceModel">
        /// Example: sonic-english
        /// </param>
        /// <param name="ownerId">
        /// Unique identifier for the owner of the agent
        /// </param>
        /// <param name="language"></param>
        /// <param name="emotion"></param>
        /// <param name="llmModel">
        /// Example: gpt-4o-mini
        /// </param>
        /// <param name="llmEndpoint">
        /// The URL of the custom LLM to use<br/>
        /// Example: https://api.example.com/v1/chat/completions
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
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
        public AgentRequest(
            global::System.Guid faceId,
            string name,
            string? firstMessage,
            string? prompt,
            global::Simli.AgentRequestVoiceProvider? voiceProvider,
            global::System.Guid? voiceId,
            string? voiceModel,
            string? ownerId,
            string? language,
            global::System.Guid? emotion,
            string? llmModel,
            string? llmEndpoint,
            int? maxIdleTime,
            int? maxSessionLength,
            global::Simli.AgentRequestLlmProvider? llmProvider,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.FaceId = faceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FirstMessage = firstMessage;
            this.Prompt = prompt;
            this.VoiceProvider = voiceProvider;
            this.VoiceId = voiceId;
            this.VoiceModel = voiceModel;
            this.OwnerId = ownerId;
            this.Language = language;
            this.Emotion = emotion;
            this.LlmModel = llmModel;
            this.LlmEndpoint = llmEndpoint;
            this.MaxIdleTime = maxIdleTime;
            this.MaxSessionLength = maxSessionLength;
            this.LlmProvider = llmProvider;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        public AgentRequest()
        {
        }
    }
}