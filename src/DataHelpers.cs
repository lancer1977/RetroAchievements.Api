namespace PolyhydraGames.RetroAchievements;

public static class DataHelpers
{
    public static string ConsoleIdToName(long value)
    {
        return value switch
        {
            1 => "Sega Genesis",
            2 => "Nintendo 64",
            3 => "Super Nintendo Entertainment System",
            4 => "Nintendo Game Boy",
            5 => "Nintendo Game Boy Advance",
            6 => "Nintendo Game Boy Color",
            7 => "Nintendo Entertainment System",
            8 => "NEC TurboGrafx-16",
            9 => "Sega CD",
            10 => "Sega 32X",
            11 => "Sega Master System",
            12 => "Sony Playstation",
            13 => "Atari Lynx",
            14 => "SNK Neo Geo Pocket",
            15 => "Sega Game Gear",
            16 => "Nintendo GameCube",
            17 => "Atari Jaguar",
            18 => "Nintendo DS",
            19 => "Nintendo Wii",
            20 => "Nintendo Wii U",
            21 => "Sony Playstation 2",
            22 => "Microsoft Xbox",
            23 => "Magnavox Odyssey 2",
            24 => "Nintendo Pokemon Mini",
            25 => "Atari 2600",
            26 => "MS-DOS",
            27 => "Arcade",
            28 => "Nintendo Virtual Boy",
            29 => "Microsoft MSX",
            30 => "Commodore 64",
            31 => "Spectrum ZX81",
            32 => "Tangerine Oric",
            33 => "Sega SG-1000",
            37 => "Amstrad CPC",
            38 => "Apple II",
            39 => "Sega Saturn",
            40 => "Sega Dreamcast",
            41 => "Sony PSP",
            43 => "3DO Interactive Multiplayer",
            44 => "ColecoVision",
            45 => "Mattel Intellivision",
            46 => "GCE Vectrex",
            47 => "PC-8000/8800",
            49 => "NEC PC-FX",
            51 => "Atari 7800",
            53 => "WonderSwan",
            57 => "Fairchild Channel F",
            63 => "Watara Supervision",
            69 => "Mega Duck",
            71 => "Arduboy",
            72 => "WASM-4",
            76 => "NEC TurboGrafx-CD",
            _ => ""
        };
    }
}

