namespace Persona.Music.Types.Common;

public class Song
{
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string[] Tags { get; set; } = Array.Empty<string>();

    public int CueId { get; set; }

    public string? ReplacementPath { get; set; }

    public string? Encoder { get; set; }
}
