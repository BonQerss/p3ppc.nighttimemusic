using PersonaModdingMetadata.Shared.Games;

namespace Persona.Music.Types.Common;

public static class DefaultGameMusic
{
    private static readonly Dictionary<Game, GameMusic> music = new()
    {
        [Game.P4G_PC] = new P4G.DefaultSongs(),
        [Game.P5R_PC] = new P5R.DefaultSongs(),
        [Game.P3P_PC] = new P3P.DefaultSongs(),
        [Game.P3R_PC] = new P3R.DefaultSongs(),
    };

    public static GameMusic For(Game game) => music[game];
}
