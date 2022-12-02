using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokeXv2
{
    public partial class ScriptHub : Form
    {
        WeAreDevs_API.ExploitAPI API = new WeAreDevs_API.ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://github.com/TERIHAX/Scripts/raw/main/OwlHub.lua'))()");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/RandomAdamYT/DarkHub/master/Init'))()");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:GetObjects('rbxassetid://418957341')[1].Source)()");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://github.com/TERIHAX/Scripts/raw/main/DarkDexV3.lua'))()");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://github.com/TERIHAX/Scripts/raw/main/ZyrexHub.lua'))()");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/NGHDDDX/ScriptHubScripts/master/CocoHub.txt'))()");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://github.com/TERIHAX/Scripts/raw/main/CMD-X.lua'))()");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("loadstring(game:HttpGet('https://github.com/TERIHAX/Scripts/raw/main/RemoteSpy.lua'))()");
        }
    }
}
