
#nullable enable

namespace Anam
{
    /// <summary>
    /// Sets the emotional tone of the generated voice.
    /// </summary>
    public enum CartesiaSonic3VoiceGenerationOptionsEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Content,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Scared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaSonic3VoiceGenerationOptionsEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaSonic3VoiceGenerationOptionsEmotion value)
        {
            return value switch
            {
                CartesiaSonic3VoiceGenerationOptionsEmotion.Angry => "angry",
                CartesiaSonic3VoiceGenerationOptionsEmotion.Calm => "calm",
                CartesiaSonic3VoiceGenerationOptionsEmotion.Content => "content",
                CartesiaSonic3VoiceGenerationOptionsEmotion.Neutral => "neutral",
                CartesiaSonic3VoiceGenerationOptionsEmotion.Sad => "sad",
                CartesiaSonic3VoiceGenerationOptionsEmotion.Scared => "scared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaSonic3VoiceGenerationOptionsEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => CartesiaSonic3VoiceGenerationOptionsEmotion.Angry,
                "calm" => CartesiaSonic3VoiceGenerationOptionsEmotion.Calm,
                "content" => CartesiaSonic3VoiceGenerationOptionsEmotion.Content,
                "neutral" => CartesiaSonic3VoiceGenerationOptionsEmotion.Neutral,
                "sad" => CartesiaSonic3VoiceGenerationOptionsEmotion.Sad,
                "scared" => CartesiaSonic3VoiceGenerationOptionsEmotion.Scared,
                _ => null,
            };
        }
    }
}