
#nullable enable

namespace Anam
{
    /// <summary>
    /// Type of tool.
    /// </summary>
    public enum ToolType
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
    public static class ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolType value)
        {
            return value switch
            {
                ToolType.Client => "CLIENT",
                ToolType.ServerRag => "SERVER_RAG",
                ToolType.ServerWebhook => "SERVER_WEBHOOK",
                ToolType.System => "SYSTEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolType? ToEnum(string value)
        {
            return value switch
            {
                "CLIENT" => ToolType.Client,
                "SERVER_RAG" => ToolType.ServerRag,
                "SERVER_WEBHOOK" => ToolType.ServerWebhook,
                "SYSTEM" => ToolType.System,
                _ => null,
            };
        }
    }
}