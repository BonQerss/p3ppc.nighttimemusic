using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.P4G;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(Game.P4G_PC, file, 24)
    {
    }

    public EncounterTbl(Stream stream)
        : base(Game.P4G_PC, stream, 24)
    {
    }
}
