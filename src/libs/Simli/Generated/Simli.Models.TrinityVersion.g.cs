
#nullable enable

namespace Simli
{
    /// <summary>
    /// The avatar generation: GSA_1.0 makes a Trinity-1 face, GSA_2.0 a Trinity-2 face.
    /// </summary>
    public enum TrinityVersion
    {
        /// <summary>
        /// GSA_1.0 makes a Trinity-1 face, GSA_2.0 a Trinity-2 face.
        /// </summary>
        Gsa10,
        /// <summary>
        /// GSA_1.0 makes a Trinity-1 face, GSA_2.0 a Trinity-2 face.
        /// </summary>
        Gsa20,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrinityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrinityVersion value)
        {
            return value switch
            {
                TrinityVersion.Gsa10 => "GSA_1.0",
                TrinityVersion.Gsa20 => "GSA_2.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrinityVersion? ToEnum(string value)
        {
            return value switch
            {
                "GSA_1.0" => TrinityVersion.Gsa10,
                "GSA_2.0" => TrinityVersion.Gsa20,
                _ => null,
            };
        }
    }
}