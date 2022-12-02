
namespace SmokeXv2
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.AutoInjectCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TopMostCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.FpsUnlockerCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // AutoInjectCB
            // 
            this.AutoInjectCB.AutoSize = true;
            this.AutoInjectCB.CheckedState.BorderColor = System.Drawing.Color.White;
            this.AutoInjectCB.CheckedState.BorderRadius = 0;
            this.AutoInjectCB.CheckedState.BorderThickness = 0;
            this.AutoInjectCB.CheckedState.FillColor = System.Drawing.Color.White;
            this.AutoInjectCB.CheckMarkColor = System.Drawing.Color.Green;
            this.AutoInjectCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.AutoInjectCB.Location = new System.Drawing.Point(12, 59);
            this.AutoInjectCB.Name = "AutoInjectCB";
            this.AutoInjectCB.Size = new System.Drawing.Size(193, 41);
            this.AutoInjectCB.TabIndex = 0;
            this.AutoInjectCB.Text = "Auto Inject";
            this.AutoInjectCB.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.AutoInjectCB.UncheckedState.BorderRadius = 0;
            this.AutoInjectCB.UncheckedState.BorderThickness = 0;
            this.AutoInjectCB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.AutoInjectCB.CheckedChanged += new System.EventHandler(this.AutoInjectCB_CheckedChanged);
            // 
            // TopMostCB
            // 
            this.TopMostCB.AutoSize = true;
            this.TopMostCB.CheckedState.BorderColor = System.Drawing.Color.White;
            this.TopMostCB.CheckedState.BorderRadius = 0;
            this.TopMostCB.CheckedState.BorderThickness = 0;
            this.TopMostCB.CheckedState.FillColor = System.Drawing.Color.White;
            this.TopMostCB.CheckMarkColor = System.Drawing.Color.Green;
            this.TopMostCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.TopMostCB.Location = new System.Drawing.Point(12, 12);
            this.TopMostCB.Name = "TopMostCB";
            this.TopMostCB.Size = new System.Drawing.Size(175, 41);
            this.TopMostCB.TabIndex = 1;
            this.TopMostCB.Text = "Top Most";
            this.TopMostCB.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.TopMostCB.UncheckedState.BorderRadius = 0;
            this.TopMostCB.UncheckedState.BorderThickness = 0;
            this.TopMostCB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.TopMostCB.CheckedChanged += new System.EventHandler(this.TopMostCB_CheckedChanged);
            // 
            // FpsUnlockerCB
            // 
            this.FpsUnlockerCB.AutoSize = true;
            this.FpsUnlockerCB.CheckedState.BorderColor = System.Drawing.Color.White;
            this.FpsUnlockerCB.CheckedState.BorderRadius = 0;
            this.FpsUnlockerCB.CheckedState.BorderThickness = 0;
            this.FpsUnlockerCB.CheckedState.FillColor = System.Drawing.Color.White;
            this.FpsUnlockerCB.CheckMarkColor = System.Drawing.Color.Green;
            this.FpsUnlockerCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.FpsUnlockerCB.Location = new System.Drawing.Point(12, 106);
            this.FpsUnlockerCB.Name = "FpsUnlockerCB";
            this.FpsUnlockerCB.Size = new System.Drawing.Size(221, 41);
            this.FpsUnlockerCB.TabIndex = 2;
            this.FpsUnlockerCB.Text = "Fps Unlocker";
            this.FpsUnlockerCB.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.FpsUnlockerCB.UncheckedState.BorderRadius = 0;
            this.FpsUnlockerCB.UncheckedState.BorderThickness = 0;
            this.FpsUnlockerCB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.FpsUnlockerCB.CheckedChanged += new System.EventHandler(this.FpsUnlockerCB_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(261, 158);
            this.Controls.Add(this.FpsUnlockerCB);
            this.Controls.Add(this.TopMostCB);
            this.Controls.Add(this.AutoInjectCB);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox AutoInjectCB;
        private Guna.UI2.WinForms.Guna2CheckBox TopMostCB;
        private Guna.UI2.WinForms.Guna2CheckBox FpsUnlockerCB;
    }
}