﻿// Copyright (c) 2020 Pryaxis & Orion Contributors
// 
// This file is part of Orion.
// 
// Orion is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Orion is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Orion.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Orion.Buffs {
    /// <summary>
    /// Specifies a buff ID.
    /// </summary>
    public enum BuffId : ushort {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        None = 0,
        ObsidianSkin = 1,
        Regeneration = 2,
        Swiftness = 3,
        Gills = 4,
        Ironskin = 5,
        ManaRegeneration = 6,
        MagicPower = 7,
        Featherfall = 8,
        Spelunker = 9,
        Invisibility = 10,
        Shine = 11,
        NightOwl = 12,
        Battle = 13,
        Thorns = 14,
        WaterWalking = 15,
        Archery = 16,
        Hunter = 17,
        Gravitation = 18,
        ShadowOrb = 19,
        Poisoned = 20,
        PotionSickness = 21,
        Darkness = 22,
        Cursed = 23,
        OnFire = 24,
        Tipsy = 25,
        WellFed = 26,
        Fairy = 27,
        Werewolf = 28,
        Clairvoyance = 29,
        Bleeding = 30,
        Confused = 31,
        Slow = 32,
        Weak = 33,
        Merfolk = 34,
        Silenced = 35,
        BrokenArmor = 36,
        Horrified = 37,
        TheTongue = 38,
        CursedInferno = 39,
        PetBunny = 40,
        BabyPenguin = 41,
        PetTurtle = 42,
        PaladinsShield = 43,
        Frostburn = 44,
        BabyEater = 45,
        Chilled = 46,
        Frozen = 47,
        Honey = 48,
        Pygmies = 49,
        BabySkeletronHead = 50,
        BabyHornet = 51,
        TikiSpirit = 52,
        PetLizard = 53,
        PetParrot = 54,
        BabyTruffle = 55,
        PetSapling = 56,
        Wisp = 57,
        RapidHealing = 58,
        HolyProtection = 59,
        LeafCrystal = 60,
        BabyDinosaur = 61,
        IceBarrier = 62,
        Panic = 63,
        BabySlime = 64,
        EyeballSpring = 65,
        BabySnowman = 66,
        Burning = 67,
        Suffocation = 68,
        Ichor = 69,
        Venom = 70,
        WeaponImbueVenom = 71,
        Midas = 72,
        WeaponImbueCursedFlames = 73,
        WeaponImbueFire = 74,
        WeaponImbueGold = 75,
        WeaponImbueIchor = 76,
        WeaponImbueNanites = 77,
        WeaponImbueConfetti = 78,
        WeaponImbuePoison = 79,
        Blackout = 80,
        PetSpider = 81,
        Squashling = 82,
        Ravens = 83,
        BlackCat = 84,
        CursedSapling = 85,
        WaterCandle = 86,
        CozyFire = 87,
        ChaosState = 88,
        HeartLamp = 89,
        Rudolph = 90,
        Puppy = 91,
        BabyGrinch = 92,
        AmmoBox = 93,
        ManaSickness = 94,
        BeetleEndurance = 95,
        BeetleEndurance2 = 96,
        BeetleEndurance3 = 97,
        BeetleMight = 98,
        BeetleMight2 = 99,
        BeetleMight3 = 100,
        RedFairy = 101,
        GreenFairy = 102,
        Wet = 103,
        Mining = 104,
        Heartreach = 105,
        Calm = 106,
        Builder = 107,
        Titan = 108,
        Flipper = 109,
        Summoning = 110,
        Dangersense = 111,
        AmmoReservation = 112,
        Lifeforce = 113,
        Endurance = 114,
        Rage = 115,
        Inferno = 116,
        Wrath = 117,
        MinecartLeft = 118,
        Lovestruck = 119,
        Stinky = 120,
        Fishing = 121,
        Sonar = 122,
        Crate = 123,
        Warmth = 124,
        Hornet = 125,
        Imp = 126,
        ZephyrFish = 127,
        BunnyMount = 128,
        PigronMount = 129,
        SlimeMount = 130,
        TurtleMount = 131,
        BeeMount = 132,
        Spider = 133,
        Twins = 134,
        Pirate = 135,
        MiniMinotaur = 136,
        Slime = 137,
        MinecartRight = 138,
        Sharknado = 139,
        UFO = 140,
        UFOMount = 141,
        DrillMount = 142,
        ScutlixMount = 143,
        Electrified = 144,
        MoonBite = 145,
        Happy = 146,
        Banner = 147,
        FeralBite = 148,
        Webbed = 149,
        Bewitched = 150,
        LifeDrain = 151,
        MagicLantern = 152,
        Shadowflame = 153,
        BabyFaceMonster = 154,
        CrimsonHeart = 155,
        Stoned = 156,
        PeaceCandle = 157,
        StarinaBottle = 158,
        Sharpened = 159,
        Dazed = 160,
        DeadlySphere = 161,
        UnicornMount = 162,
        Obstructed = 163,
        Distorted = 164,
        DryadsBlessing = 165,
        MechanicalMinecartRight = 166,
        MechanicalMinecartLeft = 167,
        CuteFishronMount = 168,
        Penetrated = 169,
        SolarBlaze = 170,
        SolarBlaze2 = 171,
        SolarBlaze3 = 172,
        LifeNebula = 173,
        LifeNebula2 = 174,
        LifeNebula3 = 175,
        ManaNebula = 176,
        ManaNebula2 = 177,
        ManaNebula3 = 178,
        DamageNebula = 179,
        DamageNebula2 = 180,
        DamageNebula3 = 181,
        StardustCell = 182,
        Celled = 183,
        WoodenMinecartRight = 184,
        WoodenMinecartLeft = 185,
        DryadsBane = 186,
        StardustGuardian = 187,
        StardustDragon = 188,
        Daybroken = 189,
        SuspiciousLookingEye = 190,
        CompanionCube = 191,
        SugarRush = 192,
        BasiliskMount = 193,
        MightyWind = 194,
        WitheredArmor = 195,
        WitheredWeapon = 196,
        Oozed = 197,
        StrikingMoment = 198,
        CreativeShock = 199,
        PropellerGato = 200,
        Flickerwick = 201,
        Hoardagron = 202,
        BetsysCurse = 203,
        Oiled = 204,
        BallistaPanic = 205,
        PlentySatisfied = 206,
        ExquisitelyStuffed = 207,
        DesertMinecartRight = 208,
        DesertMinecartLeft = 209,
        MinecarpRight = 210,
        MinecarpLeft = 211,
        GolfCart = 212,
        SanguineBat = 213,
        VampireFrog = 214,
        TheBastDefense = 215,
        BabyFinch = 216,
        Estee = 217,
        SugarGlider = 218,
        SharkPup = 219,
        BeeMinecartRight = 220,
        BeeMinecartLeft = 221,
        LadybugMinecartRight = 222,
        LadybugMinecartLeft = 223,
        PigronMinecartRight = 224,
        PigronMinecartLeft = 225,
        SunflowerMinecartRight = 226,
        SunflowerMinecartLeft = 227,
        DemonicHellcartRight = 228,
        DemonicHellcartLeft = 229,
        WitchsBroom = 230,
        ShroomMinecartRight = 231,
        ShroomMinecartLeft = 232,
        AmethystMinecartRight = 233,
        AmethystMinecartLeft  = 234,
        TopazMinecartRight = 235,
        TopazMinecartLeft  = 236,
        SapphireMinecartRight = 237,
        SapphireMinecartLeft  = 238,
        EmeraldMinecartRight = 239,
        EmeraldMinecartLeft  = 240,
        RubyMinecartRight = 241,
        RubyMinecartLeft  = 242,
        DiamondMinecartRight = 243,
        DiamondMinecartLeft  = 244,
        AmberMinecartRight = 245,
        AmberMinecartLeft  = 246,
        BeetleMinecartRight = 247,
        BeetleMinecartLeft  = 248,
        MeowmereMinecartRight = 249,
        MeowmereMinecartLeft  = 250,
        PartyMinecartRight = 251,
        PartyMinecartLeft  = 252,
        TheDutchmanRight = 253,
        TheDutchmanLeft  = 254,
        SteampunkMinecartRight = 255,
        SteampunkMinecartLeft  = 256,
        Lucky = 257,
        LilHarpy = 258,
        FennecFox = 259,
        GlitteryButterfly = 260,
        BabyImp = 261,
        BabyRedPanda = 262,
        DesertTiger = 263,
        Plantero = 264,
        Flamingo = 265,
        DynamiteKitten = 266,
        BabyWerewolf = 267,
        ShadowMimic = 268,
        CoffinMinecartRight = 269,
        CoffinMinecartLeft  = 270,
        EnchantedDaggers = 271,
        DiggingMolecartRight = 272,
        DiggingMolecartLeft  = 273,
        VoltBunny = 274,
        PaintedHorseMount = 275,
        MajesticHorseMount = 276,
        DarkHorseMount = 277,
        PogoStickMount = 278,
        PirateShipMount = 279,
        TreeMount = 280,
        SantankMount = 281,
        GoatMount = 282,
        BookMount = 283,
        SlimePrince = 284,
        SuspiciousEye = 285,
        EaterofWorms = 286,
        SpiderBrain = 287,
        SkeletronJr = 288,
        HoneyBee = 289,
        DestroyerLite = 290,
        RezandSpaz = 291,
        MiniPrime = 292,
        PlanteraSeedling = 293,
        ToyGolem = 294,
        TinyFishron = 295,
        PhantasmalDragon = 296,
        Moonling = 297,
        FairyPrincess = 298,
        JackOLantern = 299,
        EverscreamSapling = 300,
        IceQueen = 301,
        AlienSkater = 302,
        BabyOgre = 303,
        ItsyBetsy = 304,
        LavaSharkMount = 305,
        TitaniumBarrier = 306,
        LeatherWhipTag = 307,
        DurendalsBlessing = 308,
        DurendalTag = 309,
        DarkHarvestTag = 310,
        HarvestTime = 311,
        ANiceBuff = 312,
        FirecrackerTag = 313,
        JunglesFury = 314,
        SnapthornTag = 315,
        KaleidoscopeTag = 316,
        SlimePrincess = 317,
        WingedSlimeMount = 318,
        MorningStarTag = 319,
        SparkleSlime = 320,
        CerebralMindtrick = 321,
        Terraprisma = 322,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }

    /// <summary>
    /// Provides extensions for the <see cref="BuffId"/> enumeration.
    /// </summary>
    public static class BuffIdExtensions {
        private static readonly ISet<BuffId> _debuffs = new HashSet<BuffId> {
            BuffId.Poisoned,
            BuffId.PotionSickness,
            BuffId.Darkness,
            BuffId.Cursed,
            BuffId.OnFire,
            BuffId.Tipsy,
            BuffId.Werewolf,
            BuffId.Bleeding,
            BuffId.Confused,
            BuffId.Slow,
            BuffId.Weak,
            BuffId.Merfolk,
            BuffId.Silenced,
            BuffId.BrokenArmor,
            BuffId.Horrified,
            BuffId.TheTongue,
            BuffId.CursedInferno,
            BuffId.Frostburn,
            BuffId.Chilled,
            BuffId.Frozen,
            BuffId.Burning,
            BuffId.Suffocation,
            BuffId.Ichor,
            BuffId.Venom,
            BuffId.Blackout,
            BuffId.WaterCandle,
            BuffId.CozyFire,
            BuffId.ChaosState,
            BuffId.HeartLamp,
            BuffId.ManaSickness,
            BuffId.Wet,
            BuffId.Lovestruck,
            BuffId.Stinky,
            BuffId.Slime,
            BuffId.Electrified,
            BuffId.MoonBite,
            BuffId.Happy,
            BuffId.Banner,
            BuffId.FeralBite,
            BuffId.Webbed,
            BuffId.Stoned,
            BuffId.PeaceCandle,
            BuffId.StarinaBottle,
            BuffId.Dazed,
            BuffId.Obstructed,
            BuffId.Distorted,
            BuffId.MightyWind,
            BuffId.WitheredArmor,
            BuffId.WitheredWeapon,
            BuffId.Oozed,
            BuffId.CreativeShock,
            BuffId.TheBastDefense,
            BuffId.SparkleSlime,
            BuffId.CerebralMindtrick,
        };

        /// <summary>
        /// Returns a value indicating whether the buff <paramref name="id"/> is a debuff.
        /// </summary>
        /// <param name="id">The buff ID.</param>
        /// <returns>
        /// <see langword="true"/> if the buff <paramref name="id"/> is a debuff; otherwise, <see langword="false"/>.
        /// </returns>
        [Pure]
        public static bool IsDebuff(this BuffId id) => _debuffs.Contains(id);
    }
}