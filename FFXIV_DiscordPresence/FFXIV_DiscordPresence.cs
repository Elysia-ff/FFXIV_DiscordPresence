using System;
using System.Globalization;
using System.Windows.Forms;
using Advanced_Combat_Tracker;

namespace FFXIV_DiscordPresence
{
    public partial class FFXIV_DiscordPresence : UserControl, IActPluginV1
    {
        private Label lblStatus;
        private PresenceData presenceData = new PresenceData();

        public FFXIV_DiscordPresence()
        {
            InitializeComponent();
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            pluginScreenSpace.Controls.Add(this);
            Dock = DockStyle.Fill;
            lblStatus = pluginStatusText;
            lblStatus.Text = "PlugIn Started";

            ActGlobals.oFormActMain.BeforeLogLineRead -= OnBeforeLogRead;
            ActGlobals.oFormActMain.BeforeLogLineRead += OnBeforeLogRead;

            Discord.Instance.UpdatePresence(PresenceData.Default);

            System.Timers.Timer timer = new System.Timers.Timer(6000);
            timer.Elapsed += delegate
            {
                timer.Close();
                Initailize();
            };
            timer.Start();
        }

        private void Initailize()
        {
            if (presenceData.PlayerCode > 0)
                return;

            Invoke(() =>
            {
                IActPluginV1 o = null;
                foreach (var x in ActGlobals.oFormActMain.ActPlugins)
                {
                    if (x.pluginFile.Name.ToUpper() == "FFXIV_ACT_Plugin.dll".ToUpper() && x.cbEnabled.Checked)
                    {
                        o = x.pluginObj;
                        if (o != null)
                        {
                            try
                            {
                                var pluginType = o.GetType();

                                o.DeInitPlugin();
                                x.pluginObj = o = null;
                                System.Threading.Thread.Sleep(500);
                                x.tpPluginSpace.Controls.Clear();
                                System.Threading.Thread.Sleep(500);

                                IActPluginV1 main = (IActPluginV1)Activator.CreateInstance(pluginType);

                                main.InitPlugin(x.tpPluginSpace, x.lblPluginStatus);
                                x.pluginObj = o = main;
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                }
            });
        }

        public static void Invoke(Action action)
        {
            if (ActGlobals.oFormActMain != null &&
                ActGlobals.oFormActMain.IsHandleCreated &&
                !ActGlobals.oFormActMain.IsDisposed)
            {
                if (ActGlobals.oFormActMain.InvokeRequired)
                {
                    ActGlobals.oFormActMain.Invoke((MethodInvoker)delegate
                    {
                        action();
                    });
                }
                else
                {
                    action();
                }
            }
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.BeforeLogLineRead -= OnBeforeLogRead;
            Discord.Instance.Dispose();

            lblStatus.Text = "No Status";
        }

        private void OnBeforeLogRead(bool isImport, LogLineEventArgs logInfo)
        {
            string[] log = logInfo.logLine.Split('|');
            if (log.Length < 0)
                return;

            if (byte.TryParse(log[0], out byte logType))
            {
                switch ((Define.LogType)logType)
                {
                    case Define.LogType.ChangeZone:
                    {
                        string zoneName = log[3];
                        if (!presenceData.ZoneName.Equals(zoneName))
                        {
                            presenceData.ZoneName = log[3];
                            Discord.Instance.UpdatePresence(presenceData.GetPresence());
                        }

                        break;
                    }
                    case Define.LogType.ChangePrimaryPlayer:
                    {
                        presenceData.PlayerCode = uint.Parse(log[2], NumberStyles.HexNumber);
                        presenceData.PlayerName = log[3];
                        Discord.Instance.UpdatePresence(presenceData.GetPresence());

                        break;
                    }
                    case Define.LogType.AddCombatant:
                    {
                        uint playerCode = uint.Parse(log[2], NumberStyles.HexNumber);
                        if (playerCode == presenceData.PlayerCode)
                        {
                            presenceData.PlayerLevel = uint.Parse(log[5], NumberStyles.HexNumber);
                            if (int.TryParse(log[8], out int r))
                                presenceData.ServerName = log[10];
                            else
                                presenceData.ServerName = log[8];
                           
                            Discord.Instance.UpdatePresence(presenceData.GetPresence());
                        }

                        break;
                    }
                    case Define.LogType.PartyList:
                    {
                        presenceData.PartySize = int.Parse(log[2]);
                        Discord.Instance.UpdatePresence(presenceData.GetPresence());

                        break;
                    }
                    case Define.LogType.PlayerStats:
                    {
                        presenceData.ClassJob = (Define.ClassJob)byte.Parse(log[2]);
                        Discord.Instance.UpdatePresence(presenceData.GetPresence());

                        break;
                    }
                }
            }
        }
    }
}
