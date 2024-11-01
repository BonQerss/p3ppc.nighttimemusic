using p3ppc.nighttimemusic.Configuration;
using p3ppc.nighttimemusic.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using CriFs.V2.Hook;
using CriFs.V2.Hook.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using System.Reflection.Emit;
using static p3ppc.nighttimemusic.Utils;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Memory;
using System;
using System.Collections.Generic;
using System.Net;
using System.Diagnostics;


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

        private IAsmHook isFemcHook;
        private IAsmHook TimeofDayHook;
        private IAsmHook InjectionForFieldBgmHook;
        private IAsmHook InjectionForMapBgmHook;
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

        private IReverseWrapper<MapBGMDelegate> _newFuncReverseWrapper;

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

            Dictionary<int, string> ValidFields =
                       new Dictionary<int, string>();

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

            SigScan("48 89 5C 24 ?? 48 89 6C 24 ?? 56 57 41 56 48 83 EC 40 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 44 24 ?? 48 8B D9", "InjectionForMapBgm", address =>
            {
                string[] function =
                {
                    "use64",
                    "push rcx",
                    "sub rsp, 32",
                    $"{_hooks.Utilities.GetAbsoluteCallMnemonics(MapBGM, out _newFuncReverseWrapper)}",
                    "add rsp, 32",
                    "pop rcx"
                };

                // Assuming _hooks.CreateAsmHook is a valid method call
                InjectionForMapBgmHook = _hooks.CreateAsmHook(function, address + 741, AsmHookBehaviour.ExecuteAfter).Activate();
            });

            SigScan("40 57 48 83 EC 20 0F B7 F9 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 66 83 FF 7F 72 ?? 8B 15 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 83 C2 07 E8 ?? ?? ?? ?? 8B 0D ?? ?? ?? ?? 8B 15 ?? ?? ?? ?? 81 F2 B3 76 EB DB", "BGM Play", address =>
            {
                _BGMPlay = _hooks.CreateWrapper<PlayBGMDelegate>(address, out _);
            });

            SigScan("40 57 48 83 EC 20 0F B7 F9 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 66 83 FF 7F 72 ?? 8B 15 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 83 C2 07 E8 ?? ?? ?? ?? 8B 0D ?? ?? ?? ?? 8B 15 ?? ?? ?? ?? 81 F2 B3 76 EB DB", "BGM Play", address =>
            {
                _BGMPlay2 = _hooks.CreateWrapper<PlayBGM2Delegate>(address, out _);
            });

            // Hook for isFemc
            SigScan("48 83 EC 28 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 0F B6 05 ?? ?? ?? ?? C1 E8 07", "isFemc", address =>
            {
                _IsFemc = _hooks.CreateWrapper<IsFemcDelegate>(address, out _);
            });

            // Hook for TimeofDay
            SigScan("E8 ?? ?? ?? ?? 84 C0 74 ?? E8 ?? ?? ?? ?? 3C 06", "TimeofDay", address =>
            {
                var funcAddress = GetGlobalAddress((nuint)(address + 1));
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

            bool var5 = _IsFemc();
            int var6 = (int)_TimeofDay();

            if (var6 == 5)
            {
                if (fieldMajor == 8 && fieldMinor == 1)
                {
                    if (var5)
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
                        if (var5)
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
                    if (var5)
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
                return 1;
            }
            else
            {
                return _FieldBGMHook.OriginalFunction(fieldMajor, fieldMinor, tartarusFloor);
            }
        }

        private void MapBGM(TaskStruct* task)
        {

            bool var5 = _IsFemc();
            int var6 = (int)_TimeofDay();

            if (var6 == 5)
            {
                if (!var5)
                {
                    var taskHandle = _BGMPlay2(10913, 1);
                }
                else
                {
                    var taskHandle = _BGMPlay2(10912, 1);
                }
            }
            else
            {
                _MapBGMHook.OriginalFunction(task);
            }
        }

        #region For Exports, Serialization etc.
#pragma warning disable CS8618
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}