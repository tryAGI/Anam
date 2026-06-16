#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static partial class AuthCreateSessionTokenCommandApiCommand
{
    private static Option<string?> ClientLabel { get; } = new(
        name: @"--client-label")
    {
        Description = @"Identifier for the session.",
    };

    private static Option<global::Anam.CreateSessionTokenRequestPersonaConfig?> PersonaConfig { get; } = new(
        name: @"--persona-config")
    {
        Description = @"Persona configuration. Either provide inline config or a personaId.",
    };

    private static Option<global::Anam.CreateSessionTokenRequestSessionOptions?> SessionOptions { get; } = new(
        name: @"--session-options")
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

                    private static string FormatResponse(ParseResult parseResult, global::Anam.CreateSessionTokenResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Anam.CreateSessionTokenResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-session-token", @"Create session token
Creates a temporary session token for client-side use. The session token is valid for 1 hour.");
                        command.Options.Add(ClientLabel);
                        command.Options.Add(PersonaConfig);
                        command.Options.Add(SessionOptions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Anam.CreateSessionTokenRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Anam.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var clientLabel = CliRuntime.WasSpecified(parseResult, ClientLabel) ? parseResult.GetValue(ClientLabel) : (__requestBase is { } __ClientLabelBaseValue ? __ClientLabelBaseValue.ClientLabel : default);
                        var personaConfig = CliRuntime.WasSpecified(parseResult, PersonaConfig) ? parseResult.GetValue(PersonaConfig) : (__requestBase is { } __PersonaConfigBaseValue ? __PersonaConfigBaseValue.PersonaConfig : default);
                        var sessionOptions = CliRuntime.WasSpecified(parseResult, SessionOptions) ? parseResult.GetValue(SessionOptions) : (__requestBase is { } __SessionOptionsBaseValue ? __SessionOptionsBaseValue.SessionOptions : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Auth.CreateSessionTokenAsync(
                                    clientLabel: clientLabel,
                                    personaConfig: personaConfig,
                                    sessionOptions: sessionOptions,
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