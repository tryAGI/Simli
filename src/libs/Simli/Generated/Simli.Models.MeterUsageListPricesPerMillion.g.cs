
#nullable enable

namespace Simli
{
    /// <summary>
    /// The model's list prices used, dollars per 1M tokens (its text's, where it prices audio apart)
    /// </summary>
    public sealed partial class MeterUsageListPricesPerMillion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public double? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInput")]
        public double? CachedInput { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWrite")]
        public double? CacheWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public double? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioInput")]
        public double? AudioInput { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedAudioInput")]
        public double? CachedAudioInput { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioOutput")]
        public double? AudioOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterUsageListPricesPerMillion" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cachedInput"></param>
        /// <param name="cacheWrite"></param>
        /// <param name="output"></param>
        /// <param name="audioInput"></param>
        /// <param name="cachedAudioInput"></param>
        /// <param name="audioOutput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeterUsageListPricesPerMillion(
            double? input,
            double? cachedInput,
            double? cacheWrite,
            double? output,
            double? audioInput,
            double? cachedAudioInput,
            double? audioOutput)
        {
            this.Input = input;
            this.CachedInput = cachedInput;
            this.CacheWrite = cacheWrite;
            this.Output = output;
            this.AudioInput = audioInput;
            this.CachedAudioInput = cachedAudioInput;
            this.AudioOutput = audioOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeterUsageListPricesPerMillion" /> class.
        /// </summary>
        public MeterUsageListPricesPerMillion()
        {
        }

    }
}