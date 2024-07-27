﻿using System.Collections.Generic;

namespace FFXIV_DiscordPresence
{
    public static class Define
    {
        public enum LogType : byte
        {
            ChangeZone = 1,
            ChangePrimaryPlayer = 2,
            AddCombatant = 3,
            PartyList = 11,
            PlayerStats = 12,
        }

        public enum ClassJob : byte
        {
            Adventurer = 0,
            Gladiator = 1,
            Pugilist = 2,
            Marauder = 3,
            Lancer = 4,
            Archer = 5,
            Conjurer = 6,
            Thaumaturge = 7,
            Carpenter = 8,
            Blacksmith = 9,
            Armorer = 10,
            Goldsmith = 11,
            Leatherworker = 12,
            Weaver = 13,
            Alchemist = 14,
            Culinarian = 15,
            Miner = 16,
            Botanist = 17,
            Fisher = 18,
            Paladin = 19,
            Monk = 20,
            Warrior = 21,
            Dragoon = 22,
            Bard = 23,
            WhiteMage = 24,
            BlackMage = 25,
            Arcanist = 26,
            Summoner = 27,
            Scholar = 28,
            Rogue = 29,
            Ninja = 30,
            Machinist = 31,
            DarkKnight = 32,
            Astrologian = 33,
            Samurai = 34,
            RedMage = 35,
            BlueMage = 36,
            Gunbreaker = 37,
            Dancer = 38,
            Reaper = 39,
            Sage = 40,
            Viper = 41,
            Pictomancer = 42,
        }

        public static readonly Dictionary<ClassJob, string> Assets = new Dictionary<ClassJob, string>
        {
            { ClassJob.Gladiator, "gla" },
            { ClassJob.Pugilist, "pgl" },
            { ClassJob.Marauder, "mrd" },
            { ClassJob.Lancer, "lnc" },
            { ClassJob.Archer, "arc" },
            { ClassJob.Conjurer, "cnj" },
            { ClassJob.Thaumaturge, "thm" },
            { ClassJob.Carpenter, "crp" },
            { ClassJob.Blacksmith, "bsm" },
            { ClassJob.Armorer, "arm" },
            { ClassJob.Goldsmith, "gsm" },
            { ClassJob.Leatherworker, "ltw" },
            { ClassJob.Weaver, "wvr" },
            { ClassJob.Alchemist, "alc" },
            { ClassJob.Culinarian, "cul" },
            { ClassJob.Miner, "min" },
            { ClassJob.Botanist, "btn" },
            { ClassJob.Fisher, "fsh" },
            { ClassJob.Paladin, "pld" },
            { ClassJob.Monk, "mnk" },
            { ClassJob.Warrior, "war" },
            { ClassJob.Dragoon, "drg" },
            { ClassJob.Bard, "brd" },
            { ClassJob.WhiteMage, "whm" },
            { ClassJob.BlackMage, "blm" },
            { ClassJob.Arcanist, "acn" },
            { ClassJob.Summoner, "smn" },
            { ClassJob.Scholar, "sch" },
            { ClassJob.Rogue, "rog" },
            { ClassJob.Ninja, "nin" },
            { ClassJob.Machinist, "mch" },
            { ClassJob.DarkKnight, "drk" },
            { ClassJob.Astrologian, "ast" },
            { ClassJob.Samurai, "sam" },
            { ClassJob.RedMage, "rdm" },
            { ClassJob.BlueMage, "blu" },
            { ClassJob.Gunbreaker, "gnb" },
            { ClassJob.Dancer, "dnc" },
            { ClassJob.Reaper, "rpr" },
            { ClassJob.Sage, "sge" },
            { ClassJob.Viper, "vpr" },
            { ClassJob.Pictomancer, "pct" },
        };

        public static readonly Dictionary<ClassJob, string> DISPLAY_NAMES = new Dictionary<ClassJob, string>
        {
            { ClassJob.Gladiator, "Gladiator" },
            { ClassJob.Pugilist, "Pugilist" },
            { ClassJob.Marauder, "Marauder" },
            { ClassJob.Lancer, "Lancer" },
            { ClassJob.Archer, "Archer" },
            { ClassJob.Conjurer, "Conjurer" },
            { ClassJob.Thaumaturge, "Thaumaturge" },
            { ClassJob.Carpenter, "Carpenter" },
            { ClassJob.Blacksmith, "Blacksmith" },
            { ClassJob.Armorer, "Armorer" },
            { ClassJob.Goldsmith, "Goldsmith" },
            { ClassJob.Leatherworker, "Leatherworker" },
            { ClassJob.Weaver, "Weaver" },
            { ClassJob.Alchemist, "Alchemist" },
            { ClassJob.Culinarian, "Culinarian" },
            { ClassJob.Miner, "Miner" },
            { ClassJob.Botanist, "Botanist" },
            { ClassJob.Fisher, "Fisher" },
            { ClassJob.Paladin, "Paladin" },
            { ClassJob.Monk, "Monk" },
            { ClassJob.Warrior, "Warrior" },
            { ClassJob.Dragoon, "Dragoon" },
            { ClassJob.Bard, "Bard" },
            { ClassJob.WhiteMage, "White Mage" },
            { ClassJob.BlackMage, "Black Mage" },
            { ClassJob.Arcanist, "Arcanist" },
            { ClassJob.Summoner, "Summoner" },
            { ClassJob.Scholar, "Scholar" },
            { ClassJob.Rogue, "Rogue" },
            { ClassJob.Ninja, "Ninja" },
            { ClassJob.Machinist, "Machinist" },
            { ClassJob.DarkKnight, "DarkKnight" },
            { ClassJob.Astrologian, "Astrologian" },
            { ClassJob.Samurai, "Samurai" },
            { ClassJob.RedMage, "Red Mage" },
            { ClassJob.BlueMage, "Blue Mage" },
            { ClassJob.Gunbreaker, "Gunbreaker" },
            { ClassJob.Dancer, "Dancer" },
            { ClassJob.Reaper, "Reaper" },
            { ClassJob.Sage, "Sage" },
            { ClassJob.Viper, "Viper" },
            { ClassJob.Pictomancer, "Pictomancer" },
        };
    }
}
