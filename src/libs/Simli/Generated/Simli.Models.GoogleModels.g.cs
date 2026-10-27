
#nullable enable

namespace Simli
{
    /// <summary>
    /// gemini-3.8-live is speech to speech over Google's Live API. Gemini 2.5 and older are retired: they're still accepted, and run on gemini-3.8-flash.
    /// </summary>
    public enum GoogleModels
    {
        /// <summary>
        /// they're still accepted, and run on gemini-3.8-flash.
        /// </summary>
        Gemini38Flash,
        /// <summary>
        /// they're still accepted, and run on gemini-3.8-flash.
        /// </summary>
        Gemini38Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleModels value)
        {
            return value switch
            {
                GoogleModels.Gemini38Flash => "gemini-3.8-flash",
                GoogleModels.Gemini38Live => "gemini-3.8-live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleModels? ToEnum(string value)
        {
            return value switch
            {
                "gemini-3.8-flash" => GoogleModels.Gemini38Flash,
                "gemini-3.8-live" => GoogleModels.Gemini38Live,
                _ => null,
            };
        }
    }
}