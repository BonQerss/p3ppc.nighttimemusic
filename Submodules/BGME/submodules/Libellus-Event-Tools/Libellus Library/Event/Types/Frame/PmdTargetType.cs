using System.Text.Json.Serialization;

namespace LibellusLibrary.Event.Types.Frame;

public class PmdTargetType
{
	[JsonPropertyOrder(-100)]
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public PmdTargetTypeID TargetType { get; set; }
	[JsonPropertyOrder(-99)]
	public ushort StartFrame { get; set; }
	[JsonPropertyOrder(-98)]
	public ushort Length { get; set; }
	[JsonPropertyOrder(-97)]
	public ushort NameIndex { get; set; }

	public void ReadFrame(BinaryReader reader)
	{
		TargetType = (PmdTargetTypeID)reader.ReadUInt16();
		StartFrame = reader.ReadUInt16();
		Length = reader.ReadUInt16();
		NameIndex = reader.ReadUInt16();
		ReadData(reader);
	}

	public void WriteFrame(BinaryWriter writer)
	{
		writer.Write((ushort)TargetType);
		writer.Write((ushort)StartFrame);
		writer.Write((ushort)Length);
		writer.Write((ushort)NameIndex);
		WriteData(writer);
	}

	protected virtual void ReadData(BinaryReader reader) => throw new InvalidOperationException();

	protected virtual void WriteData(BinaryWriter writer) => throw new InvalidOperationException();
}
