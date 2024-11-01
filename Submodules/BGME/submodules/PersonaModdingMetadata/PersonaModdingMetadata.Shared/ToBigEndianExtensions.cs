namespace PersonaModdingMetadata.Shared;

public static class ToBigEndianExtensions
{
    public static int ToBigEndian(this int value)
    {
        var bytes = BitConverter.GetBytes(value);
        Array.Reverse(bytes);
        return BitConverter.ToInt32(bytes);
    }

    public static ushort ToBigEndian(this ushort value)
    {
        var bytes = BitConverter.GetBytes(value);
        Array.Reverse(bytes);
        return BitConverter.ToUInt16(bytes);
    }
}
