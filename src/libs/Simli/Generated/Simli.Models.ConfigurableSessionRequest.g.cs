
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConfigurableSessionRequest
    {
        /// <summary>
        /// Default Value: tmp9i8bbq7c
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faceId")]
        public string? FaceId { get; set; }

        /// <summary>
        /// Default Value: Cartesia
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.TtsProviderJsonConverter))]
        public global::Simli.TtsProvider? TtsProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsAPIKey")]
        public string? TtsAPIKey { get; set; }

        /// <summary>
        /// Default Value: sonic-turbo-2025-03-07
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttsModel")]
        public string? TtsModel { get; set; }

        /// <summary>
        /// Default Value: a167e0f3-df7e-4d52-a9c3-f949145efdab
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Default Value: You are Chatbot, a friendly, helpful robot. Your goal is to demonstrate your capabilities in a succinct way. Your output will be converted to audio so don't include special characters in your answers. Respond to what the user said in a creative and helpful way, but keep your responses brief.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessage")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// An animation the avatar plays as it opens the session, when the user joins (with firstMessage, if there is one). Trinity-2 faces only; the others ignore it. Leave it out for no animation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("introAnimation")]
        public global::Simli.AnimationId? IntroAnimation { get; set; }

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
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customLLMConfig")]
        public global::Simli.CustomLLMConfig? CustomLLMConfig { get; set; }

        /// <summary>
        /// Default Value: {"model":"gpt-6-luna","provider":"OpenAI"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmConfig")]
        public global::Simli.LLMConfig? LlmConfig { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTranscript")]
        public bool? CreateTranscript { get; set; }

        /// <summary>
        /// Default Value: fasttalk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.SimliModelsJsonConverter))]
        public global::Simli.SimliModels? Model { get; set; }

        /// <summary>
        /// Turns off the face restoration pass on legacy faces.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableSuperRes")]
        public bool? DisableSuperRes { get; set; }

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
        /// One of your uploaded backgrounds, by the id POST /assets/backgrounds returned, to show behind the avatar, cropped to fill the canvas. Trinity-2 only. Leave it out for the avatar's own. An id that is not one of your account's is dropped with a warning, and the session uses the avatar's own. An image is not accepted: upload it first. Your app can change it in the session by sending the room an app message {"type": "simli-background", "id": "&lt;background id&gt;"}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_id")]
        public global::System.Guid? BackgroundId { get; set; }

        /// <summary>
        /// One of your uploaded foregrounds, by the id POST /assets/foregrounds returned, laid over the avatar through its transparency and cropped to fill the canvas. Trinity-2 only; otherwise as background_id. Your app can change it with {"type": "simli-foreground", "id": "&lt;foreground id&gt;"}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foreground_id")]
        public global::System.Guid? ForegroundId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableSessionRequest" /> class.
        /// </summary>
        /// <param name="faceId">
        /// Default Value: tmp9i8bbq7c
        /// </param>
        /// <param name="ttsProvider">
        /// Default Value: Cartesia
        /// </param>
        /// <param name="ttsAPIKey"></param>
        /// <param name="ttsModel">
        /// Default Value: sonic-turbo-2025-03-07
        /// </param>
        /// <param name="voiceId">
        /// Default Value: a167e0f3-df7e-4d52-a9c3-f949145efdab
        /// </param>
        /// <param name="systemPrompt">
        /// Default Value: You are Chatbot, a friendly, helpful robot. Your goal is to demonstrate your capabilities in a succinct way. Your output will be converted to audio so don't include special characters in your answers. Respond to what the user said in a creative and helpful way, but keep your responses brief.
        /// </param>
        /// <param name="firstMessage"></param>
        /// <param name="introAnimation">
        /// An animation the avatar plays as it opens the session, when the user joins (with firstMessage, if there is one). Trinity-2 faces only; the others ignore it. Leave it out for no animation.
        /// </param>
        /// <param name="maxSessionLength">
        /// Default Value: 3600
        /// </param>
        /// <param name="maxIdleTime">
        /// Default Value: 300
        /// </param>
        /// <param name="language">
        /// Default Value: en
        /// </param>
        /// <param name="customLLMConfig"></param>
        /// <param name="llmConfig">
        /// Default Value: {"model":"gpt-6-luna","provider":"OpenAI"}
        /// </param>
        /// <param name="createTranscript">
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// Default Value: fasttalk
        /// </param>
        /// <param name="disableSuperRes">
        /// Turns off the face restoration pass on legacy faces.<br/>
        /// Default Value: false
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
        /// <param name="backgroundId">
        /// One of your uploaded backgrounds, by the id POST /assets/backgrounds returned, to show behind the avatar, cropped to fill the canvas. Trinity-2 only. Leave it out for the avatar's own. An id that is not one of your account's is dropped with a warning, and the session uses the avatar's own. An image is not accepted: upload it first. Your app can change it in the session by sending the room an app message {"type": "simli-background", "id": "&lt;background id&gt;"}.
        /// </param>
        /// <param name="foregroundId">
        /// One of your uploaded foregrounds, by the id POST /assets/foregrounds returned, laid over the avatar through its transparency and cropped to fill the canvas. Trinity-2 only; otherwise as background_id. Your app can change it with {"type": "simli-foreground", "id": "&lt;foreground id&gt;"}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurableSessionRequest(
            string? faceId,
            global::Simli.TtsProvider? ttsProvider,
            string? ttsAPIKey,
            string? ttsModel,
            string? voiceId,
            string? systemPrompt,
            string? firstMessage,
            global::Simli.AnimationId? introAnimation,
            int? maxSessionLength,
            int? maxIdleTime,
            string? language,
            global::Simli.CustomLLMConfig? customLLMConfig,
            global::Simli.LLMConfig? llmConfig,
            bool? createTranscript,
            global::Simli.SimliModels? model,
            bool? disableSuperRes,
            int? streamingWidth,
            int? streamingHeight,
            double? avatarPositionX,
            double? avatarPositionY,
            global::Simli.CameraSetting? camera,
            global::System.Guid? backgroundId,
            global::System.Guid? foregroundId)
        {
            this.FaceId = faceId;
            this.TtsProvider = ttsProvider;
            this.TtsAPIKey = ttsAPIKey;
            this.TtsModel = ttsModel;
            this.VoiceId = voiceId;
            this.SystemPrompt = systemPrompt;
            this.FirstMessage = firstMessage;
            this.IntroAnimation = introAnimation;
            this.MaxSessionLength = maxSessionLength;
            this.MaxIdleTime = maxIdleTime;
            this.Language = language;
            this.CustomLLMConfig = customLLMConfig;
            this.LlmConfig = llmConfig;
            this.CreateTranscript = createTranscript;
            this.Model = model;
            this.DisableSuperRes = disableSuperRes;
            this.StreamingWidth = streamingWidth;
            this.StreamingHeight = streamingHeight;
            this.AvatarPositionX = avatarPositionX;
            this.AvatarPositionY = avatarPositionY;
            this.Camera = camera;
            this.BackgroundId = backgroundId;
            this.ForegroundId = foregroundId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableSessionRequest" /> class.
        /// </summary>
        public ConfigurableSessionRequest()
        {
        }

    }
}