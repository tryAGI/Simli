
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HistoryRecord
    {
        /// <summary>
        /// Unique identifier for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// face_id used in session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        public string? FaceId { get; set; }

        /// <summary>
        /// Interaction Method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The avatar model that served the session; absent on records that don't say
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.HistoryRecordSimliModelJsonConverter))]
        public global::Simli.HistoryRecordSimliModel? SimliModel { get; set; }

        /// <summary>
        /// Aggregation identifier provided in request by customer for grouping their end-users; the API key's name (apiKeyName) when the request gave none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionAggregator")]
        public string? SessionAggregator { get; set; }

        /// <summary>
        /// (optional) Name of the API key used for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyName")]
        public string? ApiKeyName { get; set; }

        /// <summary>
        /// Total session duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionTotalTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SessionTotalTime { get; set; }

        /// <summary>
        /// Session start time as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Session end time as Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// (Simli Auto) Why the session ended, e.g. PARTICIPANT_LEFT, CLIENT_STOPPED, NOBODY_JOINED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endReason")]
        public string? EndReason { get; set; }

        /// <summary>
        /// (Simli Auto) Every model the session ran
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Simli.ModelUse>? Models { get; set; }

        /// <summary>
        /// (Simli Auto) What the session did. A field is present only where the session's services report it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Simli.SessionMetrics? Metrics { get; set; }

        /// <summary>
        /// What the session's meters were billed, by service: the LLM and TTS when Simli's keys ran them (llmDelegate is the text model GPT-Live hands its reasoning to), and Simli Auto's agent fee on every Auto session's seconds (a minute at least)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meteredUsage")]
        public global::Simli.HistoryRecordMeteredUsage? MeteredUsage { get; set; }

        /// <summary>
        /// What a billed session came to, approximately, in US dollars: Simli's seconds as billed at the account's plan rate, and what its LLM and TTS meters charged. It's the same whether credits or the invoice paid for it; the invoice rounds its totals, not each session's. Absent on sessions that weren't billed and on records from before it was kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedCost")]
        public global::Simli.EstimatedCost? EstimatedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecord" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the session
        /// </param>
        /// <param name="sessionTotalTime">
        /// Total session duration in seconds
        /// </param>
        /// <param name="startTime">
        /// Session start time as Unix timestamp
        /// </param>
        /// <param name="endTime">
        /// Session end time as Unix timestamp
        /// </param>
        /// <param name="faceId">
        /// face_id used in session
        /// </param>
        /// <param name="kind">
        /// Interaction Method
        /// </param>
        /// <param name="simliModel">
        /// The avatar model that served the session; absent on records that don't say
        /// </param>
        /// <param name="sessionAggregator">
        /// Aggregation identifier provided in request by customer for grouping their end-users; the API key's name (apiKeyName) when the request gave none
        /// </param>
        /// <param name="apiKeyName">
        /// (optional) Name of the API key used for this session
        /// </param>
        /// <param name="endReason">
        /// (Simli Auto) Why the session ended, e.g. PARTICIPANT_LEFT, CLIENT_STOPPED, NOBODY_JOINED
        /// </param>
        /// <param name="models">
        /// (Simli Auto) Every model the session ran
        /// </param>
        /// <param name="metrics">
        /// (Simli Auto) What the session did. A field is present only where the session's services report it.
        /// </param>
        /// <param name="meteredUsage">
        /// What the session's meters were billed, by service: the LLM and TTS when Simli's keys ran them (llmDelegate is the text model GPT-Live hands its reasoning to), and Simli Auto's agent fee on every Auto session's seconds (a minute at least)
        /// </param>
        /// <param name="estimatedCost">
        /// What a billed session came to, approximately, in US dollars: Simli's seconds as billed at the account's plan rate, and what its LLM and TTS meters charged. It's the same whether credits or the invoice paid for it; the invoice rounds its totals, not each session's. Absent on sessions that weren't billed and on records from before it was kept.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryRecord(
            global::System.Guid id,
            double sessionTotalTime,
            global::System.DateTimeOffset startTime,
            global::System.DateTimeOffset endTime,
            string? faceId,
            string? kind,
            global::Simli.HistoryRecordSimliModel? simliModel,
            string? sessionAggregator,
            string? apiKeyName,
            string? endReason,
            global::System.Collections.Generic.IList<global::Simli.ModelUse>? models,
            global::Simli.SessionMetrics? metrics,
            global::Simli.HistoryRecordMeteredUsage? meteredUsage,
            global::Simli.EstimatedCost? estimatedCost)
        {
            this.Id = id;
            this.FaceId = faceId;
            this.Kind = kind;
            this.SimliModel = simliModel;
            this.SessionAggregator = sessionAggregator;
            this.ApiKeyName = apiKeyName;
            this.SessionTotalTime = sessionTotalTime;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.EndReason = endReason;
            this.Models = models;
            this.Metrics = metrics;
            this.MeteredUsage = meteredUsage;
            this.EstimatedCost = estimatedCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecord" /> class.
        /// </summary>
        public HistoryRecord()
        {
        }

    }
}