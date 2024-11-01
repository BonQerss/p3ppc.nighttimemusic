using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.P3R;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(Game.P3R_PC, file, 334, true)
    {
    }

    protected override Encounter[] GetEncounters(
        Game game,
        Stream stream,
        int entrySize,
        bool isBigEndian)
    {
        using var br = new BinaryReader(stream);
        var totalSize = 401964-843;

        var totalEncounters = totalSize / entrySize;
        var encounters = new Encounter[totalEncounters];

        for (int i = 0; i < totalEncounters; i++)
        {
            var offset = (i * entrySize) + 843;
            br.BaseStream.Seek(offset, SeekOrigin.Begin);
            encounters[i] = (Encounter)factory.Create(game, i, br);
        }

        return encounters;
    }
}
