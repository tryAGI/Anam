
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Persona,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptMessageRole value)
        {
            return value switch
            {
                TranscriptMessageRole.Persona => "persona",
                TranscriptMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "persona" => TranscriptMessageRole.Persona,
                "user" => TranscriptMessageRole.User,
                _ => null,
            };
        }
    }
}