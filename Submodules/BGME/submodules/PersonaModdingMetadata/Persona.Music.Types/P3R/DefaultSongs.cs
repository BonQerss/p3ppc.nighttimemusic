using Persona.Music.Types.Common;

namespace Persona.Music.Types.P3R;

public class DefaultSongs : GameMusic
{
    public DefaultSongs()
    {
        this.Game = PersonaModdingMetadata.Shared.Games.Game.P3R_PC;
        this.Version = 1;
        this.DefaultBaseReplacementPath = "Ryo/P3R";
        this.DefaultEncoder = "HCA (Persona 3 Reload)";

        this.Songs.Add(new()
        {
            Name = "tartarus_0d01",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "1st Block" },
            CueId = 1,
            ReplacementPath = "Ryo/P3R/link_01.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Shadow",
            Category = Category.Story.ToName(),
            CueId = 19,
            ReplacementPath = "Ryo/P3R/link_19.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Deep Breath, Deep Breath -Reload-",
            Category = Category.Story.ToName(),
            CueId = 20,
            ReplacementPath = "Ryo/P3R/link_20.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Basement",
            Category = Category.Story.ToName(),
            CueId = 21,
            ReplacementPath = "Ryo/P3R/link_21.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Deep Mentality -Reload-",
            Category = Category.Story.ToName(),
            CueId = 22,
            ReplacementPath = "Ryo/P3R/link_22.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "When The Moon's Reaching Out Stars",
            Category = Category.Overworld.ToName(),
            CueId = 25,
            ReplacementPath = "Ryo/P3R/link_25.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Mass Destruction -Reload-",
            Category = Category.Normal_Battle.ToName(),
            CueId = 26,
            ReplacementPath = "Ryo/P3R/link_26.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Master of Shadow -Reload- (Cue 27)",
            Category = Category.Boss_Battle.ToName(),
            CueId = 27,
            ReplacementPath = "Ryo/P3R/link_27.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Unavoidable Battle",
            Category = Category.Boss_Battle.ToName(),
            CueId = 28,
            ReplacementPath = "Ryo/P3R/link_28.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Burn My Dread -Last Battle Reload-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 29,
            ReplacementPath = "Ryo/P3R/link_29.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "The Battle For Everyone's Souls",
            Category = Category.Boss_Battle.ToName(),
            CueId = 30,
            ReplacementPath = "Ryo/P3R/link_30.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Master Of Tartarus -Reload-",
            Category = Category.Boss_Battle.ToName(),
            CueId = 31,
            ReplacementPath = "Ryo/P3R/link_31.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Kyoto",
            Category = Category.Location.ToName(),
            Tags = new[] { "Kyoto" },
            CueId = 32,
            ReplacementPath = "Ryo/P3R/link_32.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Troubled",
            Category = Category.Story.ToName(),
            CueId = 35,
            ReplacementPath = "Ryo/P3R/link_35.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "What Lies in the Darkness",
            Category = Category.Story.ToName(),
            CueId = 36,
            ReplacementPath = "Ryo/P3R/link_36.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Living With Determination",
            Category = Category.Story.ToName(),
            CueId = 37,
            ReplacementPath = "Ryo/P3R/link_37.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Story)",
            Category = Category.Story.ToName(),
            CueId = 38,
            ReplacementPath = "Ryo/P3R/link_38.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Fearful Experience",
            Category = Category.Story.ToName(),
            CueId = 39,
            ReplacementPath = "Ryo/P3R/link_39.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Calamity",
            Category = Category.Story.ToName(),
            CueId = 40,
            ReplacementPath = "Ryo/P3R/link_40.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of You",
            Category = Category.Story.ToName(),
            Tags = new[] { "Ending" },
            CueId = 42,
            ReplacementPath = "Ryo/P3R/link_42.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Joy (Social Links)",
            Category = Category.Story.ToName(),
            CueId = 43,
            ReplacementPath = "Ryo/P3R/link_43.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "This Mysterious Feeling",
            Category = Category.Story.ToName(),
            CueId = 44,
            ReplacementPath = "Ryo/P3R/link_44.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Crisis",
            Category = Category.Story.ToName(),
            CueId = 45,
            ReplacementPath = "Ryo/P3R/link_45.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "The Path Is Open",
            Category = Category.Story.ToName(),
            CueId = 46,
            ReplacementPath = "Ryo/P3R/link_46.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Want To Be Close",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "1st Semester" },
            CueId = 50,
            ReplacementPath = "Ryo/P3R/link_50.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Changing Seasons -Reload-",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "2nd Semester" },
            CueId = 51,
            ReplacementPath = "Ryo/P3R/link_51.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of The School (Another Version)",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.School.ToName(), "January" },
            CueId = 52,
            ReplacementPath = "Ryo/P3R/link_52.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Iwatodai Dorm -Reload-",
            Category = Category.Location.ToName(),
            Tags = new[] { "Iwatodai Dorm" },
            CueId = 53,
            ReplacementPath = "Ryo/P3R/link_53.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Aria of The Soul",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Velvet_Room.ToName() },
            CueId = 54,
            ReplacementPath = "Ryo/P3R/link_54.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Tanaka's Amazing Commodities -Reload-",
            Category = Category.Shop.ToName(),
            CueId = 55,
            ReplacementPath = "Ryo/P3R/link_55.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Paulownia Mall -Reload-",
            Category = Category.Shop.ToName(),
            CueId = 56,
            ReplacementPath = "Ryo/P3R/link_56.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "After The Battle",
            Category = Category.Victory_Theme.ToName(),
            CueId = 60,
            ReplacementPath = "Ryo/P3R/link_60.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "The Path Is Closed",
            Category = Category.Story.ToName(),
            CueId = 62,
            ReplacementPath = "Ryo/P3R/link_62.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d02",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "2nd Block" },
            CueId = 70,
            ReplacementPath = "Ryo/P3R/link_70.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "The Voice Someone Calls",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "Entrance" },
            CueId = 71,
            ReplacementPath = "Ryo/P3R/link_71.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d04",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "4th Block" },
            CueId = 72,
            ReplacementPath = "Ryo/P3R/link_72.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d05",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "5th Block" },
            CueId = 73,
            ReplacementPath = "Ryo/P3R/link_73.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d06 (Tartarus)",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "6th Block" },
            CueId = 74,
            ReplacementPath = "Ryo/P3R/link_74.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d06 (Story)",
            Category = Category.Story.ToName(),
            CueId = 75,
            ReplacementPath = "Ryo/P3R/link_75.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Living With Determination -Iwatodai Dorm Arrangement-",
            Category = Category.Location.ToName(),
            Tags = new[] { "Iwatodai Dorm" },
            CueId = 77,
            ReplacementPath = "Ryo/P3R/link_77.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "After The Battle (Again)",
            CueId = 78,
            ReplacementPath = "Ryo/P3R/link_78.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Mistic",
            Category = Category.Story.ToName(),
            CueId = 79,
            ReplacementPath = "Ryo/P3R/link_79.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Memories Of The City",
            Category = Category.Location.ToName(),
            Tags = new[] { "Port Island" },
            CueId = 80,
            ReplacementPath = "Ryo/P3R/link_80.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "tartarus_0d03",
            Category = Category.Location.ToName(),
            Tags = new[] { Tag.Tartarus.ToName(), "3rd Block" },
            CueId = 81,
            ReplacementPath = "Ryo/P3R/link_81.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Peace Reload",
            Category = Category.Story.ToName(),
            CueId = 85,
            ReplacementPath = "Ryo/P3R/link_85.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Strength of Heart",
            Category = Category.Story.ToName(),
            CueId = 86,
            ReplacementPath = "Ryo/P3R/link_86.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Everyone Loves 1989",
            Category = Category.Story.ToName(),
            CueId = 87,
            ReplacementPath = "Ryo/P3R/link_87.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "During The Exams",
            Category = Category.Daily_Life.ToName(),
            CueId = 89,
            ReplacementPath = "Ryo/P3R/link_89.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Bad Feeling",
            Category = Category.Story.ToName(),
            CueId = 90,
            ReplacementPath = "Ryo/P3R/link_90.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Afternoon Break",
            Category = Category.Daily_Life.ToName(),
            CueId = 91,
            ReplacementPath = "Ryo/P3R/link_91.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Aria of The Soul (Interlude)",
            CueId = 93,
            ReplacementPath = "Ryo/P3R/link_93.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "p3ct004_01",
            CueId = 94,
            ReplacementPath = "Ryo/P3R/link_94.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Color Your Night",
            CueId = 97,
            ReplacementPath = "Ryo/P3R/link_97.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I Will Protect You (Unused?)",
            CueId = 98,
            ReplacementPath = "Ryo/P3R/link_98.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Memories of You (Instrumental)",
            CueId = 99,
            ReplacementPath = "Ryo/P3R/link_99.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Nyx",
            CueId = 100,
            ReplacementPath = "Ryo/P3R/link_100.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I Will Protect You (Alternate)",
            CueId = 101,
            ReplacementPath = "Ryo/P3R/link_101.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Shadow (No Intro)",
            CueId = 102,
            ReplacementPath = "Ryo/P3R/link_102.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "It's Going Down Now",
            CueId = 128,
            ReplacementPath = "Ryo/P3R/link_128.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Master of Shadow -Reload- (Cue 129)",
            CueId = 129,
            ReplacementPath = "Ryo/P3R/link_129.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Abandoned Streets",
            CueId = 200,
            ReplacementPath = "Ryo/P3R/link_200.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "This is How It Should Be...",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_170_170_A.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Living With Determination (alternate)",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_200_070_A.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Unknown",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_190_190_A.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I Will Protect You -Reload-",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_220_040_A.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Victory (Again)",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_Result_04.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Victory",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_Result_02.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Period (Again)",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_Result_03.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Period",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_Result_01.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Blooming Villain",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_36.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Will Power",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_35.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I Believe",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_34",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Gentle Madman",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_33.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Kichijoji 199X",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_32.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Beneath The Mask",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_31.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Life Will Change",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_30.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "The Almighty",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_26.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself (Mitsuo)",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_25.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Long Way",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_24.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Heaven",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_23.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Junes Theme",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_22.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Shin Mitsuo Tensei",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_21.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Backside of The TV",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_20.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Throw Your Mask Away",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_10.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Yaldabaoth",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_09.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Rivers In The Desert",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_08.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Take Over",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_07.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Last Surprise",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_06.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Fog/Mist",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_05.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "A New World Fool",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_04.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "I'll Face Myself -Battle-",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_03.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Time To Make History",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_02.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Reach Out To The Truth",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_Sound_01.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Persona Invocation",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_100_285_A.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });

        this.Songs.Add(new()
        {
            Name = "Late Arrival",
            CueId = -1,
            ReplacementPath = "Ryo/P3R/link_100_050_B.hca",
            Encoder = "HCA (Persona 3 Reload)",
        });
    }
}
