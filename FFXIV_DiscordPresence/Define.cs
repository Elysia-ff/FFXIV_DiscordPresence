using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Version = 253,
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
            Dancer = 38
        }

        public static Dictionary<ClassJob, string> Assets = new Dictionary<ClassJob, string>()
        {
            { ClassJob.Gladiator, "GLA" },
            { ClassJob.Pugilist, "PGL" },
            { ClassJob.Marauder, "MRD" },
            { ClassJob.Lancer, "LNC" },
            { ClassJob.Archer, "ARC" },
            { ClassJob.Conjurer, "CNJ" },
            { ClassJob.Thaumaturge, "THM" },
            { ClassJob.Carpenter, "CRP" },
            { ClassJob.Blacksmith, "BSM" },
            { ClassJob.Armorer, "ARM" },
            { ClassJob.Goldsmith, "GSM" },
            { ClassJob.Leatherworker, "LTW" },
            { ClassJob.Weaver, "WVR" },
            { ClassJob.Alchemist, "ALC" },
            { ClassJob.Culinarian, "CUL" },
            { ClassJob.Miner, "MIN" },
            { ClassJob.Botanist, "BTN" },
            { ClassJob.Fisher, "FSH" },
            { ClassJob.Paladin, "PLD" },
            { ClassJob.Monk, "MNK" },
            { ClassJob.Warrior, "WAR" },
            { ClassJob.Dragoon, "DRG" },
            { ClassJob.Bard, "BRD" },
            { ClassJob.WhiteMage, "WHM" },
            { ClassJob.BlackMage, "BLM" },
            { ClassJob.Arcanist, "ACN" },
            { ClassJob.Summoner, "SMN" },
            { ClassJob.Scholar, "SCH" },
            { ClassJob.Rogue, "ROG" },
            { ClassJob.Ninja, "NIN" },
            { ClassJob.Machinist, "MCH" },
            { ClassJob.DarkKnight, "DRK" },
            { ClassJob.Astrologian, "AST" },
            { ClassJob.Samurai, "SAM" },
            { ClassJob.RedMage, "RDM" },
            { ClassJob.BlueMage, "BLU" },
            { ClassJob.Gunbreaker, "GNB" },
            { ClassJob.Dancer, "DNC" }
        };
    }
}
