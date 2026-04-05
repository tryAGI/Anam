
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateVoiceRequestGender
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
    public static class UpdateVoiceRequestGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVoiceRequestGender value)
        {
            return value switch
            {
                UpdateVoiceRequestGender.Female => "female",
                UpdateVoiceRequestGender.Male => "male",
                UpdateVoiceRequestGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVoiceRequestGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => UpdateVoiceRequestGender.Female,
                "male" => UpdateVoiceRequestGender.Male,
                "neutral" => UpdateVoiceRequestGender.Neutral,
                _ => null,
            };
        }
    }
}