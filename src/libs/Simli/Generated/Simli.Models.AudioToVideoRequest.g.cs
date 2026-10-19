
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioToVideoRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("audioBase64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.AudioToVideoRequestAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Simli.AudioToVideoRequestAudioFormat AudioFormat { get; set; }

        /// <summary>
        /// Default Value: 16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSampleRate")]
        public int? AudioSampleRate { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioChannelCount")]
        public int? AudioChannelCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoStartingFrame")]
        public int? VideoStartingFrame { get; set; }

        /// <summary>
        /// Turns off the face restoration pass on legacy faces.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableSuperRes")]
        public bool? DisableSuperRes { get; set; }

        /// <summary>
        /// Width of the video in pixels, Trinity-2 faces only (the others keep their own frame size). At least 512, and with streaming_height one of 1:1, 16:9 or 9:16, otherwise a 422. A canvas larger than the avatar's frame is padded with its background; a smaller one crops a window out of it.<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_width")]
        public int? StreamingWidth { get; set; }

        /// <summary>
        /// Height of the video in pixels. See streaming_width.<br/>
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
        /// The camera the video starts with, on top of the avatar's own framing. Trinity-2 only. Leave it out to keep the avatar's framing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera")]
        public global::Simli.CameraSetting? Camera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoRequest" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="audioBase64"></param>
        /// <param name="audioFormat"></param>
        /// <param name="audioSampleRate">
        /// Default Value: 16000
        /// </param>
        /// <param name="audioChannelCount">
        /// Default Value: 1
        /// </param>
        /// <param name="videoStartingFrame">
        /// Default Value: 0
        /// </param>
        /// <param name="disableSuperRes">
        /// Turns off the face restoration pass on legacy faces.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamingWidth">
        /// Width of the video in pixels, Trinity-2 faces only (the others keep their own frame size). At least 512, and with streaming_height one of 1:1, 16:9 or 9:16, otherwise a 422. A canvas larger than the avatar's frame is padded with its background; a smaller one crops a window out of it.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="streamingHeight">
        /// Height of the video in pixels. See streaming_width.<br/>
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
        /// The camera the video starts with, on top of the avatar's own framing. Trinity-2 only. Leave it out to keep the avatar's framing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoRequest(
            string faceId,
            string audioBase64,
            global::Simli.AudioToVideoRequestAudioFormat audioFormat,
            int? audioSampleRate,
            int? audioChannelCount,
            int? videoStartingFrame,
            bool? disableSuperRes,
            int? streamingWidth,
            int? streamingHeight,
            double? avatarPositionX,
            double? avatarPositionY,
            global::Simli.CameraSetting? camera)
        {
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.AudioFormat = audioFormat;
            this.AudioSampleRate = audioSampleRate;
            this.AudioChannelCount = audioChannelCount;
            this.VideoStartingFrame = videoStartingFrame;
            this.DisableSuperRes = disableSuperRes;
            this.StreamingWidth = streamingWidth;
            this.StreamingHeight = streamingHeight;
            this.AvatarPositionX = avatarPositionX;
            this.AvatarPositionY = avatarPositionY;
            this.Camera = camera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoRequest" /> class.
        /// </summary>
        public AudioToVideoRequest()
        {
        }

    }
}