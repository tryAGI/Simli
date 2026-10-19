
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrinityGeneration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Simli.JsonConverters.TrinityGenerationStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Simli.TrinityGenerationState Status { get; set; }

        /// <summary>
        /// Place in the pending queue. 0 once the generation has left the queue and is being worked on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuePosition { get; set; }

        /// <summary>
        /// GSA_2.0 only, while the generation is pending and held by the 10 minutes between one account's GSA_2.0 generations: the Unix time (seconds) it may start. Absent otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispatch_after")]
        public int? DispatchAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrinityGeneration" /> class.
        /// </summary>
        /// <param name="faceId"></param>
        /// <param name="status"></param>
        /// <param name="queuePosition">
        /// Place in the pending queue. 0 once the generation has left the queue and is being worked on.
        /// </param>
        /// <param name="dispatchAfter">
        /// GSA_2.0 only, while the generation is pending and held by the 10 minutes between one account's GSA_2.0 generations: the Unix time (seconds) it may start. Absent otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrinityGeneration(
            string faceId,
            global::Simli.TrinityGenerationState status,
            int queuePosition,
            int? dispatchAfter)
        {
            this.FaceId = faceId ?? throw new global::System.ArgumentNullException(nameof(faceId));
            this.Status = status;
            this.QueuePosition = queuePosition;
            this.DispatchAfter = dispatchAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrinityGeneration" /> class.
        /// </summary>
        public TrinityGeneration()
        {
        }

    }
}