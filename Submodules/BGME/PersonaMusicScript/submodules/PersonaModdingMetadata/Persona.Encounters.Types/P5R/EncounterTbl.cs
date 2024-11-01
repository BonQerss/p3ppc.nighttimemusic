using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.P5R;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(Game.P5R_PC, file, 44, true)
    {
    }

    public EncounterTbl(Stream stream)
        : base(Game.P5R_PC, stream, 44, true)
    {
    }
}
