using p3ppc.nighttimemusic.Configuration;
using p3ppc.nighttimemusic.Template;
using Reloaded.Mod.Interfaces;
using CriFs.V2.Hook.Interfaces;
using static p3ppc.nighttimemusic.Utils;
using Reloaded.Hooks.Definitions;
using Reloaded.Memory;
using Reloaded.Memory.Interfaces;


namespace p3ppc.nighttimemusic
{
    public unsafe class Mod : ModBase
    {

        private delegate nuint FieldBGMDelegate(int fieldMajor, int fieldMinor, int tartarusFloor);

        private delegate void MapBGMDelegate(TaskStruct* task);

        private delegate nuint PlayBGM2Delegate(int BGMid, int param2);

        private delegate nuint PlayBGMDelegate(int BGMid);

        private delegate nuint TimeOFDayDelegate();

        private delegate bool IsFemcDelegate();

        private delegate nuint NewFuncDelegate();

        private readonly IModLoader _modLoader;
        private readonly Reloaded.Hooks.Definitions.IReloadedHooks? _hooks;
        private readonly ILogger _logger;
        private readonly IMod _owner;
        private Config _configuration;
        private readonly IModConfig _modConfig;
        private int* isFemc;
        private int* TimeofDay;

        private IHook<FieldBGMDelegate> _FieldBGMHook;

        private IHook<MapBGMDelegate> _MapBGMHook;
        private PlayBGMDelegate _BGMPlay;

        private PlayBGM2Delegate _BGMPlay2;

        private IsFemcDelegate _IsFemc;

        private TimeOFDayDelegate _TimeofDay;

  

        private struct TaskStruct
        {
        }

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;
            Utils.Initialise(_logger, _configuration, _modLoader);

            var memory = Memory.Instance;


            isFemc = (int*)memory.Allocate(4).Address;
            TimeofDay = (int*)memory.Allocate(4).Address;

            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);
            var criFsController = _modLoader.GetController<ICriFsRedirectorApi>();
            if (criFsController == null || !criFsController.TryGetTarget(out var criFsApi))
            {
                _logger.WriteLine("Something in CriFS broke! Normal files will not load properly!", System.Drawing.Color.Red);
                return;
            }

            

            if (_configuration.MusicSelection == Config.NightMusic.MidnightReverie)
                criFsApi.AddProbingPath(Path.Combine(modDir, "Midnight Reverie", "P5REssentials", "CPK"));

            if (_configuration.MusicSelection == Config.NightMusic.Time)
                criFsApi.AddProbingPath(Path.Combine(modDir, "Time", "P5REssentials", "CPK"));

            if (_configuration.MusicSelection == Config.NightMusic.NightWanderer)
                criFsApi.AddProbingPath(Path.Combine(modDir, "Night Wanderer", "P5REssentials", "CPK"));

            if (_configuration.MusicSelection == Config.NightMusic.TimeVocals)
                criFsApi.AddProbingPath(Path.Combine(modDir, "Time (Vocals)", "P5REssentials", "CPK"));

            if (_configuration.MusicSelection == Config.NightMusic.ColorYourNight)
                criFsApi.AddProbingPath(Path.Combine(modDir, "Color Your Night", "P5REssentials", "CPK"));


            SigScan("48 89 5C 24 ?? 48 89 74 24 ?? 57 48 83 EC 20 8B D9 41 8B F0 48 8D 0D ?? ?? ?? ?? 8B FA E8 ?? ?? ?? ?? 85 F6", "Field BGM", address =>
            {
                _FieldBGMHook = _hooks.CreateHook<FieldBGMDelegate>(FieldBGM, address).Activate();
            });

            SigScan("E8 ?? ?? ?? ?? B8 0B 00 00 00 66 89 43 ?? E9 ?? ?? ?? ??", "Fix Map Screen BGM", address =>
            {
                memory.SafeWrite((nuint)address, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                // Nopes out the PlayBGM function call in the LMap function, which recreates the functionality in P3R where the currently playing song continues in the map screen.
            });

            SigScan("E9 ?? ?? ?? ?? 81 FB 91 01 00 00", "BGM Play", address =>
            {
                var funcAddress = GetGlobalAddress((nuint)(address + 1)); 
                // SigScan scans for when the PlayBGM function is called, not the function itself, then we use GetGlobalAddress to get the address of the function from that
                _BGMPlay = _hooks.CreateWrapper<PlayBGMDelegate>((long)funcAddress, out _);
            });

            SigScan("E9 ?? ?? ?? ?? 81 FB 91 01 00 00", "BGM Play2", address =>
            {
                var funcAddress = GetGlobalAddress((nuint)(address + 1)); // Same here
                // Legit no idea why I have two BGM Plays, I think they're needed? No idea, don't judge.....
                _BGMPlay2 = _hooks.CreateWrapper<PlayBGM2Delegate>((long)funcAddress, out _);
            });

            // Hook for isFemc
            SigScan("48 83 EC 28 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 0F B6 05 ?? ?? ?? ?? C1 E8 07", "isFemc", address =>
            {
                _IsFemc = _hooks.CreateWrapper<IsFemcDelegate>(address, out _);
            });

            // Hook for TimeofDay
            SigScan("E8 ?? ?? ?? ?? 84 C0 74 ?? E8 ?? ?? ?? ?? 3C 06", "TimeofDay", address =>
            {
                var funcAddress = GetGlobalAddress((nuint)(address + 1)); // And here
                _TimeofDay = _hooks.CreateWrapper<TimeOFDayDelegate>((long)funcAddress, out _);

            });


        }

        public override void ConfigurationUpdated(Config configuration)
        {
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }


        private nuint FieldBGM(int fieldMajor, int fieldMinor, int tartarusFloor)
        {
            int FieldBGM = 0;

            bool GenderCheck = _IsFemc();
            int Time = (int)_TimeofDay();

            if (Time == 5)
            {
                if (fieldMajor == 8 && fieldMinor == 1)
                {
                    if (GenderCheck)
                    {
                        FieldBGM = 10912;
                    }
                    else
                    {
                        FieldBGM = 10913;
                    }

                }
                else if (fieldMajor == 9)
                {
                    if (fieldMinor == 1 || fieldMinor == 2 || fieldMinor == 8)
                    {
                        if (GenderCheck)
                        {
                            FieldBGM = 10912;
                        }
                        else
                        {
                            FieldBGM = 10913;
                        }
                    }
                }
                else if (fieldMajor == 7 && fieldMinor == 9)  // Dorm
                {
                    if (GenderCheck)
                    {
                        FieldBGM = 10912;
                    }
                    else
                    {
                        FieldBGM = 10913;
                    }
                }
            }

            if (FieldBGM > 0)
            {
                var taskHandle = _BGMPlay2(FieldBGM, 1);

                if (_configuration.MusicSelection == Config.NightMusic.MidnightReverie)
                {
                    _logger.WriteLine("[Night Time Music] Activating Funky Jams, playing Midnight Reverie by MineFormer.", System.Drawing.Color.MediumSeaGreen);
                }

                if (_configuration.MusicSelection == Config.NightMusic.Time)
                {
                    _logger.WriteLine("[Night Time Music] Activating Funky Jams, playing Time by MOSQ_.", System.Drawing.Color.MediumSeaGreen);
                }

                if (_configuration.MusicSelection == Config.NightMusic.NightWanderer)
                {
                    _logger.WriteLine("[Night Time Music] Funky Jams, playing Night Wanderer by MineFormer.", System.Drawing.Color.MediumSeaGreen);
                }

                if (_configuration.MusicSelection == Config.NightMusic.TimeVocals)
                {
                    _logger.WriteLine("[Night Time Music] Activating Funky Jams, playing Time (Vocals) by MOSQ_.", System.Drawing.Color.MediumSeaGreen);
                }

                if (_configuration.MusicSelection == Config.NightMusic.ColorYourNight)
                {
                    _logger.WriteLine("[Night Time Music] Activating Funky Jams, playing Color Your Night by the Atlus Sound Team.", System.Drawing.Color.MediumSeaGreen);
                }

                return 1;
            }
            else
            {
                return _FieldBGMHook.OriginalFunction(fieldMajor, fieldMinor, tartarusFloor);
            }
        }


        #region For Exports, Serialization etc.
#pragma warning disable CS8618
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}