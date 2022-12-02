using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SmokeXv2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        string SettingsPath = Environment.CurrentDirectory + @"\\bin\settings\";

        public bool EditSettings(string Name, string OriginalValue, string Value)
        {
            try
            {

                string FilePath = SettingsPath + Name;
                string Contents = File.ReadAllText(FilePath);

                if (Contents.Contains(OriginalValue))
                {
                    File.WriteAllText(FilePath, Contents.Replace(OriginalValue, Value));
                }
                else
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void TopMostCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMostCB.Checked)
            {
                MainUI.IsAutoInject = true;
                EditSettings("topmost", "false", "true");
            }
            else
            {
                MainUI.IsAutoInject = true;
                EditSettings("topmost", "true", "false");
            }
        }

        private void AutoInjectCB_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoInjectCB.Checked)
            {
                MainUI.IsAutoInject = true;
                EditSettings("autoattach", "false", "true");
            }
            else
            {
                MainUI.IsAutoInject = true;
                EditSettings("autoattach", "true", "false");
            }
        }

        private void FpsUnlockerCB_CheckedChanged(object sender, EventArgs e)
        {
            if (FpsUnlockerCB.Checked)
            {
                Process.Start(Environment.CurrentDirectory + @"\bin\tools\rbxfpsunlocker.exe");
            }
            else
            {
                foreach (Process Unlocker in Process.GetProcesses())
                {
                    if (Unlocker.ProcessName.Contain("fps") || Unlocker.MainWindowTitle.Contain("fps"))
                    {
                        Unlocker.Kill();
                    }
                }
            }
        }
    }
    }

