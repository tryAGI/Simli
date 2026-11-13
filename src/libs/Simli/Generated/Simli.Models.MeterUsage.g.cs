
#nullable enable

namespace Simli
{
    /// <summary>
    /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
    /// </summary>
    public sealed partial class MeterUsage
    {
        /// <summary>
        /// Example: gpt_6_luna_tokens
        /// </summary>
        /// <example>gpt_6_luna_tokens</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meter")]
        public string? Meter { get; set; }

        /// <summary>
        /// What the meter was given
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Billed by the seconds the session was connected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedSeconds")]
        public int? ConnectedSeconds { get; set; }

        /// <summary>
        /// (TTS) Seconds the avatar spoke
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingSeconds")]
        public double? SpeakingSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncachedInputTokens")]
        public int? UncachedInputTokens { get; set; }

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
        /// Output tokens, thinking included
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// (Speech to speech) Audio tokens, priced apart from the text ones above
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncachedInputAudioTokens")]
        public int? UncachedInputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInputAudioTokens")]
        public int? CachedInputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputAudioTokens")]
        public int? OutputAudioTokens { get; set; }

        /// <summary>
        /// (GPT-Realtime) Seconds of the user's speech transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribedSeconds")]
        public double? TranscribedSeconds { get; set; }

        /// <summary>
        /// The transcription's list price, dollars per minute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptionPricePerMinute")]
        public double? TranscriptionPricePerMinute { get; set; }

        /// <summary>
        /// The model's list prices used, dollars per 1M tokens (its text's, where it prices audio apart)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listPricesPerMillion")]
        public global::Simli.MeterUsageListPricesPerMillion? ListPricesPerMillion { get; set; }

        /// <summary>
        /// The meter's price, dollars per 1M of its units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meterPricePerMillion")]
        public double? MeterPricePerMillion { get; set; }

        /// <summary>
        /// What the tokens cost at those list prices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costUSD")]
        public double? CostUSD { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterUsage" /> class.
        /// </summary>
        /// <param name="meter">
        /// Example: gpt_6_luna_tokens
        /// </param>
        /// <param name="value">
        /// What the meter was given
        /// </param>
        /// <param name="connectedSeconds">
        /// Billed by the seconds the session was connected
        /// </param>
        /// <param name="speakingSeconds">
        /// (TTS) Seconds the avatar spoke
        /// </param>
        /// <param name="uncachedInputTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="cacheWriteInputTokens"></param>
        /// <param name="outputTokens">
        /// Output tokens, thinking included
        /// </param>
        /// <param name="uncachedInputAudioTokens">
        /// (Speech to speech) Audio tokens, priced apart from the text ones above
        /// </param>
        /// <param name="cachedInputAudioTokens"></param>
        /// <param name="outputAudioTokens"></param>
        /// <param name="transcribedSeconds">
        /// (GPT-Realtime) Seconds of the user's speech transcribed
        /// </param>
        /// <param name="transcriptionPricePerMinute">
        /// The transcription's list price, dollars per minute
        /// </param>
        /// <param name="listPricesPerMillion">
        /// The model's list prices used, dollars per 1M tokens (its text's, where it prices audio apart)
        /// </param>
        /// <param name="meterPricePerMillion">
        /// The meter's price, dollars per 1M of its units
        /// </param>
        /// <param name="costUSD">
        /// What the tokens cost at those list prices
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeterUsage(
            string? meter,
            int? value,
            int? connectedSeconds,
            double? speakingSeconds,
            int? uncachedInputTokens,
            int? cachedInputTokens,
            int? cacheWriteInputTokens,
            int? outputTokens,
            int? uncachedInputAudioTokens,
            int? cachedInputAudioTokens,
            int? outputAudioTokens,
            double? transcribedSeconds,
            double? transcriptionPricePerMinute,
            global::Simli.MeterUsageListPricesPerMillion? listPricesPerMillion,
            double? meterPricePerMillion,
            double? costUSD)
        {
            this.Meter = meter;
            this.Value = value;
            this.ConnectedSeconds = connectedSeconds;
            this.SpeakingSeconds = speakingSeconds;
            this.UncachedInputTokens = uncachedInputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.CacheWriteInputTokens = cacheWriteInputTokens;
            this.OutputTokens = outputTokens;
            this.UncachedInputAudioTokens = uncachedInputAudioTokens;
            this.CachedInputAudioTokens = cachedInputAudioTokens;
            this.OutputAudioTokens = outputAudioTokens;
            this.TranscribedSeconds = transcribedSeconds;
            this.TranscriptionPricePerMinute = transcriptionPricePerMinute;
            this.ListPricesPerMillion = listPricesPerMillion;
            this.MeterPricePerMillion = meterPricePerMillion;
            this.CostUSD = costUSD;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterUsage" /> class.
        /// </summary>
        public MeterUsage()
        {
        }

    }
}