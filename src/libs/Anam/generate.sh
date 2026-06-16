dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Anam \
  --clientClassName AnamClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/Anam.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Anam.CLI \
  --sdk-project ../../libs/Anam/Anam.csproj \
  --targetFramework net10.0 \
  --namespace Anam \
  --clientClassName AnamClient \
  --package-id Anam.CLI \
  --tool-command-name anam \
  --user-secrets-id Anam.CLI \
  --api-key-env-var ANAM_API_KEY \
  --base-url-env-var ANAM_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
