
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryRecord
    {
        /// <summary>
        /// Firebase unique identifier for the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Firebase user id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// (optional) Aggregation identifier provided in request by customer for grouping their end-users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endUserAggregator")]
        public string? EndUserAggregator { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecord" /> class.
        /// </summary>
        /// <param name="id">
        /// Firebase unique identifier for the session
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
        /// <param name="userId">
        /// Firebase user id
        /// </param>
        /// <param name="endUserAggregator">
        /// (optional) Aggregation identifier provided in request by customer for grouping their end-users
        /// </param>
        /// <param name="apiKeyName">
        /// (optional) Name of the API key used for this session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryRecord(
            global::System.Guid id,
            double sessionTotalTime,
            global::System.DateTimeOffset startTime,
            global::System.DateTimeOffset endTime,
            string? userId,
            string? endUserAggregator,
            string? apiKeyName)
        {
            this.Id = id;
            this.UserId = userId;
            this.EndUserAggregator = endUserAggregator;
            this.ApiKeyName = apiKeyName;
            this.SessionTotalTime = sessionTotalTime;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryRecord" /> class.
        /// </summary>
        public HistoryRecord()
        {
        }

    }
}