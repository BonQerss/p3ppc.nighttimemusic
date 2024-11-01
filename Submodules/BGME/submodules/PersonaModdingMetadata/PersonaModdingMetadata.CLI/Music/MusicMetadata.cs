using Persona.Music.Types.Common;
using PersonaModdingMetadata.CLI.Common;
using PersonaModdingMetadata.Shared.Games;
using Serilog;

namespace PersonaModdingMetadata.CLI.Music;

internal class MusicMetadata : IMetadata
{
    private readonly string baseDir;

    public MusicMetadata(string solutionDir)
    {
        this.baseDir = Path.Join(solutionDir, "Persona.Music.Metadata"); ;
    }

    public void Generate()
    {
        var serializer = new YamlDotNet.Serialization.SerializerBuilder()
            .DisableAliases()
            .Build();

        foreach (var game in Enum.GetValues<Game>())
        {
            var musicFile = Path.Join(game.GameFolder(this.baseDir), "music.yaml");
            Directory.CreateDirectory(Path.GetDirectoryName(musicFile)!);
            var defaultMusic = DefaultGameMusic.For(game);
            var yaml = serializer.Serialize(defaultMusic);
            File.WriteAllText(musicFile, yaml);
            Log.Logger.CreatedFile(musicFile, "Created default music for: {game}", game);
        }
    }
}
