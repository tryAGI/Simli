
#nullable enable

namespace Simli
{
    /// <summary>
    /// By service, as in meteredUsage, and simli
    /// </summary>
    public sealed partial class EstimatedCostByServiceUSD
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simli")]
        public double? Simli { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public double? Llm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmDelegate")]
        public double? LlmDelegate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public double? Tts { get; set; }

        /// <summary>
        /// Simli Auto's agent fee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public double? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedCostByServiceUSD" /> class.
        /// </summary>
        /// <param name="simli"></param>
        /// <param name="llm"></param>
        /// <param name="llmDelegate"></param>
        /// <param name="tts"></param>
        /// <param name="agent">
        /// Simli Auto's agent fee
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatedCostByServiceUSD(
            double? simli,
            double? llm,
            double? llmDelegate,
            double? tts,
            double? agent)
        {
            this.Simli = simli;
            this.Llm = llm;
            this.LlmDelegate = llmDelegate;
            this.Tts = tts;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedCostByServiceUSD" /> class.
        /// </summary>
        public EstimatedCostByServiceUSD()
        {
        }

    }
}