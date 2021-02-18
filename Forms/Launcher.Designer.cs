
namespace CVL.Forms
{
    partial class Launcher
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
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.comboBox_LaunchTo = new System.Windows.Forms.ComboBox();
            this.textBoxLog = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelWorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWorkArea.BackColor = System.Drawing.Color.Transparent;
            this.panelWorkArea.Controls.Add(this.comboBox_LaunchTo);
            this.panelWorkArea.Controls.Add(this.textBoxLog);
            this.panelWorkArea.Controls.Add(this.btnLaunch);
            this.panelWorkArea.Location = new System.Drawing.Point(0, 170);
            this.panelWorkArea.Margin = new System.Windows.Forms.Padding(0);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(348, 328);
            this.panelWorkArea.TabIndex = 0;
            // 
            // comboBox_LaunchTo
            // 
            this.comboBox_LaunchTo.BackColor = System.Drawing.Color.Black;
            this.comboBox_LaunchTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LaunchTo.DropDownWidth = 340;
            this.comboBox_LaunchTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_LaunchTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBox_LaunchTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox_LaunchTo.FormattingEnabled = true;
            this.comboBox_LaunchTo.ItemHeight = 29;
            this.comboBox_LaunchTo.Items.AddRange(new object[] {
            "Single Player"});
            this.comboBox_LaunchTo.Location = new System.Drawing.Point(3, 288);
            this.comboBox_LaunchTo.Name = "comboBox_LaunchTo";
            this.comboBox_LaunchTo.Size = new System.Drawing.Size(20, 37);
            this.comboBox_LaunchTo.TabIndex = 3;
            this.comboBox_LaunchTo.SelectedIndexChanged += new System.EventHandler(this.comboBox_LaunchTo_SelectedIndexChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxLog.ForeColor = System.Drawing.Color.Silver;
            this.textBoxLog.Location = new System.Drawing.Point(12, 0);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(336, 258);
            this.textBoxLog.TabIndex = 2;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.Enabled = false;
            this.btnLaunch.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLaunch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLaunch.Location = new System.Drawing.Point(23, 288);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(320, 37);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch Valheim - Solo";
            this.btnLaunch.Click += new System.EventHandler(Program.LaunchValheim);
            this.btnLaunch.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::CVL.Properties.Resources.icon_settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(300, 9);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::CVL.Properties.Resources.icon_close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(320, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CVL.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(348, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.panelWorkArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(Program.LauncherFormLoaded);
            this.panelWorkArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label textBoxLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBox_LaunchTo;
    }
}

