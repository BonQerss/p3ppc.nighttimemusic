using Persona.Music.Types.Common;

namespace Persona.Music.Types.P4G;

public class DefaultSongs : GameMusic
{
    public DefaultSongs()
    {
        this.Game = PersonaModdingMetadata.Shared.Games.Game.P4G_PC;
        this.Version = 1;
        this.DefaultBaseReplacementPath = "FEmulator/AWB/snd00_bgm.awb";
        this.DefaultEncoder = "HCA";

        this.Songs.Add(new()
        {
            Name = "Memory",
            Category = Category.Story.ToName(),
            CueId = 54,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/28.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Genesis",
            Category = Category.Boss_Battle.ToName(),
            CueId = 6,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/29.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reach Out To The Truth",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Normal.ToName() },
            CueId = 1,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/30.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 2,
            Tags = new[] { "Shadow Bosses", "Mini-bosses", "Optional Bosses" },
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/31.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A New World Fool",
            Category = Category.Boss_Battle.ToName(),
            CueId = 3,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/32.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Almighty",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Ameno-sagiri" },
            CueId = 4,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/33.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Fog",
            Category = Category.Boss_Battle.ToName(),
            CueId = 5,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/34.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Period",
            Category = Category.Victory_Theme.ToName(),
            CueId = 7,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/35.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "New Days",
            Category = Category.Story.ToName(),
            CueId = 8,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/36.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself",
            Category = Category.Story.ToName(),
            CueId = 9,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/37.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness",
            Category = Category.Story.ToName(),
            CueId = 10,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/38.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Who's There?",
            Category = Category.Story.ToName(),
            CueId = 11,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/39.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "SMILE",
            Category = Category.Story.ToName(),
            CueId = 12,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/40.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reasoning",
            Category = Category.Story.ToName(),
            CueId = 13,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/41.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Power of the Heart",
            Category = Category.Story.ToName(),
            CueId = 14,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/42.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "The Path is Open",
            Category = Category.Story.ToName(),
            CueId = 15,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/43.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Jika Net Tanaka",
            Category = Category.Shop.ToName(),
            CueId = 16,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/44.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "youthful lunch",
            Category = Category.Daily_Life.ToName(),
            CueId = 17,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/45.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "specialist",
            Category = Category.Daily_Life.ToName(),
            CueId = 18,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/46.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A Corner of Memories",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { Tag.Main_Menu.ToName() },
            CueId = 19,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/47.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Poem for Everyone's Souls",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Velvet_Room.ToName() },
            CueId = 20,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/48.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "How much?",
            Category = Category.Shop.ToName(),
            CueId = 21,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/49.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Your Affection",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Clear.ToName(), Tag.Sunny.ToName() },
            CueId = 22,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/50.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Heartbeat,Heartbreak",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Cloudy.ToName() },
            CueId = 23,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/51.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Omen",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Foggy.ToName() },
            CueId = 24,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/52.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Signs of Love",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Dojima_Residence.ToName() },
            CueId = 25,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/53.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Alone",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Dojima_Residence.ToName() },
            CueId = 26,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/54.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Backside of the TV",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName(), "Entrance" },
            CueId = 27,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/55.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Castle",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 28,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/56.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Sauna",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 29,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/57.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Theater",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 30,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/58.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Game",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 31,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/59.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Secret Base",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 32,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/60.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Heaven",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 33,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/61.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Long Way",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 34,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/62.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Corridor",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 35,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/63.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Persona 3)",
            Category = Category.Story.ToName(),
            CueId = 36,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/64.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Fearful Experience (Persona 3)",
            Category = Category.Story.ToName(),
            CueId = 37,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/65.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Crisis (Persona 3)",
            Category = Category.Story.ToName(),
            CueId = 38,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/66.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "P3 fes (Persona 3)",
            Category = Category.Story.ToName(),
            CueId = 39,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/67.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Like a dream come true",
            Category = Category.Story.ToName(),
            CueId = 40,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/68.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness (2nd loop)",
            Category = Category.Boss_Battle.ToName(),
            CueId = 41,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/69.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Borderline of Madness (3rd loop)",
            Category = Category.Boss_Battle.ToName(),
            CueId = 42,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/70.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "ZONE TIME",
            Category = Category.Story.ToName(),
            CueId = 43,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/71.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reasoning -another version-",
            Category = Category.Story.ToName(),
            CueId = 44,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/72.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -another version-",
            Category = Category.Story.ToName(),
            CueId = 46,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/73.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Reach Out To The Truth -First Battle-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 47,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/74.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Traumerei",
            Category = Category.Story.ToName(),
            CueId = 48,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/75.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "SNOWFLAKES",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Snow.ToName() },
            CueId = 53,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/76.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Time To Make History",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Advantage.ToName() },
            CueId = 55,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/77.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle- (Reincarnation) Phase 1",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/78.hca",
            CueId = 56,
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle- (Reincarnation) Phase 2",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/79.hca",
            CueId = 57,
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Girl of the Hollow Forest (unused)",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 58,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/80.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Shin Mitsuo Tensei",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/81.hca",
            Encoder = "HCA",
            CueId = 59,
        });

        this.Songs.Add(new()
        {
            Name = "Electronica in Velvet Room (filtered)",
            Category = Category.Boss_Battle.ToName(),
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/82.hca",
            Encoder = "HCA",
            CueId = 61,
        });

        this.Songs.Add(new()
        {
            Name = "Everyday Sunshine",
            Category = Category.Story.ToName(),
            CueId = 49,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/83.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Girl of the Hollow Forest",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Midnight_Channel.ToName() },
            CueId = 50,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/84.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "A Sky Full Of Stars",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Night.ToName() },
            CueId = 51,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/85.hca",
            Encoder = "HCA",
        });

        this.Songs.Add(new()
        {
            Name = "Let's Hit the Beach!",
            Category = Category.Story.ToName(),
            CueId = 52,
            ReplacementPath = "FEmulator/AWB/snd00_bgm.awb/86.hca",
            Encoder = "HCA",
        });
    }
}
