
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRequestVoiceProvider
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
    public static class AgentRequestVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestVoiceProvider value)
        {
            return value switch
            {
                AgentRequestVoiceProvider.Cartesia => "cartesia",
                AgentRequestVoiceProvider.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => AgentRequestVoiceProvider.Cartesia,
                "elevenlabs" => AgentRequestVoiceProvider.Elevenlabs,
                _ => null,
            };
        }
    }
}