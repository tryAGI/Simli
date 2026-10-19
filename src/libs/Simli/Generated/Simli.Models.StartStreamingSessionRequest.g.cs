
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
        /// Default Value: v2
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
        /// Width of the streamed video in pixels, Trinity-2 faces only (the others keep their own frame size). At least 512, and with streaming_height one of 1:1, 16:9 or 9:16, otherwise a 422. A canvas larger than the avatar's frame is padded with its background; a smaller one crops a window out of it.<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_width")]
        public int? StreamingWidth { get; set; }

        /// <summary>
        /// Height of the streamed video in pixels. See streaming_width.<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_height")]
        public int? StreamingHeight { get; set; }

        /// <summary>
        /// Where the avatar sits across the canvas, from 0 (left) to 1 (right). Trinity-2 only.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_position_x")]
        public double? AvatarPositionX { get; set; }

        /// <summary>
        /// Where the avatar sits down the canvas, from 0 (top) to 1 (bottom). Trinity-2 only.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_position_y")]
        public double? AvatarPositionY { get; set; }

        /// <summary>
        /// The camera the session starts with, on top of the avatar's own framing. Trinity-2 only. Leave it out to keep the avatar's framing. A streaming session can move it afterwards with CAM_ messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera")]
        public global::Simli.CameraSetting? Camera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartStreamingSessionRequest" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="apiVersion">
        /// Default Value: v2
        /// </param>
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
        /// <param name="streamingWidth">
        /// Width of the streamed video in pixels, Trinity-2 faces only (the others keep their own frame size). At least 512, and with streaming_height one of 1:1, 16:9 or 9:16, otherwise a 422. A canvas larger than the avatar's frame is padded with its background; a smaller one crops a window out of it.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="streamingHeight">
        /// Height of the streamed video in pixels. See streaming_width.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="avatarPositionX">
        /// Where the avatar sits across the canvas, from 0 (left) to 1 (right). Trinity-2 only.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="avatarPositionY">
        /// Where the avatar sits down the canvas, from 0 (top) to 1 (bottom). Trinity-2 only.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="camera">
        /// The camera the session starts with, on top of the avatar's own framing. Trinity-2 only. Leave it out to keep the avatar's framing. A streaming session can move it afterwards with CAM_ messages.
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
            string? audioInputFormat,
            int? streamingWidth,
            int? streamingHeight,
            double? avatarPositionX,
            double? avatarPositionY,
            global::Simli.CameraSetting? camera)
        {
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.ApiVersion = apiVersion;
            this.SessionAggregator = sessionAggregator;
            this.HandleSilence = handleSilence;
            this.MaxSessionLength = maxSessionLength;
            this.MaxIdleTime = maxIdleTime;
            this.StartFrame = startFrame;
            this.AudioInputFormat = audioInputFormat;
            this.StreamingWidth = streamingWidth;
            this.StreamingHeight = streamingHeight;
            this.AvatarPositionX = avatarPositionX;
            this.AvatarPositionY = avatarPositionY;
            this.Camera = camera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartStreamingSessionRequest" /> class.
        /// </summary>
        public StartStreamingSessionRequest()
        {
        }

    }
}