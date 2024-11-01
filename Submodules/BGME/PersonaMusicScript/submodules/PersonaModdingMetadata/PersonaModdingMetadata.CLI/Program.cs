// See https://aka.ms/new-console-template for more information

using PersonaModdingMetadata.CLI.Common;
using PersonaModdingMetadata.CLI.Encounters;
using PersonaModdingMetadata.CLI.Music;
using Serilog;

Console.WriteLine("Hello, World!");

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Information()
    .CreateLogger();

if (args.Length < 1)
{
    Log.Error("Missing solution directory arg.");
    return;
}

var solutionDir = args[0];
Log.Information("Solution Directory: {dir}", solutionDir);

var generators = new IMetadata[]
{
    new EncountersMetadata(solutionDir),
    new MusicMetadata(solutionDir),
};

void GenerateMetadata()
{
    foreach (var generator in generators)
    {
        var name = generator.GetType().Name;
        Log.Information("Generating: {name}", name);
        generator.Generate();
        Log.Information("Completed: {name}", name);
    }
}

GenerateMetadata();