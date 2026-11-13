
#nullable enable

namespace Simli
{
    /// <summary>
    /// What the session's meters were billed, by service: the LLM and TTS when Simli's keys ran them (llmDelegate is the text model GPT-Live hands its reasoning to), and Simli Auto's agent fee on every Auto session's seconds (a minute at least)
    /// </summary>
    public sealed partial class HistoryRecordMeteredUsage
    {
        /// <summary>
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::Simli.MeterUsage? Llm { get; set; }

        /// <summary>
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmDelegate")]
        public global::Simli.MeterUsage? LlmDelegate { get; set; }

        /// <summary>
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Simli.MeterUsage? Tts { get; set; }

        /// <summary>
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Simli.MeterUsage? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecordMeteredUsage" /> class.
        /// </summary>
        /// <param name="llm">
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </param>
        /// <param name="llmDelegate">
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </param>
        /// <param name="tts">
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </param>
        /// <param name="agent">
        /// What one service's usage meter got. A token meter's value is in its own units: the tokens weighted by their list prices over the meter's price, so the meter bills what they cost (in whole units).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryRecordMeteredUsage(
            global::Simli.MeterUsage? llm,
            global::Simli.MeterUsage? llmDelegate,
            global::Simli.MeterUsage? tts,
            global::Simli.MeterUsage? agent)
        {
            this.Llm = llm;
            this.LlmDelegate = llmDelegate;
            this.Tts = tts;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecordMeteredUsage" /> class.
        /// </summary>
        public HistoryRecordMeteredUsage()
        {
        }

    }
}