
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLLMConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmAPIKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LlmAPIKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLMConfig" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="baseURL"></param>
        /// <param name="llmAPIKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomLLMConfig(
            string model,
            string baseURL,
            string llmAPIKey)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.BaseURL = baseURL ?? throw new global::System.ArgumentNullException(nameof(baseURL));
            this.LlmAPIKey = llmAPIKey ?? throw new global::System.ArgumentNullException(nameof(llmAPIKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLMConfig" /> class.
        /// </summary>
        public CustomLLMConfig()
        {
        }
    }
}