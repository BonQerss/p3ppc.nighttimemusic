using LibellusLibrary.JSON;
using System.Text.Json.Serialization;

namespace LibellusLibrary.Event.Types.Frame;

public class PmdTarget_Unknown : PmdTargetType
{
	[JsonConverter(typeof(ByteArrayToHexArray))]
	public byte[] Data { get; set; }

	protected override void ReadData(BinaryReader reader)
	{
		Data = reader.ReadBytes(0x34);
	}

	protected override void WriteData(BinaryWriter writer)
	{
		writer?.Write(Data);
	}
}
