
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentResponseVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseVoiceProvider value)
        {
            return value switch
            {
                AgentResponseVoiceProvider.Cartesia => "cartesia",
                AgentResponseVoiceProvider.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => AgentResponseVoiceProvider.Cartesia,
                "elevenlabs" => AgentResponseVoiceProvider.Elevenlabs,
                _ => null,
            };
        }
    }
}