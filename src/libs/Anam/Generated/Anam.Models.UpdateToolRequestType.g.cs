
#nullable enable

namespace Anam
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateToolRequestType
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
    public static class UpdateToolRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolRequestType value)
        {
            return value switch
            {
                UpdateToolRequestType.Client => "CLIENT",
                UpdateToolRequestType.ServerRag => "SERVER_RAG",
                UpdateToolRequestType.ServerWebhook => "SERVER_WEBHOOK",
                UpdateToolRequestType.System => "SYSTEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolRequestType? ToEnum(string value)
        {
            return value switch
            {
                "CLIENT" => UpdateToolRequestType.Client,
                "SERVER_RAG" => UpdateToolRequestType.ServerRag,
                "SERVER_WEBHOOK" => UpdateToolRequestType.ServerWebhook,
                "SYSTEM" => UpdateToolRequestType.System,
                _ => null,
            };
        }
    }
}