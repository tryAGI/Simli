
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentUpdateVoiceProvider
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
    public static class AgentUpdateVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateVoiceProvider value)
        {
            return value switch
            {
                AgentUpdateVoiceProvider.Cartesia => "cartesia",
                AgentUpdateVoiceProvider.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => AgentUpdateVoiceProvider.Cartesia,
                "elevenlabs" => AgentUpdateVoiceProvider.Elevenlabs,
                _ => null,
            };
        }
    }
}