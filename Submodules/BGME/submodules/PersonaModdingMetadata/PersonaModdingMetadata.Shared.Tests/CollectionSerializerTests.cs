using PersonaModdingMetadata.Shared.Serializers;

namespace PersonaModdingMetadata.Shared.Tests;

public class CollectionSerializerTests
{
    [Theory]
    [InlineData(new object[] { 1, 2, 3 }, "1\n2\n3")]
    [InlineData(new object[] { "// Comment", 1, "// Comment 2", 2 }, "// Comment\n1\n// Comment 2\n2")]
    public void Serialize_Test(IEnumerable<object> items, string expected)
    {
        var actual = CollectionSerializer.Serialize(items);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("\n1\n2\n3\n", new int[] { 1, 2 , 3})]
    [InlineData("// Comment\n1\n2\n\n//Comment 2\n3\n\n// Comment 3", new int[] { 1, 2, 3 })]
    public void Deserialize_Test(string text, int[] expected)
    {
        var actual = CollectionSerializer.Deserialize(text);
        Assert.True(Enumerable.SequenceEqual(expected, actual));
    }
}
