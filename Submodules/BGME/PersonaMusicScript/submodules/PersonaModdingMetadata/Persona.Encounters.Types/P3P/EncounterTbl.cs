using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared.Games;

namespace Persona.Encounters.Types.P3P;

public class EncounterTbl : BaseEncounterTbl<Encounter>
{
    public EncounterTbl(string file)
        : base(Game.P3P_PC, file, 28)
    {
    }

    public EncounterTbl(Stream stream)
        : base(Game.P3P_PC, stream, 28)
    {
    }
}
