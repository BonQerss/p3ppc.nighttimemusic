namespace Persona.Music.Types.Common;

public enum Category
{
    // Battles.
    Normal_Battle,
    Context__Normal,
    Context__Advantage,
    Context__Disadvantage,
    Victory_Theme,
    Boss_Battle,

    // Common.
    Title_Screen,
    Story,
    Shop,
    Location,
    Ending,
    Unknown,

    // Daily life.
    Daily_Life,

    // Overworld.
    Overworld,
}

public enum Tag
{
    Main_Menu,

    // P3P.
    FEMC,

    // Weather types.
    Clear,
    Sunny,
    Cloudy,
    Foggy,
    Night,
    Snow,
    Rainy,

    // Locations.
    School,
    Velvet_Room,

    // Persona 4.
    Dojima_Residence,
    Midnight_Channel,

    // Persona 5.
    Palace,

    // Persona 3.
    Tartarus,
}

public static class CategoriesExtenions
{
    public static string ToName(this Category category)
        => category.ToString().Replace("__", ": ").Replace('_', ' ');
    public static string ToName(this Tag category)
        => category.ToString().Replace("__", ": ").Replace('_', ' ');
}