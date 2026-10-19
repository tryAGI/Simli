
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public enum TrinityGenerationState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrinityGenerationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrinityGenerationState value)
        {
            return value switch
            {
                TrinityGenerationState.Completed => "completed",
                TrinityGenerationState.Failed => "failed",
                TrinityGenerationState.NotFound => "not_found",
                TrinityGenerationState.Pending => "pending",
                TrinityGenerationState.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrinityGenerationState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TrinityGenerationState.Completed,
                "failed" => TrinityGenerationState.Failed,
                "not_found" => TrinityGenerationState.NotFound,
                "pending" => TrinityGenerationState.Pending,
                "processing" => TrinityGenerationState.Processing,
                _ => null,
            };
        }
    }
}