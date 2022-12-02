using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using ArchAPI;

namespace SmokeXv2
{
    public partial class MainUI : Form
    {
        WeAreDevs_API.ExploitAPI API = new WeAreDevs_API.ExploitAPI();
        public static bool IsAutoInject = true;
        public static bool IsAutoAttach = false;

       ExploitAPI module = new ExploitAPI();
        
        public MainUI()
        {
            
            InitializeComponent();
        }
        string SettingsPath = Environment.CurrentDirectory + @"\\bin\settings\";
        private bool isTopMost;

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }
        public async void CheckingSettings()
        {
            while (true)
            {
                await Task.Delay(4000);
                if (isTopMost||File.ReadAllText(SettingsPath + "topmost").Contain("true"))
                {
                    TopMost = true;
                }
                else
                {
                    TopMost = false;
                }
            }
        }


        private void AddTabButton_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            FastColoredTextBoxNS.FastColoredTextBox textBox = new FastColoredTextBoxNS.FastColoredTextBox();
            newTab.Name = "Script" + (visualStudioTabControl1.TabCount + 1);
            newTab.Text = "New Tab  ";
            newTab.Parent = visualStudioTabControl1;
            textBox.Dock = DockStyle.Fill;
            textBox.Name = "fastColoredTextBox1";
            textBox.Parent = newTab;
            visualStudioTabControl1.SelectTab(newTab);
            AddTabButton.Left = AddTabButton.Left + 75;
            RemoveButton.Left = RemoveButton.Left + 77;
            if (visualStudioTabControl1.TabCount == 7)
            {
                AddTabButton.Hide();
            }
            if (visualStudioTabControl1.TabCount > 1)
            {
                RemoveTabButton.Show();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (visualStudioTabControl1.TabCount > 1)
            {
                Control tabPageToRemove = visualStudioTabControl1.Controls["Script" + (visualStudioTabControl1.TabCount)];
                visualStudioTabControl1.SelectTab("Script" + (visualStudioTabControl1.TabCount - 1));
                visualStudioTabControl1.Controls.Remove(tabPageToRemove);
                AddTabButton.Left = AddTabButton.Left - 75;
                RemoveButton.Left = RemoveButton.Left - 77;
                if (visualStudioTabControl1.TabCount == 7)
                {
                    AddTabButton.Hide();
                }
                else
                {
                    AddTabButton.Show();
                }
                if (visualStudioTabControl1.TabCount == 1)
                {
                    RemoveTabButton.Hide();
                }
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ScriptHub scriptHub = new ScriptHub();
            scriptHub.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }
    }
}
