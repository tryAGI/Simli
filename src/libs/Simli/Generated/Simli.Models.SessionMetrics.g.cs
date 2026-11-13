
#nullable enable

namespace Simli
{
    /// <summary>
    /// (Simli Auto) What the session did. A field is present only where the session's services report it.
    /// </summary>
    public sealed partial class SessionMetrics
    {
        /// <summary>
        /// Milliseconds from the session's start on Simli's server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup")]
        public global::Simli.SessionMetricsStartup? Startup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech")]
        public global::Simli.SessionMetricsSpeech? Speech { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        public global::Simli.SessionMetricsTurns? Turns { get; set; }

        /// <summary>
        /// From the end of the user's speech to the avatar's voice, per reply (typed turns' replies aren't counted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replies")]
        public global::Simli.SessionMetricsReplies? Replies { get; set; }

        /// <summary>
        /// Mean time to first byte of each kind of service (stt, llm, tts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttfbMs")]
        public global::System.Collections.Generic.Dictionary<string, long>? TtfbMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Simli.SessionMetricsUsage? Usage { get; set; }

        /// <summary>
        /// Function calls the model made (knowledge base searches among them)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public int? ToolCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public int? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        /// <param name="startup">
        /// Milliseconds from the session's start on Simli's server
        /// </param>
        /// <param name="speech"></param>
        /// <param name="turns"></param>
        /// <param name="replies">
        /// From the end of the user's speech to the avatar's voice, per reply (typed turns' replies aren't counted)
        /// </param>
        /// <param name="ttfbMs">
        /// Mean time to first byte of each kind of service (stt, llm, tts)
        /// </param>
        /// <param name="usage"></param>
        /// <param name="toolCalls">
        /// Function calls the model made (knowledge base searches among them)
        /// </param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetrics(
            global::Simli.SessionMetricsStartup? startup,
            global::Simli.SessionMetricsSpeech? speech,
            global::Simli.SessionMetricsTurns? turns,
            global::Simli.SessionMetricsReplies? replies,
            global::System.Collections.Generic.Dictionary<string, long>? ttfbMs,
            global::Simli.SessionMetricsUsage? usage,
            int? toolCalls,
            int? errors)
        {
            this.Startup = startup;
            this.Speech = speech;
            this.Turns = turns;
            this.Replies = replies;
            this.TtfbMs = ttfbMs;
            this.Usage = usage;
            this.ToolCalls = toolCalls;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetrics" /> class.
        /// </summary>
        public SessionMetrics()
        {
        }

    }
}