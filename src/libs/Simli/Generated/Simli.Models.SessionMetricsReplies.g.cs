
#nullable enable

namespace Simli
{
    /// <summary>
    /// From the end of the user's speech to the avatar's voice, per reply (typed turns' replies aren't counted)
    /// </summary>
    public sealed partial class SessionMetricsReplies
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meanMs")]
        public int? MeanMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50Ms")]
        public int? P50Ms { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90Ms")]
        public int? P90Ms { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMs")]
        public int? MaxMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsReplies" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="meanMs"></param>
        /// <param name="p50Ms"></param>
        /// <param name="p90Ms"></param>
        /// <param name="maxMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsReplies(
            int? count,
            int? meanMs,
            int? p50Ms,
            int? p90Ms,
            int? maxMs)
        {
            this.Count = count;
            this.MeanMs = meanMs;
            this.P50Ms = p50Ms;
            this.P90Ms = p90Ms;
            this.MaxMs = maxMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsReplies" /> class.
        /// </summary>
        public SessionMetricsReplies()
        {
        }

    }
}