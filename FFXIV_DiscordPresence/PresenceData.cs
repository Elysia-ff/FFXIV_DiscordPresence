﻿using DiscordRPC;
using System;

namespace FFXIV_DiscordPresence
{
    public class PresenceData
    {
        public uint PlayerCode;
        public string PlayerName = string.Empty;
        public string ServerName = string.Empty;
        public string ZoneName
        {
            get { return zoneName; }
            set { zoneName = value; unixStart = (ulong)DateTimeOffset.UtcNow.ToUnixTimeSeconds(); }
        }
        public int PartySize;
        public Define.ClassJob ClassJob;
        public uint PlayerLevel;

        private string zoneName = string.Empty;
        private ulong unixStart;

        public static readonly ulong StartUnixSeconds = (ulong)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        public static readonly string LargeImageKey = "yshtola_";
        public readonly int PartyMax = 8;

        private readonly string nameFormat = "{0} @ {1}";
        private readonly string jobFormat = "{0} - Lv.{1}";

        public RichPresence GetPresence()
        {
            RichPresence richPresence = new RichPresence();

            if (ZoneName.Length > 0)
            {
                richPresence.State = ZoneName;
            }

            if (PlayerName.Length > 0 && PlayerName.Length > 0)
            {
                richPresence.Details = string.Format(nameFormat, PlayerName, ServerName);
            }

            if (unixStart > 0)
            {
                richPresence.Timestamps = new Timestamps();
                richPresence.Timestamps.StartUnixMilliseconds = unixStart;
            }

            richPresence.Assets = new Assets();
            richPresence.Assets.LargeImageKey = LargeImageKey;

            if (Define.Assets.ContainsKey(ClassJob))
            {
                richPresence.Assets.SmallImageKey = Define.Assets[ClassJob];
                if (PlayerLevel > 0)
                {
                    richPresence.Assets.SmallImageText = string.Format(jobFormat, Define.DISPLAY_NAMES[ClassJob], PlayerLevel);
                }
                else
                {
                    richPresence.Assets.SmallImageText = Define.DISPLAY_NAMES[ClassJob];
                }
            }

            if (PlayerCode > 0)
            {
                richPresence.Party = new Party();
                richPresence.Party.ID = PlayerCode.ToString();
                richPresence.Party.Size = PartySize;
                richPresence.Party.Max = PartyMax;
            }

            return richPresence;
        }

        public static readonly RichPresence Default = new RichPresence()
        {
            Timestamps = new Timestamps()
            {
                StartUnixMilliseconds = StartUnixSeconds
            },

            Assets = new Assets()
            {
                LargeImageKey = LargeImageKey
            }
        };
    }
}
