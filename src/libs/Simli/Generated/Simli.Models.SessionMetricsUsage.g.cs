
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionMetricsUsage
    {
        /// <summary>
        /// Tokens the LLM or speech-to-speech model reported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::Simli.SessionMetricsUsageLlm? Llm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Simli.SessionMetricsUsageTts? Tts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::Simli.SessionMetricsUsageStt? Stt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsage" /> class.
        /// </summary>
        /// <param name="llm">
        /// Tokens the LLM or speech-to-speech model reported
        /// </param>
        /// <param name="tts"></param>
        /// <param name="stt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionMetricsUsage(
            global::Simli.SessionMetricsUsageLlm? llm,
            global::Simli.SessionMetricsUsageTts? tts,
            global::Simli.SessionMetricsUsageStt? stt)
        {
            this.Llm = llm;
            this.Tts = tts;
            this.Stt = stt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionMetricsUsage" /> class.
        /// </summary>
        public SessionMetricsUsage()
        {
        }

    }
}