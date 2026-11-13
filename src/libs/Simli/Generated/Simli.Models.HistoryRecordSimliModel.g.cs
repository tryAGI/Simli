
#nullable enable

namespace Simli
{
    /// <summary>
    /// The avatar model that served the session; absent on records that don't say
    /// </summary>
    public enum HistoryRecordSimliModel
    {
        /// <summary>
        ///
        /// </summary>
        Trinity1,
        /// <summary>
        ///
        /// </summary>
        Trinity2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HistoryRecordSimliModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryRecordSimliModel value)
        {
            return value switch
            {
                HistoryRecordSimliModel.Trinity1 => "Trinity 1",
                HistoryRecordSimliModel.Trinity2 => "Trinity 2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryRecordSimliModel? ToEnum(string value)
        {
            return value switch
            {
                "Trinity 1" => HistoryRecordSimliModel.Trinity1,
                "Trinity 2" => HistoryRecordSimliModel.Trinity2,
                _ => null,
            };
        }
    }
}