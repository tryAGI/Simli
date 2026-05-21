
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToVideoRequest(
            string faceId,
            string audioBase64,
            global::Simli.AudioToVideoRequestAudioFormat audioFormat,
            int? audioSampleRate,
            int? audioChannelCount,
            int? videoStartingFrame)
        {
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.AudioFormat = audioFormat;
            this.AudioSampleRate = audioSampleRate;
            this.AudioChannelCount = audioChannelCount;
            this.VideoStartingFrame = videoStartingFrame;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToVideoRequest" /> class.
        /// </summary>
        public AudioToVideoRequest()
        {
        }

    }
}