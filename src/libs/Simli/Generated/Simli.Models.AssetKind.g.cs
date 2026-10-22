
#nullable enable

namespace Simli
{
    /// <summary>
    ///
    /// </summary>
    public enum AssetKind
    {
        /// <summary>
        ///
        /// </summary>
        Backgrounds,
        /// <summary>
        ///
        /// </summary>
        Foregrounds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetKind value)
        {
            return value switch
            {
                AssetKind.Backgrounds => "backgrounds",
                AssetKind.Foregrounds => "foregrounds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetKind? ToEnum(string value)
        {
            return value switch
            {
                "backgrounds" => AssetKind.Backgrounds,
                "foregrounds" => AssetKind.Foregrounds,
                _ => null,
            };
        }
    }
}