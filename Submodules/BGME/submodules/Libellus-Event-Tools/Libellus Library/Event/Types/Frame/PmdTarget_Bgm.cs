namespace LibellusLibrary.Event.Types.Frame;

public class PmdTarget_Bgm : PmdTargetType
{
    public PmdTarget_Bgm()
    {
		this.TargetType = PmdTargetTypeID.BGM;
		this.NameIndex = ushort.MaxValue;
    }

    private static readonly byte[] unknown1 = new byte[12];

    private static readonly byte[] unknown2 = new byte[36];

    public ushort BgmId { get; set; }

	public PmdBgmType BgmType { get; set; }

	protected override void ReadData(BinaryReader reader)
	{
		this.BgmType = (PmdBgmType)reader.ReadUInt16();
		this.BgmId = reader.ReadUInt16();
    }

	protected override void WriteData(BinaryWriter writer)
	{
		writer.Write(unknown1);
		writer.Write((ushort)this.BgmType);
		writer.Write(this.BgmId);
		writer.Write(unknown2);
	}
}
