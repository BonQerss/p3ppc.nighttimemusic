using PersonaModdingMetadata.Shared;

namespace Persona.Encounters.Types.Common;

public abstract class BaseEncounter<TEnemy, TMusic> : IEncounter
    where TEnemy : Enum
    where TMusic : Enum
{
    public BaseEncounter(int id)
    {
        this.Id = id;
        this.Music = (TMusic)(object)0;
    }

    public BaseEncounter(int id, BinaryReader br, bool isBigEndian = false)
    {
        this.Id = id;
        this.Music = default!;
        this.LoadEncounter(br, isBigEndian);
    }

    public int Id { get; set; }

    public TEnemy[] BattleUnits { get; set; } = Array.Empty<TEnemy>();

    public TMusic Music { get; set; }

    public string Name
    {
        get
        {
            return string.Join(", ", this.BattleUnits.Where(x => (ushort)(object)x != 0).Select(x => x.ToString()));
        }
    }

    public ushort[] BattleUnitsIds => this.BattleUnits.Select(x => (ushort)(object)x).ToArray();

    public ushort MusicId => (ushort)(object)this.Music;

    public ushort FieldId { get; set; }

    public ushort RoomId { get; set; }

    protected virtual void LoadEncounter(BinaryReader br, bool isBigEndian = false)
    {
        // Skip flags and field04/06
        br.BaseStream.Position += 8;
        this.BattleUnits = new ushort[]
        {
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
                isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16(),
        }
        .Select(x => (TEnemy)(object)x)
        .ToArray();

        this.FieldId = isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16();
        this.RoomId = isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16();
        this.Music = (TMusic)(object)(isBigEndian ? br.ReadUInt16().ToBigEndian() : br.ReadUInt16());
    }
}
