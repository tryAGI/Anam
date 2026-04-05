
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSessionTokenRequestPersonaConfigAvatarModel
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
    public static class CreateSessionTokenRequestPersonaConfigAvatarModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSessionTokenRequestPersonaConfigAvatarModel value)
        {
            return value switch
            {
                CreateSessionTokenRequestPersonaConfigAvatarModel.Cara2 => "cara-2",
                CreateSessionTokenRequestPersonaConfigAvatarModel.Cara3 => "cara-3",
                CreateSessionTokenRequestPersonaConfigAvatarModel.Cara4Latest => "cara-4-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSessionTokenRequestPersonaConfigAvatarModel? ToEnum(string value)
        {
            return value switch
            {
                "cara-2" => CreateSessionTokenRequestPersonaConfigAvatarModel.Cara2,
                "cara-3" => CreateSessionTokenRequestPersonaConfigAvatarModel.Cara3,
                "cara-4-latest" => CreateSessionTokenRequestPersonaConfigAvatarModel.Cara4Latest,
                _ => null,
            };
        }
    }
}