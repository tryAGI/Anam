#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class KnowledgeUploadKnowledgeGroupDocumentCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"",
    };

    private static Option<byte[]> File { get; } = new(
        name: @"--file")
    {
        Description = @"Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).",
        Required = true,
    };

    private static Option<string> Filename { get; } = new(
        name: @"--filename")
    {
        Description = @"Document file (PDF, TXT, MD, DOCX, or CSV, max 50MB).",
        Required = true,
    };

    private static Option<int?> ChunkSize { get; } = new(
        name: @"--chunk-size")
    {
        Description = @"",
    };

    private static Option<int?> ChunkOverlap { get; } = new(
        name: @"--chunk-overlap")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Anam.KnowledgeDocument value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.KnowledgeDocument value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"upload-knowledge-group-document", @"Upload knowledge group document
Upload a document to a knowledge group (PDF, TXT, MD, DOCX, CSV up to 50MB).");
                        command.Arguments.Add(Id);
                        command.Options.Add(File);
                        command.Options.Add(Filename);
                        command.Options.Add(ChunkSize);
                        command.Options.Add(ChunkOverlap);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.UploadKnowledgeGroupDocumentRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var file = parseResult.GetRequiredValue(File);
                        var filename = parseResult.GetRequiredValue(Filename);
                        var chunkSize = CliRuntime.WasSpecified(parseResult, ChunkSize) ? parseResult.GetValue(ChunkSize) : (__requestBase is { } __ChunkSizeBaseValue ? __ChunkSizeBaseValue.ChunkSize : default);
                        var chunkOverlap = CliRuntime.WasSpecified(parseResult, ChunkOverlap) ? parseResult.GetValue(ChunkOverlap) : (__requestBase is { } __ChunkOverlapBaseValue ? __ChunkOverlapBaseValue.ChunkOverlap : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Knowledge.UploadKnowledgeGroupDocumentAsync(
                                    id: id,
                                    file: file,
                                    filename: filename,
                                    chunkSize: chunkSize,
                                    chunkOverlap: chunkOverlap,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Anam.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}