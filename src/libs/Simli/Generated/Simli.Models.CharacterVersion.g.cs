
#nullable enable

namespace Simli
{
    /// <summary>
    /// 
    /// </summary>
    public enum CharacterVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CharacterVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CharacterVersion value)
        {
            return value switch
            {
                CharacterVersion.x15 => "1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CharacterVersion? ToEnum(string value)
        {
            return value switch
            {
                "1.5" => CharacterVersion.x15,
                _ => null,
            };
        }
    }
}