﻿namespace Orion.World {
    /// <summary>
    /// Specifies a wall's type.
    /// </summary>
    public enum WallType : byte {
#pragma warning disable 1591
        None = 0,
        Stone = 1,
        DirtUnsafe = 2,
        EbonstoneUnsafe = 3,
        Wood = 4,
        GrayBrick = 5,
        RedBrick = 6,
        BlueDungeonUnsafe = 7,
        GreenDungeonUnsafe = 8,
        PinkDungeonUnsafe = 9,
        GoldBrick = 10,
        SilverBrick = 11,
        CopperBrick = 12,
        HellstoneBrickUnsafe = 13,
        ObsidianBrickUnsafe = 14,
        MudUnsafe = 15,
        Dirt = 16,
        BlueDungeon = 17,
        GreenDungeon = 18,
        PinkDungeon = 19,
        ObsidianBrick = 20,
        Glass = 21,
        PearlstoneBrick = 22,
        IridescentBrick = 23,
        MudstoneBrick = 24,
        CobaltBrick = 25,
        MythrilBrick = 26,
        Planked = 27,
        PearlstoneBrickUnsafe = 28,
        CandyCane = 29,
        GreenCandyCane = 30,
        SnowBrick = 31,
        AdamantiteBeam = 32,
        DemoniteBrick = 33,
        SandstoneBrick = 34,
        EbonstoneBrick = 35,
        RedStucco = 36,
        YellowStucco = 37,
        GreenStucco = 38,
        Gray = 39,
        SnowWallUnsafe = 40,
        Ebonwood = 41,
        RichMaogany = 42,
        Pearlwood = 43,
        RainbowBrick = 44,
        TinBrick = 45,
        TungstenBrick = 46,
        PlatinumBrick = 47,
        AmethystUnsafe = 48,
        TopazUnsafe = 49,
        SapphireUnsafe = 50,
        EmeraldUnsafe = 51,
        RubyUnsafe = 52,
        DiamondUnsafe = 53,
        CaveUnsafe = 54,
        Cave2Unsafe = 55,
        Cave3Unsafe = 56,
        Cave4Unsafe = 57,
        Cave5Unsafe = 58,
        Cave6Unsafe = 59,
        LivingLeaf = 60,
        Cave7Unsafe = 61,
        SpiderUnsafe = 62,
        GrassUnsafe = 63,
        JungleUnsafe = 64,
        FlowerUnsafe = 65,
        Grass = 66,
        Jungle = 67,
        Flower = 68,
        CorruptGrassUnsafe = 69,
        HallowedGrassUnsafe = 70,
        IceUnsafe = 71,
        Cactus = 72,
        Cloud = 73,
        Mushroom = 74,
        Bone = 75,
        Slime = 76,
        Flesh = 77,
        LivingWood = 78,
        ObsidianBackUnsafe = 79,
        MushroomUnsafe = 80,
        CrimsonGrassUnsafe = 81,
        DiscWall = 82,
        CrimstoneUnsafe = 83,
        IceBrick = 84,
        Shadewood = 85,
        HiveUnsafe = 86,
        LihzahrdBrickUnsafe = 87,
        PurpleStainedGlass = 88,
        YellowStainedGlass = 89,
        BlueStainedGlass = 90,
        GreenStainedGlass = 91,
        RedStainedGlass = 92,
        RainbowStainedGlass = 93,
        BlueDungeonSlabUnsafe = 94,
        BlueDungeonTileUnsafe = 95,
        PinkDungeonSlabUnsafe = 96,
        PinkDungeonTileUnsafe = 97,
        GreenDungeonSlabUnsafe = 98,
        GreenDungeonTileUnsafe = 99,
        BlueDungeonSlab = 100,
        BlueDungeonTile = 101,
        PinkDungeonSlab = 102,
        PinkDungeonTile = 103,
        GreenDungeonSlab = 104,
        GreenDungeonTile = 105,
        WoodenFence = 106,
        MetalFence = 107,
        Hive = 108,
        PalladiumColumn = 109,
        BubblegumBlock = 110,
        TitanstoneBlock = 111,
        LihzahrdBrick = 112,
        Pumpkin = 113,
        Hay = 114,
        SpookyWood = 115,
        ChristmasTreeWallpaper = 116,
        OrnamentWallpaper = 117,
        CandyCaneWallpaper = 118,
        FestiveWallpaper = 119,
        StarsWallpaper = 120,
        SquigglesWallpaper = 121,
        SnowflakeWallpaper = 122,
        KrampusHornWallpaper = 123,
        BluegreenWallpaper = 124,
        GrinchFingerWallpaper = 125,
        FancyGrayWallpaper = 126,
        IceFloeWallpaper = 127,
        MusicWallpaper = 128,
        PurpleRainWallpaper = 129,
        RainbowWallpaper = 130,
        SparkleStoneWallpaper = 131,
        StarlitHeavenWallpaper = 132,
        BubbleWallpaper = 133,
        CopperPipeWallpaper = 134,
        DuckyWallpaper = 135,
        Waterfall = 136,
        Lavafall = 137,
        EbonwoodFence = 138,
        RichMahoganyFence = 139,
        PearlwoodFence = 140,
        ShadewoodFence = 141,
        WhiteDynasty = 142,
        BlueDynasty = 143,
        ArcaneRunes = 144,
        IronFence = 145,
        CopperPlating = 146,
        StoneSlab = 147,
        Sail = 148,
        BorealWood = 149,
        BorealWoodFence = 150,
        PalmWood = 151,
        PalmWoodFence = 152,
        AmberGemspark = 153,
        AmethystGemspark = 154,
        DiamondGemspark = 155,
        EmeraldGemspark = 156,
        AmberGemsparkOff = 157,
        AmethystGemsparkOff = 158,
        DiamondGemsparkOff = 159,
        EmeraldGemsparkOff = 160,
        RubyGemsparkOff = 161,
        SapphireGemsparkOff = 162,
        TopazGemsparkOff = 163,
        RubyGemspark = 164,
        SapphireGemspark = 165,
        TopazGemspark = 166,
        TinPlating = 167,
        Confetti = 168,
        ConfettiBlack = 169,
        CaveWall = 170,
        CaveWall2 = 171,
        Honeyfall = 172,
        ChlorophyteBrick = 173,
        CrimtaneBrick = 174,
        ShroomitePlating = 175,
        MartianConduit = 176,
        HellstoneBrick = 177,
        MarbleUnsafe = 178,
        MarbleBlock = 179,
        GraniteUnsafe = 180,
        GraniteBlock = 181,
        MeteoriteBrick = 182,
        Marble = 183,
        Granite = 184,
        Cave8Unsafe = 185,
        Crystal = 186,
        Sandstone = 187,
        CorruptionUnsafe1 = 188,
        CorruptionUnsafe2 = 189,
        CorruptionUnsafe3 = 190,
        CorruptionUnsafe4 = 191,
        CrimsonUnsafe1 = 192,
        CrimsonUnsafe2 = 193,
        CrimsonUnsafe3 = 194,
        CrimsonUnsafe4 = 195,
        DirtUnsafe1 = 196,
        DirtUnsafe2 = 197,
        DirtUnsafe3 = 198,
        DirtUnsafe4 = 199,
        HallowUnsafe1 = 200,
        HallowUnsafe2 = 201,
        HallowUnsafe3 = 202,
        HallowUnsafe4 = 203,
        JungleUnsafe1 = 204,
        JungleUnsafe2 = 205,
        JungleUnsafe3 = 206,
        JungleUnsafe4 = 207,
        LavaUnsafe1 = 208,
        LavaUnsafe2 = 209,
        LavaUnsafe3 = 210,
        LavaUnsafe4 = 211,
        RocksUnsafe1 = 212,
        RocksUnsafe2 = 213,
        RocksUnsafe3 = 214,
        RocksUnsafe4 = 215,
        HardenedSand = 216,
        CorruptHardenedSand = 217,
        CrimsonHardenedSand = 218,
        HallowHardenedSand = 219,
        CorruptSandstone = 220,
        CrimsonSandstone = 221,
        HallowSandstone = 222,
        DesertFossil = 223,
        LunarBrickWall = 224,
        CogWall = 225,
        SandFall = 226,
        SnowFall = 227,
        SillyBalloonPinkWall = 228,
        SillyBalloonPurpleWall = 229,
        SillyBalloonGreenWall = 230,
#pragma warning restore 1591
    }
}
