
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionMetricsUsageStt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSeconds")]
        public double? AudioSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageStt" /> class.
        /// </summary>
        /// <param name="audioSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsUsageStt(
            double? audioSeconds)
        {
            this.AudioSeconds = audioSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageStt" /> class.
        /// </summary>
        public SessionMetricsUsageStt()
        {
        }

    }
}