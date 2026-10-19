
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrinityGenerationStatus
    {
        /// <summary>
        /// Status of the most recent generation, or not_found when none is tracked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.TrinityGenerationStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Simli.TrinityGenerationState Status { get; set; }

        /// <summary>
        /// Queue position of the most recent generation, or -1 when none is tracked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuePosition { get; set; }

        /// <summary>
        /// The most recent generation's face id. Absent when nothing is tracked and no face_id was requested; echoes the requested face_id otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        public string? FaceId { get; set; }

        /// <summary>
        /// Every generation still tracked for the caller, oldest first. Completed and failed entries remain listed for 24 hours. Empty when none is tracked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Simli.TrinityGeneration> Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrinityGenerationStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the most recent generation, or not_found when none is tracked.
        /// </param>
        /// <param name="queuePosition">
        /// Queue position of the most recent generation, or -1 when none is tracked.
        /// </param>
        /// <param name="generations">
        /// Every generation still tracked for the caller, oldest first. Completed and failed entries remain listed for 24 hours. Empty when none is tracked.
        /// </param>
        /// <param name="faceId">
        /// The most recent generation's face id. Absent when nothing is tracked and no face_id was requested; echoes the requested face_id otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrinityGenerationStatus(
            global::Simli.TrinityGenerationState status,
            int queuePosition,
            global::System.Collections.Generic.IList<global::Simli.TrinityGeneration> generations,
            string? faceId)
        {
            this.Status = status;
            this.QueuePosition = queuePosition;
            this.FaceId = faceId;
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrinityGenerationStatus" /> class.
        /// </summary>
        public TrinityGenerationStatus()
        {
        }

    }
}