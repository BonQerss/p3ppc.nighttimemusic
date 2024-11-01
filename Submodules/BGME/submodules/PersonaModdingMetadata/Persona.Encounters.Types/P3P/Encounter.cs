using Persona.Encounters.Types.Common;

namespace Persona.Encounters.Types.P3P;

public class Encounter : BaseEncounter<BattleUnit, Music>
{
    public Encounter(int id, BinaryReader br)
        : base(id, br)
    {
    }
}
