
#nullable enable

namespace Simli
{
    /// <summary>
    /// What a billed session came to, approximately, in US dollars: Simli's seconds as billed at the account's plan rate, and what its LLM and TTS meters charged. It's the same whether credits or the invoice paid for it; the invoice rounds its totals, not each session's. Absent on sessions that weren't billed and on records from before it was kept.
    /// </summary>
    public sealed partial class EstimatedCost
    {
        /// <summary>
        /// Example: 0.0453
        /// </summary>
        /// <example>0.0453</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUSD")]
        public double? TotalUSD { get; set; }

        /// <summary>
        /// By service, as in meteredUsage, and simli
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byServiceUSD")]
        public global::Simli.EstimatedCostByServiceUSD? ByServiceUSD { get; set; }

        /// <summary>
        /// Simli's seconds as billed (a Trinity session on a paid plan bills a fifth of its seconds, a minute's fifth at least)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliBilledSeconds")]
        public int? SimliBilledSeconds { get; set; }

        /// <summary>
        /// The plan's rate for Simli's seconds, dollars a minute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliPricePerMinute")]
        public double? SimliPricePerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedCost" /> class.
        /// </summary>
        /// <param name="totalUSD">
        /// Example: 0.0453
        /// </param>
        /// <param name="byServiceUSD">
        /// By service, as in meteredUsage, and simli
        /// </param>
        /// <param name="simliBilledSeconds">
        /// Simli's seconds as billed (a Trinity session on a paid plan bills a fifth of its seconds, a minute's fifth at least)
        /// </param>
        /// <param name="simliPricePerMinute">
        /// The plan's rate for Simli's seconds, dollars a minute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatedCost(
            double? totalUSD,
            global::Simli.EstimatedCostByServiceUSD? byServiceUSD,
            int? simliBilledSeconds,
            double? simliPricePerMinute)
        {
            this.TotalUSD = totalUSD;
            this.ByServiceUSD = byServiceUSD;
            this.SimliBilledSeconds = simliBilledSeconds;
            this.SimliPricePerMinute = simliPricePerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatedCost" /> class.
        /// </summary>
        public EstimatedCost()
        {
        }

    }
}