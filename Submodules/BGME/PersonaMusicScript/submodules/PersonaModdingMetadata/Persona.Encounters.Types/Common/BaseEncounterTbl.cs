using PersonaModdingMetadata.Shared;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounterTbl<TEncounter>
    where TEncounter : IEncounter
{
    protected readonly IEncounterFactory<IEncounter> factory = new EncounterFactory();

    public BaseEncounterTbl(
        Game game,
        string file,
        int entrySize,
        bool isBigEndian = false)
    {
        this.Game = game;
        var stream = new FileStream(file, FileMode.Open, FileAccess.Read);
        this.Encounters = GetEncounters(game, stream, entrySize, isBigEndian);
    }

    public BaseEncounterTbl(
        Game game,
        Stream stream,
        int entrySize,
        bool isBigEndian = false)
    {
        this.Game = game;
        this.Encounters = GetEncounters(game, stream, entrySize, isBigEndian);
    }

    public TEncounter[] Encounters { get; }

    public Game Game { get; }

    protected virtual TEncounter[] GetEncounters(
        Game game,
        Stream stream,
        int entrySize,
        bool isBigEndian)
    {
        using var br = new BinaryReader(stream);
        var totalSize = isBigEndian ? br.ReadInt32().ToBigEndian() : br.ReadInt32();

        var totalEncounters = totalSize / entrySize;
        var encounters = new TEncounter[totalEncounters];

        for (int i = 0; i < totalEncounters; i++)
        {
            var offset = (i * entrySize) + 4;
            br.BaseStream.Seek(offset, SeekOrigin.Begin);
            encounters[i] = (TEncounter)factory.Create(game, i, br);
        }

        return encounters;
    }
}
