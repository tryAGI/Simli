
#nullable enable

namespace Simli
{
    /// <summary>
    /// An animation clip a Trinity-2 avatar can play, by the same ID everywhere animations are named.
    /// </summary>
    public enum AnimationId
    {
        /// <summary>
        ///
        /// </summary>
        G003WaveGoodbyeSolo,
        /// <summary>
        ///
        /// </summary>
        SpeakingHandsExplaining,
        /// <summary>
        ///
        /// </summary>
        Wave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnimationIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimationId value)
        {
            return value switch
            {
                AnimationId.G003WaveGoodbyeSolo => "g003_wave_goodbye_solo",
                AnimationId.SpeakingHandsExplaining => "speaking_hands_explaining",
                AnimationId.Wave => "wave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimationId? ToEnum(string value)
        {
            return value switch
            {
                "g003_wave_goodbye_solo" => AnimationId.G003WaveGoodbyeSolo,
                "speaking_hands_explaining" => AnimationId.SpeakingHandsExplaining,
                "wave" => AnimationId.Wave,
                _ => null,
            };
        }
    }
}