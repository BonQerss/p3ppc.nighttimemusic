using Persona.Music.Types.Common;

namespace Persona.Music.Types.P3P;

public class DefaultSongs : GameMusic
{
    public DefaultSongs()
    {
        this.Game = PersonaModdingMetadata.Shared.Games.Game.P3P_PC;
        this.Version = 1;
        this.DefaultBaseReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm";
        this.DefaultEncoder = "ADX";

        this.Songs.Add(new()
        {
            Name = "tartarus_0d01",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "1st Block" },
            CueId = 1,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/1.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Shadow",
            Category = Category.Story.ToName(),
            CueId = 19,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/19.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Deep Breath Deep Breath",
            Category = Category.Story.ToName(),
            CueId = 20,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/20.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Basement",
            Category = Category.Story.ToName(),
            CueId = 21,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/21.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "A Deep Mentality",
            Category = Category.Story.ToName(),
            CueId = 22,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/22.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "When The Moon's Reaching Out Stars",
            Category = Category.Overworld.ToName(),
            CueId = 25,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/25.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Mass Destruction",
            Category = Category.Normal_Battle.ToName(),
            CueId = 26,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/26.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Master Of Shadow",
            Category = Category.Boss_Battle.ToName(),
            CueId = 27,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/27.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Unavoidable Battle",
            Category = Category.Boss_Battle.ToName(),
            CueId = 28,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/28.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Burn My Dread -Last Battle-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 29,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/29.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Battle For Everyone's Soul",
            Category = Category.Boss_Battle.ToName(),
            CueId = 30,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/30.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Master Of Tartarus",
            Category = Category.Boss_Battle.ToName(),
            CueId = 31,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/31.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Kyoto",
            Category = Category.Location.ToName(),
            Tags = new[] { "Kyoto" },
            CueId = 32,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/32.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Troubled",
            Category = Category.Story.ToName(),
            CueId = 35,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/35.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "That Which Comes From The Darkness",
            Category = Category.Story.ToName(),
            CueId = 36,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/36.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Living With Determination",
            Category = Category.Story.ToName(),
            CueId = 37,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/37.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Story)",
            Category = Category.Story.ToName(),
            CueId = 38,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/38.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Fearful Experience",
            Category = Category.Story.ToName(),
            CueId = 39,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/39.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Calamity",
            Category = Category.Story.ToName(),
            CueId = 40,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/40.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of You",
            Category = Category.Story.ToName(),
            Tags = new[] { "Ending" },
            CueId = 42,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/42.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Social Links)",
            Category = Category.Story.ToName(),
            CueId = 43,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/43.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "This Strange Feeling",
            Category = Category.Story.ToName(),
            CueId = 44,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/44.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Crisis",
            Category = Category.Story.ToName(),
            CueId = 45,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/45.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Path is Open",
            Category = Category.Story.ToName(),
            CueId = 46,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/46.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Want To Be Close",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "1st Semester" },
            CueId = 50,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/50.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Changing Seasons",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "2nd Semester" },
            CueId = 51,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/51.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of the School (Another Version)",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "January" },
            CueId = 52,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/52.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Iwatodai Dorm",
            Category = Category.Location.ToName(),
            Tags = new[] { "Iwatodai Dorm" },
            CueId = 53,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/53.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Aria of the Soul",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Velvet_Room.ToName() },
            CueId = 54,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/54.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Tanaka's Amazing Commodities",
            Category = Category.Shop.ToName(),
            CueId = 55,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/55.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Paulownia Mall",
            Category = Category.Shop.ToName(),
            CueId = 56,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/56.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "After the Battle",
            Category = Category.Victory_Theme.ToName(),
            CueId = 60,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/60.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Path Was Closed",
            Category = Category.Story.ToName(),
            CueId = 62,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/62.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d02",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "2nd Block" },
            CueId = 70,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/70.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Voice Someone Calls",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "Entrance" },
            CueId = 71,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/71.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d04",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "4th Block" },
            CueId = 72,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/72.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d05",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "5th Block" },
            CueId = 73,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/73.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d06 (Tartarus)",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "6th Block" },
            CueId = 74,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/74.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d06 (Story)",
            Category = Category.Story.ToName(),
            CueId = 75,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/75.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Living With Determination -Iwatodai Dormitory Arrange-",
            Category = Category.Location.ToName(),
            Tags = new[] { "Iwatodai Dorm" },
            CueId = 77,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/77.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Mistic",
            Category = Category.Story.ToName(),
            CueId = 79,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/79.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Memories Of The City",
            Category = Category.Location.ToName(),
            Tags = new[] { "Port Island" },
            CueId = 80,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/80.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d03",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "3rd Block" },
            CueId = 81,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/81.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Peace",
            Category = Category.Story.ToName(),
            CueId = 85,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/85.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Power of the Heart",
            Category = Category.Story.ToName(),
            CueId = 86,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/86.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Adventured act",
            Category = Category.Story.ToName(),
            CueId = 87,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/87.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of the School",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName() },
            CueId = 88,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/88.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "During the Exams...",
            Category = Category.Daily_Life.ToName(),
            CueId = 89,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/89.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "An Unpleasant Premonition",
            Category = Category.Story.ToName(),
            CueId = 90,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/90.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Afternoon Break",
            Category = Category.Daily_Life.ToName(),
            CueId = 91,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/91.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Between Doors",
            Category = Category.Location.ToName(),
            Tags = new[] { "Vision Quest" },
            CueId = 101,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/101.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "The Snow Queen",
            Category = "Fuuka BGM",
            CueId = 102,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/102.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Maya Theme",
            Category = "Fuuka BGM",
            CueId = 103,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/103.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Persona",
            Category = "Fuuka BGM",
            CueId = 104,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/104.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Time Castle",
            Category = "Fuuka BGM",
            CueId = 105,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/105.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Brand New Days",
            Category = Category.Story.ToName(),
            Tags = new[] { "The Answer Ending Theme" },
            CueId = 115,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/115.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Time",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "1st Semester", Tag.FEMC.ToName() },
            CueId = 120,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/120.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Sun",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "2nd Semester", Tag.FEMC.ToName() },
            CueId = 121,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/121.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Wiping All Out",
            Category = Category.Normal_Battle.ToName(),
            CueId = 122,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/122.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Danger Zone",
            Category = Category.Boss_Battle.ToName(),
            CueId = 123,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/123.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Way of Life",
            Category = Category.Location.ToName(),
            Tags = new[] { "Port Island", Tag.FEMC.ToName() },
            CueId = 124,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/124.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "After School",
            Category = Category.Story.ToName(),
            CueId = 125,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/125.adx",
            Encoder = "ADX",
        });

        this.Songs.Add(new()
        {
            Name = "Tender Feeling",
            Category = Category.Story.ToName(),
            CueId = 126,
            ReplacementPath = "P5REssentials/CPK/Phos Music Manager/data/sound/bgm/126.adx",
            Encoder = "ADX",
        });
    }
}
