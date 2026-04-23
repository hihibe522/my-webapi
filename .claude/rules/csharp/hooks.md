---
paths:
  - "**/*.cs"
  - "**/*.csx"
  - "**/*.csproj"
  - "**/*.sln"
---
# C# Hooks

## PostToolUse

After editing `.cs` or `.csproj` files:

- Run `dotnet build` to verify the project still compiles
- Run `dotnet format` to apply formatting and analyzer fixes

## Stop

- Run a final `dotnet build` before ending a session with broad C# changes
- Warn on modified `appsettings*.json` files so secrets do not get committed
