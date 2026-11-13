
#nullable enable

namespace Simli
{
    /// <summary>
    /// Milliseconds from the session's start on Simli's server
    /// </summary>
    public sealed partial class SessionMetricsStartup
    {
        /// <summary>
        /// To the avatar's first frame
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstFrameMs")]
        public int? FirstFrameMs { get; set; }

        /// <summary>
        /// To the user joining
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userJoinedMs")]
        public int? UserJoinedMs { get; set; }

        /// <summary>
        /// To the avatar's first words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstWordsMs")]
        public int? FirstWordsMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsStartup" /> class.
        /// </summary>
        /// <param name="firstFrameMs">
        /// To the avatar's first frame
        /// </param>
        /// <param name="userJoinedMs">
        /// To the user joining
        /// </param>
        /// <param name="firstWordsMs">
        /// To the avatar's first words
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsStartup(
            int? firstFrameMs,
            int? userJoinedMs,
            int? firstWordsMs)
        {
            this.FirstFrameMs = firstFrameMs;
            this.UserJoinedMs = userJoinedMs;
            this.FirstWordsMs = firstWordsMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsStartup" /> class.
        /// </summary>
        public SessionMetricsStartup()
        {
        }

    }
}