
#nullable enable

namespace Anam
{
    /// <summary>
    /// Type of tool.
    /// </summary>
    public enum CreateToolRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        ServerRag,
        /// <summary>
        /// 
        /// </summary>
        ServerWebhook,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolRequestType value)
        {
            return value switch
            {
                CreateToolRequestType.Client => "CLIENT",
                CreateToolRequestType.ServerRag => "SERVER_RAG",
                CreateToolRequestType.ServerWebhook => "SERVER_WEBHOOK",
                CreateToolRequestType.System => "SYSTEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolRequestType? ToEnum(string value)
        {
            return value switch
            {
                "CLIENT" => CreateToolRequestType.Client,
                "SERVER_RAG" => CreateToolRequestType.ServerRag,
                "SERVER_WEBHOOK" => CreateToolRequestType.ServerWebhook,
                "SYSTEM" => CreateToolRequestType.System,
                _ => null,
            };
        }
    }
}