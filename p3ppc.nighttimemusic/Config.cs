using System.ComponentModel;
using p3ppc.nighttimemusic.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace p3ppc.nighttimemusic.Configuration
{
    public class Config : Configurable<Config>
    {
        /*
            User Properties:
                - Please put all of your configurable properties here.
    
            By default, configuration saves as "Config.json" in mod user config folder.    
            Need more config files/classes? See Configuration.cs
    
            Available Attributes:
            - Category
            - DisplayName
            - Description
            - DefaultValue

            // Technically Supported but not Useful
            - Browsable
            - Localizable

            The `DefaultValue` attribute is used as part of the `Reset` button in Reloaded-Launcher.
        */

        public enum NightMusic
        {
            Time,
            TimeVocals,
            MidnightReverie,
            NightWanderer,
            ColorYourNight,
        }

        [DisplayName("Night Music")]
        [Description("Choose which music to play outside at night.\n\nTime: Plays 'Time (Night Version)' by MOSQ_ at night.\nTimeVocals: Plays 'Time (Night Version) (Vocals)' by MOSQ_ at night.\nMidnightReverie: Plays 'Midnight Reverie' by MineFormer at night.\nNightWanderer: Plays 'Night Wanderer' by MOSQ_ at night.\nColor Your Night: Plays 'Color Your Night' from P3R at night.")]
        [DefaultValue(true)]
        public NightMusic MusicSelection { get; set; } = NightMusic.Time;
        //public bool Time { get; set; } = true; // bool used in Mod.CS, not the folder name, but the bool name

    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
