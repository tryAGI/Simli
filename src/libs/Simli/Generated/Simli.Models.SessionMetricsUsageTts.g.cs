
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionMetricsUsageTts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public int? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageTts" /> class.
        /// </summary>
        /// <param name="characters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsUsageTts(
            int? characters)
        {
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsageTts" /> class.
        /// </summary>
        public SessionMetricsUsageTts()
        {
        }

    }
}