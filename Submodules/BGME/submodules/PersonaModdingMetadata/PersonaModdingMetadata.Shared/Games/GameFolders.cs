namespace PersonaModdingMetadata.Shared.Games;

public static class GameFolders
{
    public static string GameFolder(this Game game, string baseDir) => Path.Join(baseDir, game.ToString());

    public static string OriginalFilesDir(this Game game, string baseDir) => Path.Join(game.GameFolder(baseDir), "original-files");
}
