
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Anam
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.Llm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.CreateLlmRequestUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestLlmFormat), TypeInfoPropertyName = "CreateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningEffort), TypeInfoPropertyName = "CreateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningFormat), TypeInfoPropertyName = "CreateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestLlmFormat), TypeInfoPropertyName = "UpdateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningEffort), TypeInfoPropertyName = "UpdateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningFormat), TypeInfoPropertyName = "UpdateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListLlmsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Anam.ListLlmsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.ListLlmsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestLlmFormat?), TypeInfoPropertyName = "NullableCreateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningEffort?), TypeInfoPropertyName = "NullableCreateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.CreateLlmRequestReasoningFormat?), TypeInfoPropertyName = "NullableCreateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestLlmFormat?), TypeInfoPropertyName = "NullableUpdateLlmRequestLlmFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningEffort?), TypeInfoPropertyName = "NullableUpdateLlmRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Anam.UpdateLlmRequestReasoningFormat?), TypeInfoPropertyName = "NullableUpdateLlmRequestReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.CreateLlmRequestUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Anam.ListLlmsResponseDataItem>))]
    internal sealed partial class LLMsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static LLMsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private LLMsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Anam.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Anam.CreateLlmRequestLlmFormat)

                    || typeToConvert == typeof(global::Anam.CreateLlmRequestLlmFormat?)

                    || typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningEffort)

                    || typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningFormat)

                    || typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningFormat?)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestLlmFormat)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestLlmFormat?)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningEffort)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningFormat)

                    || typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Anam.CreateLlmRequestLlmFormat))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestLlmFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.CreateLlmRequestLlmFormat?))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestLlmFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningEffort))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningEffort?))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningFormat))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestReasoningFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.CreateLlmRequestReasoningFormat?))
                {
                    return new global::Anam.JsonConverters.CreateLlmRequestReasoningFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestLlmFormat))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestLlmFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestLlmFormat?))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestLlmFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningEffort))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningEffort?))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningFormat))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestReasoningFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Anam.UpdateLlmRequestReasoningFormat?))
                {
                    return new global::Anam.JsonConverters.UpdateLlmRequestReasoningFormatNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new LLMsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}