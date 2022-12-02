using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SmokeXv2
{
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            await Task.Delay(1000);
            WebClient updatecheck = new WebClient();
            panel3.Width = 164;
            label2.Text = ("Checking For Update");
            await Task.Delay(1000);
            if (!updatecheck.DownloadString("https://raw.githubusercontent.com/Robloxsaw/SmokeXv2/main/PatchCheck").Contains("2.0"))
            {
                label2.Text = ("You Do Not Have Correct Version");
                MessageBox.Show("You Do Not Have Correct Version For Smoke X. Would You Like Join Our Disord Server?", "Myth");
                System.Diagnostics.Process.Start("https://discord.gg/YhRMQQb2");
                await Task.Delay(1000);
                Application.Exit();
            }
            else
            {
                panel3.Width = 328;
                label2.Text = ("Checking For Patch");
                await Task.Delay(1000);
                WebClient patchcheck = new WebClient();
                if (!updatecheck.DownloadString("https://raw.githubusercontent.com/Robloxsaw/SmokeXv2/main/UpdateCheck").Contains("notpatched"))
                {
                    MessageBox.Show("Smoke X v2 Is Patched Right Now. If You Would Like, You Can Join Our Discord Server For Latest/Announcements Updates.", "Myth");
                    System.Diagnostics.Process.Start("https://discord.gg/YhRMQQb2");

                }
                else
                {
                    panel3.Width = 492;
                    label2.Text = ("SmokeX Exploit ...");
                    await Task.Delay(1500);
                    panel3.Width = 656;
                    this.Hide();
                    MainUI mainui = new MainUI();
                    mainui.Show();
                }
            }
        }
    }
}
