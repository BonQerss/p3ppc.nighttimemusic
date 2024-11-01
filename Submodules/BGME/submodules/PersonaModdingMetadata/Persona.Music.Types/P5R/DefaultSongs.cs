using Persona.Music.Types.Common;

namespace Persona.Music.Types.P5R;

public class DefaultSongs : GameMusic
{
    public DefaultSongs()
    {
        this.Game = PersonaModdingMetadata.Shared.Games.Game.P5R_PC;
        this.Version = 1;
        this.DefaultBaseReplacementPath = "FEmulator/AWB/BGM.AWB";
        this.DefaultEncoder = "ADX (Persona 5 Royal PC)";

        this.Songs.Add(new()
        {
            Name = "Endless Days",
            Category = Category.Daily_Life.ToName(),
            CueId = 28,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/0.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Ideal and the Real",
            Category = Category.Story.ToName(),
            CueId = 44,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/1.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "No More What Ifs -instrumental version-",
            Category = Category.Location.ToName(),
            Tags = new[] { "Thieve's Den" },
            CueId = 939,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/2.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "No More What Ifs",
            Category = Category.Location.ToName(),
            Tags = new[] { "Jazz Club" },
            CueId = 923,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/3.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "No More What Ifs (filtered)",
            Category = Category.Unknown.ToName(),
            CueId = 922,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/4.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "I believe",
            Category = Category.Story.ToName(),
            CueId = 904,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/5.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Take Over",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Advantage.ToName() },
            CueId = 907,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/6.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Keep Your Faith",
            Category = Category.Boss_Battle.ToName(),
            CueId = 908,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/7.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Throw Away Your Mask",
            Category = Category.Boss_Battle.ToName(),
            CueId = 909,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/8.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Our Light (Intro Only)",
            Category = Category.Unknown.ToName(),
            CueId = 961,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/9.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Gentle Madman",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 905,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/10.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Out of Kindness",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 906,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/11.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "So Happy World",
            Category = Category.Location.ToName(),
            Tags = new[] { "Third Semester" },
            CueId = 931,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/12.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mementos: Mid Area",
            CueId = 934,
            Category = Category.Location.ToName(),
            Tags = new[] { "Mementos" },
            ReplacementPath = "FEmulator/AWB/BGM.AWB/13.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mementos: Lower Area",
            Category = Category.Location.ToName(),
            Tags = new[] { "Mementos" },
            CueId = 935,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/14.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mementos: Upper Area",
            Category = Category.Location.ToName(),
            Tags = new[] { "Mementos" },
            CueId = 933,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/15.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Our Light",
            Category = Category.Story.ToName(),
            Tags = new[] { Category.Ending.ToName() },
            CueId = 957,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/16.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Wake Up, Get Up, Get Out There (Extended)",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { "Intro Movie", "Original" },
            CueId = 800,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/17.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Hoshi To Bokura To",
            Category = Category.Story.ToName(),
            Tags = new[] { Category.Ending.ToName() },
            CueId = 802,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/18.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Wake Up, Get Up, Get Out There",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { "Intro Movie", "Original" },
            CueId = 801,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/19.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Colors Flying High -opening movie version- (Extended)",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { "Intro Movie" },
            CueId = 956,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/20.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "He's a Trickster",
            Category = Category.Story.ToName(),
            CueId = 960,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/21.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Ideal and the Real -end version- (Extended)",
            Category = Category.Story.ToName(),
            Tags = new[] { Category.Ending.ToName() },
            CueId = 958,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/22.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Prison Labor",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Challenges" },
            CueId = 940,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/23.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Colors Flying High -opening movie version-",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { "Intro Movie" },
            CueId = 900,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/24.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Unknown Song 1",
            Category = Category.Unknown.ToName(),
            CueId = 919,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/25.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Kichijoji 199X",
            Category = Category.Location.ToName(),
            Tags = new[] { "Kichijoji" },
            CueId = 924,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/26.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Royal Days - another version",
            Category = Category.Story.ToName(),
            Tags = new[] { Category.Ending.ToName() },
            CueId = 902,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/27.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "wish come true",
            Category = Category.Story.ToName(),
            CueId = 920,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/28.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Ideal and the Real (duplicate)",
            Category = Category.Story.ToName(),
            CueId = 915,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/29.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Royal Days",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { Tag.Main_Menu.ToName() },
            CueId = 901,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/30.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mass Destruction",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Challenge Battle" },
            CueId = 941,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/31.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Reach Out to the Truth",
            Category = Category.Boss_Battle.ToName(),
            Tags = new[] { "Challenge Battle" },
            CueId = 942,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/32.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mementos: New Area",
            Category = Category.Location.ToName(),
            Tags = new[] { "Mementos" },
            CueId = 936,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/33.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "He's a Trickster (duplicate)",
            Category = Category.Story.ToName(),
            CueId = 959,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/34.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Another Ideology",
            Category = Category.Story.ToName(),
            Tags = new[] { "Ending" },
            CueId = 913,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/35.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Another Ideology (Cut)",
            Category = Category.Story.ToName(),
            Tags = new[] { "Ending" },
            CueId = 914,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/36.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Ideal and the Real -end version-",
            Category = Category.Story.ToName(),
            Tags = new[] { Category.Ending.ToName() },
            CueId = 903,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/37.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });


        this.Songs.Add(new()
        {
            Name = "Unknown Song 2",
            Category = Category.Unknown.ToName(),
            CueId = 918,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/38.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Rivers in the Desert -instrumental version- (Cut)",
            CueId = 337,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/39.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Crane Game",
            Category = Category.Location.ToName(),
            Tags = new[] { "Arcade" },
            CueId = 217,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/40.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Crossroads",
            Category = Category.Location.ToName(),
            Tags = new[] { "Crossroads" },
            CueId = 209,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/41.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Triple Seven",
            Category = Category.Location.ToName(),
            Tags = new[] { "Convience Store" },
            CueId = 215,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/42.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Destinyland",
            Category = Category.Location.ToName(),
            Tags = new[] { "Destinyland" },
            CueId = 213,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/43.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Big Bang Burger March",
            Category = Category.Location.ToName(),
            Tags = new[] { "Big Bang Burger" },
            CueId = 216,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/44.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Planetarium",
            Category = Category.Location.ToName(),
            Tags = new[] { "Planetarium" },
            CueId = 210,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/45.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Welcome Home, Master!",
            Category = Category.Location.ToName(),
            Tags = new[] { "Maid Cafe" },
            CueId = 214,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/46.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Time to Repent",
            Category = Category.Location.ToName(),
            Tags = new[] { "Church" },
            CueId = 212,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/47.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Meiji Shrine",
            Category = Category.Location.ToName(),
            Tags = new[] { "Meiji Shrine" },
            CueId = 211,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/48.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Tanaka's Shady Commodities",
            Category = Category.Shop.ToName(),
            Tags = new[] { "Tanaka's Shady Commodities" },
            CueId = 207,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/49.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Home Electronics Store",
            Category = Category.Location.ToName(),
            Tags = new[] { "Home Electronics Store" },
            CueId = 208,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/50.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "New Beginning (Quiet)",
            Category = Category.Story.ToName(),
            CueId = 40,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/51.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "New Beginning (Quiet / No Intro)",
            Category = Category.Story.ToName(),
            CueId = 41,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/52.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Erosion",
            Category = Category.Story.ToName(),
            CueId = 35,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/54.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "My Homie",
            Category = Category.Story.ToName(),
            CueId = 0,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/55.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "The Spirit",
            Category = Category.Story.ToName(),
            CueId = 700,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/56.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "What's Going On?",
            Category = Category.Story.ToName(),
            CueId = 4,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/57.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Blood of Villain",
            Category = Category.Story.ToName(),
            CueId = 23,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/58.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Regret",
            Category = Category.Story.ToName(),
            CueId = 24,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/59.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "New Beginning",
            Category = Category.Story.ToName(),
            CueId = 6,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/60.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "New Beginning (No Intro)",
            Category = Category.Story.ToName(),
            CueId = 7,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/61.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Interrogation Room",
            Category = Category.Story.ToName(),
            CueId = 19,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/62.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Desire",
            Category = Category.Story.ToName(),
            CueId = 20,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/63.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Suspicion",
            Category = Category.Story.ToName(),
            CueId = 22,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/64.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Confession / Secret (No Intro)",
            Category = Category.Story.ToName(),
            CueId = 21,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/65.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Confession / Secret",
            Category = Category.Story.ToName(),
            CueId = 32,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/66.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Alleycat (No Intro)",
            Category = Category.Story.ToName(),
            CueId = 5,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/67.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Alleycat",
            Category = Category.Story.ToName(),
            CueId = 33,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/68.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "So Boring",
            Category = Category.Daily_Life.ToName(),
            CueId = 36,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/69.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Wicked Plan (No Intro)",
            CueId = 2,
            Category = Category.Story.ToName(),
            ReplacementPath = "FEmulator/AWB/BGM.AWB/70.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Wicked Plan",
            Category = Category.Story.ToName(),
            CueId = 30,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/71.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Days of Sisters",
            Category = Category.Story.ToName(),
            CueId = 39,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/72.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Alright",
            Category = Category.Story.ToName(),
            CueId = 14,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/73.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Alright -elp version-",
            Category = Category.Story.ToName(),
            CueId = 15,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/74.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Break it Down",
            Category = Category.Story.ToName(),
            CueId = 8,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/75.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Break it Down -elp version-",
            Category = Category.Story.ToName(),
            CueId = 9,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/76.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Swear to My Bones",
            Category = Category.Story.ToName(),
            CueId = 38,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/77.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Life Will Change",
            Category = Category.Location.ToName(),
            Tags = new[] { "Palace", "Infiltration" },
            CueId = 471,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/78.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Life Will Change -instrumental version-",
            Category = Category.Location.ToName(),
            Tags = new[] { "Palace", "Infiltration" },
            CueId = 630,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/79.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Life Will Change -instrumental version- (Intro Only)",
            Category = Category.Location.ToName(),
            Tags = new[] { "Palace", "Infiltration" },
            CueId = 43,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/80.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Sunset Bridge (No Intro)",
            Category = Category.Story.ToName(),
            CueId = 3,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/81.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Sunset Bridge",
            Category = Category.Story.ToName(),
            CueId = 31,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/82.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Sweet",
            Category = Category.Story.ToName(),
            CueId = 16,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/83.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Run,Run,Run!",
            Category = Category.Story.ToName(),
            CueId = 12,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/84.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Tension",
            Category = Category.Story.ToName(),
            CueId = 10,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/85.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "High Pressure",
            Category = Category.Location.ToName(),
            Tags = new[] { "Palace" },
            CueId = 18,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/86.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Awakening",
            Category = Category.Story.ToName(),
            CueId = 26,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/87.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Awakening (Alternate Version)",
            Category = Category.Story.ToName(),
            CueId = 11,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/88.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Life Goes On",
            Category = Category.Daily_Life.ToName(),
            CueId = 37,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/89.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Layer Cake",
            Category = Category.Shop.ToName(),
            CueId = 503,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/90.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Butterfly Kiss",
            Category = Category.Shop.ToName(),
            CueId = 502,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/91.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Phantom",
            Category = Category.Title_Screen.ToName(),
            Tags = new[] { Tag.Main_Menu.ToName(), "Original" },
            ReplacementPath = "FEmulator/AWB/BGM.AWB/92.adx",
            CueId = 101,
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Sweatshop -another version-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 441,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/93.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Sweatshop",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 440,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/94.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Price -another version-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 422,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/95.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Price",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 420,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/96.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "King, Queen, And Slaves -another version-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 17,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/97.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "King, Queen, And Slaves",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 400,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/98.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Have a Short Rest",
            Category = Category.Location.ToName(),
            Tags = new[] { "Safe Room" },
            CueId = 495,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/99.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "When Mother Was There -another version-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 432,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/100.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "When Mother Was There",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 430,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/101.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "A Woman -another version-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 411,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/102.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "A Woman",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 410,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/103.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Mementos",
            Category = Category.Location.ToName(),
            Tags = new[] { "Mementos" },
            CueId = 480,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/104.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Freedom and Peace",
            Category = Category.Location.ToName(),
            Tags = new[] { "Depths of Mementos" },
            CueId = 102,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/105.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "The Whims of Fate",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 450,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/106.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Ark",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Palace.ToName() },
            CueId = 460,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/107.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Will Power",
            Category = Category.Story.ToName(),
            Tags = new[] { "Special Battles" },
            CueId = 335,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/108.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Jaldabaoth",
            Category = Category.Boss_Battle.ToName(),
            CueId = 333,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/109.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Our Beginning",
            Category = Category.Boss_Battle.ToName(),
            CueId = 334,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/110.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Triumph",
            Category = Category.Victory_Theme.ToName(),
            CueId = 340,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/111.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Keeper of Lust",
            Category = Category.Boss_Battle.ToName(),
            CueId = 330,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/112.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Talk",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { "Hold Up" },
            CueId = 341,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/113.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Blooming Villian",
            Category = Category.Boss_Battle.ToName(),
            CueId = 13,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/114.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Blooming Villian (Cut)",
            Category = Category.Boss_Battle.ToName(),
            CueId = 42,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/115.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Rivers in the Desert -instrumental version-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 332,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/116.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Rivers In the Desert",
            Category = Category.Boss_Battle.ToName(),
            CueId = 336,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/117.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Last Surprise",
            Category = Category.Normal_Battle.ToName(),
            Tags = new[] { Category.Context__Normal.ToName() },
            CueId = 300,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/118.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Hymn of the Soul",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Velvet_Room.ToName() },
            CueId = 500,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/119.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Tokyo Emergency",
            CueId = 1,
            Category = Category.Overworld.ToName(),
            Tags = new[] { "Mission Start" },
            ReplacementPath = "FEmulator/AWB/BGM.AWB/120.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Tokyo Daylight",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Sunny.ToName() },
            CueId = 610,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/121.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Beneath the Mask -instrumental version-",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Clear.ToName() },
            CueId = 600,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/122.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Beneath the Mask",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Clear.ToName(), Tag.Night.ToName() },
            CueId = 640,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/123.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Beneath the Mask -rain, instrumental version-",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Rainy.ToName() },
            CueId = 641,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/124.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Beneath the Mask -rain-",
            Category = Category.Overworld.ToName(),
            Tags = new[] { Tag.Rainy.ToName(), Tag.Night.ToName() },
            CueId = 642,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/125.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });

        this.Songs.Add(new()
        {
            Name = "Swear to My Bones (Cut)",
            Category = Category.Story.ToName(),
            CueId = 710,
            ReplacementPath = "FEmulator/AWB/BGM.AWB/126.adx",
            Encoder = "ADX (Persona 5 Royal PC)",
        });
    }
}
