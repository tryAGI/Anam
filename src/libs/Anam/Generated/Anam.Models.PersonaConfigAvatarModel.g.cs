
#nullable enable

namespace Anam
{
    /// <summary>
    /// Avatar model version.
    /// </summary>
    public enum PersonaConfigAvatarModel
    {
        /// <summary>
        /// 
        /// </summary>
        Cara2,
        /// <summary>
        /// 
        /// </summary>
        Cara3,
        /// <summary>
        /// 
        /// </summary>
        Cara4Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonaConfigAvatarModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonaConfigAvatarModel value)
        {
            return value switch
            {
                PersonaConfigAvatarModel.Cara2 => "cara-2",
                PersonaConfigAvatarModel.Cara3 => "cara-3",
                PersonaConfigAvatarModel.Cara4Latest => "cara-4-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonaConfigAvatarModel? ToEnum(string value)
        {
            return value switch
            {
                "cara-2" => PersonaConfigAvatarModel.Cara2,
                "cara-3" => PersonaConfigAvatarModel.Cara3,
                "cara-4-latest" => PersonaConfigAvatarModel.Cara4Latest,
                _ => null,
            };
        }
    }
}