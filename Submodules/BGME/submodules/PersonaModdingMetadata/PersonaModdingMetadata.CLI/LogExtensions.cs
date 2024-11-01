using Serilog;

namespace PersonaModdingMetadata.CLI;

public static class LogExtensions
{
    public static void CreatedFile(this ILogger log, string file, string message, params object[] objects)
    {
        log.Information(message, objects);
        log.Debug("Created file: {file}", file);
    }
}
