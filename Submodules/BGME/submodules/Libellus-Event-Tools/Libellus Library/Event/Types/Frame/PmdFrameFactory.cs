namespace LibellusLibrary.Event.Types.Frame;

public class PmdFrameFactory
{
	public List<PmdTargetType> ReadDataTypes(BinaryReader reader, uint typeTableCount)
	{
		
		var typeIDs = ReadTypes(reader, typeTableCount);
		List<PmdTargetType> frames = new();
		foreach (var type in typeIDs)
		{
			PmdTargetType? dataType = GetFrameType(type);
			dataType.ReadFrame(reader);
			frames.Add(dataType);
		}

		return frames;
	}

	private List<PmdTargetTypeID> ReadTypes(BinaryReader reader, uint typeTableCount)
	{
		long originalpos = reader.BaseStream.Position;
		List<PmdTargetTypeID> types = new List<PmdTargetTypeID>();

		for (int i = 0; i < typeTableCount; i++)
		{
			types.Add((PmdTargetTypeID)reader.ReadUInt16());
			reader.BaseStream.Position += 0x3A;
		}
		reader.BaseStream.Position = originalpos;
		return types;
	}

	public static PmdTargetType GetFrameType(PmdTargetTypeID Type) => Type switch
	{
		_=>new PmdTarget_Unknown()
	};
}
