
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        ElevenLabs,
        /// <summary>
        /// 
        /// </summary>
        PlayHT,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsProvider value)
        {
            return value switch
            {
                TtsProvider.Cartesia => "Cartesia",
                TtsProvider.ElevenLabs => "ElevenLabs",
                TtsProvider.PlayHT => "PlayHT",
                TtsProvider.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsProvider? ToEnum(string value)
        {
            return value switch
            {
                "Cartesia" => TtsProvider.Cartesia,
                "ElevenLabs" => TtsProvider.ElevenLabs,
                "PlayHT" => TtsProvider.PlayHT,
                "User" => TtsProvider.User,
                _ => null,
            };
        }
    }
}