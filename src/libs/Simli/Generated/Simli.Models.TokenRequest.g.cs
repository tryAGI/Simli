
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenRequest
    {
        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryStamp")]
        public int? ExpiryStamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simliAPIKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SimliAPIKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmAPIKey")]
        public string? LlmAPIKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsAPIKey")]
        public string? TtsAPIKey { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTranscript")]
        public bool? CreateTranscript { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originAllowList")]
        public global::System.Collections.Generic.IList<string>? OriginAllowList { get; set; }

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
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        /// <param name="simliAPIKey"></param>
        /// <param name="expiryStamp">
        /// Default Value: -1
        /// </param>
        /// <param name="llmAPIKey"></param>
        /// <param name="ttsAPIKey"></param>
        /// <param name="createTranscript">
        /// Default Value: false
        /// </param>
        /// <param name="originAllowList">
        /// Default Value: []
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
        public TokenRequest(
            string simliAPIKey,
            int? expiryStamp,
            string? llmAPIKey,
            string? ttsAPIKey,
            bool? createTranscript,
            global::System.Collections.Generic.IList<string>? originAllowList,
            int? streamingWidth,
            int? streamingHeight,
            double? avatarPositionX,
            double? avatarPositionY,
            global::Simli.CameraSetting? camera)
        {
            this.ExpiryStamp = expiryStamp;
            this.SimliAPIKey = simliAPIKey ?? throw new global::System.ArgumentNullException(nameof(simliAPIKey));
            this.LlmAPIKey = llmAPIKey;
            this.TtsAPIKey = ttsAPIKey;
            this.CreateTranscript = createTranscript;
            this.OriginAllowList = originAllowList;
            this.StreamingWidth = streamingWidth;
            this.StreamingHeight = streamingHeight;
            this.AvatarPositionX = avatarPositionX;
            this.AvatarPositionY = avatarPositionY;
            this.Camera = camera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        public TokenRequest()
        {
        }

    }
}