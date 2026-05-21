
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMConfig
    {
        /// <summary>
        /// Default Value: gpt-4o-mini
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AnyOfJsonConverter<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>))]
        public global::Simli.AnyOf<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>? Model { get; set; }

        /// <summary>
        /// Default Value: OpenAI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.LlmProviderJsonConverter))]
        public global::Simli.LlmProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseURL")]
        public string? BaseURL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: gpt-4o-mini
        /// </param>
        /// <param name="provider">
        /// Default Value: OpenAI
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="baseURL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMConfig(
            global::Simli.AnyOf<global::Simli.OpenAIModels?, global::Simli.GoogleModels?, string>? model,
            global::Simli.LlmProvider? provider,
            string? apiKey,
            string? baseURL)
        {
            this.Model = model;
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.BaseURL = baseURL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfig" /> class.
        /// </summary>
        public LLMConfig()
        {
        }

    }
}