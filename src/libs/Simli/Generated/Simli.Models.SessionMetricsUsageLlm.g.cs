
#nullable enable

namespace Simli
{
    /// <summary>
    /// Tokens the LLM or speech-to-speech model reported
    /// </summary>
    public sealed partial class SessionMetricsUsageLlm
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInputTokens")]
        public int? CachedInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWriteInputTokens")]
        public int? CacheWriteInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputAudioTokens")]
        public int? InputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputAudioTokens")]
        public int? OutputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInputAudioTokens")]
        public int? CachedInputAudioTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageLlm" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="cacheWriteInputTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="inputAudioTokens"></param>
        /// <param name="outputAudioTokens"></param>
        /// <param name="cachedInputAudioTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsUsageLlm(
            int? inputTokens,
            int? outputTokens,
            int? totalTokens,
            int? cachedInputTokens,
            int? cacheWriteInputTokens,
            int? reasoningTokens,
            int? inputAudioTokens,
            int? outputAudioTokens,
            int? cachedInputAudioTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.CacheWriteInputTokens = cacheWriteInputTokens;
            this.ReasoningTokens = reasoningTokens;
            this.InputAudioTokens = inputAudioTokens;
            this.OutputAudioTokens = outputAudioTokens;
            this.CachedInputAudioTokens = cachedInputAudioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageLlm" /> class.
        /// </summary>
        public SessionMetricsUsageLlm()
        {
        }

    }
}