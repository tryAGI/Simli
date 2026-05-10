
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartStreamingSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiVersion")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionAggregator")]
        public string? SessionAggregator { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handleSilence")]
        public bool? HandleSilence { get; set; }

        /// <summary>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSessionLength")]
        public int? MaxSessionLength { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxIdleTime")]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startFrame")]
        public int? StartFrame { get; set; }

        /// <summary>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioInputFormat")]
        public string? AudioInputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartStreamingSessionRequest" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="apiVersion"></param>
        /// <param name="sessionAggregator"></param>
        /// <param name="handleSilence">
        /// Default Value: true
        /// </param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="startFrame">
        /// Default Value: 0
        /// </param>
        /// <param name="audioInputFormat">
        /// Default Value: pcm16
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartStreamingSessionRequest(
            string faceId,
            string? apiVersion,
            string? sessionAggregator,
            bool? handleSilence,
            int? maxSessionLength,
            int? maxIdleTime,
            int? startFrame,
            string? audioInputFormat)
        {
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.ApiVersion = apiVersion;
            this.SessionAggregator = sessionAggregator;
            this.HandleSilence = handleSilence;
            this.MaxSessionLength = maxSessionLength;
            this.MaxIdleTime = maxIdleTime;
            this.StartFrame = startFrame;
            this.AudioInputFormat = audioInputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartStreamingSessionRequest" /> class.
        /// </summary>
        public StartStreamingSessionRequest()
        {
        }

    }
}