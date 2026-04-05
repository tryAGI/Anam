
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceGender
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceGender value)
        {
            return value switch
            {
                VoiceGender.Female => "female",
                VoiceGender.Male => "male",
                VoiceGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => VoiceGender.Female,
                "male" => VoiceGender.Male,
                "neutral" => VoiceGender.Neutral,
                _ => null,
            };
        }
    }
}