namespace PersonaModdingMetadata.Shared.Serializers;

public static class CollectionSerializer
{
    public static string Serialize<T>(IEnumerable<T> items)
        where T : notnull
        => string.Join('\n', items.Select(x => x.ToString()));

    public static int[] Deserialize(string text)
    {
        var items = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => !x.StartsWith("//") && !string.IsNullOrEmpty(x))
            .Select(int.Parse)
            .ToArray();

        return items;
    }

    public static void Serialize<T>(string filePath, IEnumerable<T> items)
        where T : notnull
    {
        var file = new FileInfo(filePath);
        file.Directory?.Create();
        File.WriteAllText(file.FullName, Serialize(items));
    }

    public static int[] DeserializeFile(string file) => Deserialize(File.ReadAllText(file));
}
