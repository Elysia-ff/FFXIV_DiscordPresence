using System;
using System.Diagnostics;
using DiscordRPC;
using DiscordRPC.Logging;

namespace FFXIV_DiscordPresence
{
    public class Discord : IDisposable
    {
        private static Discord instance = null;
        public static Discord Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Discord();
                }

                return instance;
            }
        }

        private DiscordRpcClient client;
        //private System.Timers.Timer timer;

        public Discord()
        {
            InitializeDiscord();
        }

        public void Dispose()
        {
            //timer.Stop();
            //timer.Dispose();
            client.Dispose();

            instance = null;
        }

        private void InitializeDiscord()
        {
            client = new DiscordRpcClient("535459312915578910")
            {
                Logger = new ConsoleLogger()
                {
#if DEBUG
                    Level = LogLevel.Warning
#else
                    Level = LogLevel.None
#endif
                }
            };

#if DEBUG
            client.OnReady += (sender, e) =>
            {
                Debug.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Debug.WriteLine("Received Update! {0}", e.Presence);
            };
#endif

            client.Initialize();

            //timer = new System.Timers.Timer(150);
            //timer.Elapsed += (sender, e) =>
            //{
            //    client.Invoke();
            //    // UpdatePresence();
            //};
            //timer.Start();
        }

        public void UpdatePresence(RichPresence richPresence)
        {
            client.SetPresence(richPresence);
        }
    }
}
