using Persona.Encounters.Types.Common;
using PersonaModdingMetadata.Shared;

namespace Persona.Encounters.Types.P3R;

public class Encounter : BaseEncounter<BattleUnit, Music>
{
    public Encounter(int id)
        : base(id)
    {
    }

    public Encounter(int id, BinaryReader br, bool isBigEndian = false)
        : base(id, br, isBigEndian)
    {
    }

    protected override void LoadEncounter(BinaryReader br, bool isBigEndian = false)
    {
        br.ReadBytes(4); // flags
        br.ReadBytes(25);
        br.ReadBytes(2); // party item
        br.ReadBytes(25);
        br.ReadBytes(2); // party item number
        br.ReadBytes(25);

        var battleUnits = new List<ushort>();

        battleUnits.Add(br.ReadUInt16());
        br.ReadBytes(25);
        battleUnits.Add(br.ReadUInt16());
        br.ReadBytes(25);
        battleUnits.Add(br.ReadUInt16());
        br.ReadBytes(25);
        battleUnits.Add(br.ReadUInt16());
        br.ReadBytes(25);
        battleUnits.Add(br.ReadUInt16());
        br.ReadBytes(25);

        this.BattleUnits = battleUnits.Select(x => (BattleUnit)(object)x).ToArray();

        br.ReadBytes(2); // major id
        br.ReadBytes(25);
        br.ReadBytes(2); // minor id
        br.ReadBytes(25);
        this.Music = (Music)(object)(isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16());
    }
}
