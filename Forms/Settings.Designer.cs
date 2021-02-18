
namespace CVL.Forms
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
            this.components = new System.ComponentModel.Container();
            this.label_ValheimInstallDirectory = new System.Windows.Forms.Label();
            this.textBox_ValheimInstallDirectory = new System.Windows.Forms.TextBox();
            this.fbd_ValheimInstallDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.button_ValheimInstallDirectory = new System.Windows.Forms.Button();
            this.label_BackupDirectory = new System.Windows.Forms.Label();
            this.textBox_BackupDirectory = new System.Windows.Forms.TextBox();
            this.button_BackupDirectory = new System.Windows.Forms.Button();
            this.fbd_BackupDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox_BackupEnabled = new System.Windows.Forms.CheckBox();
            this.panel_BackupEnabled = new System.Windows.Forms.Panel();
            this.label_DedicatedServers = new System.Windows.Forms.Label();
            this.button_DedicatedServerAdd = new System.Windows.Forms.Button();
            this.dgv_DedicatedServers = new System.Windows.Forms.DataGridView();
            this.clm_FriendlyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ServerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_BackupEnabled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DedicatedServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ValheimInstallDirectory
            // 
            this.label_ValheimInstallDirectory.AutoSize = true;
            this.label_ValheimInstallDirectory.Location = new System.Drawing.Point(16, 11);
            this.label_ValheimInstallDirectory.Name = "label_ValheimInstallDirectory";
            this.label_ValheimInstallDirectory.Size = new System.Drawing.Size(163, 17);
            this.label_ValheimInstallDirectory.TabIndex = 0;
            this.label_ValheimInstallDirectory.Text = "Valheim Install Directory:";
            // 
            // textBox_ValheimInstallDirectory
            // 
            this.textBox_ValheimInstallDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ValheimInstallDirectory.Enabled = false;
            this.textBox_ValheimInstallDirectory.Location = new System.Drawing.Point(12, 31);
            this.textBox_ValheimInstallDirectory.Name = "textBox_ValheimInstallDirectory";
            this.textBox_ValheimInstallDirectory.ReadOnly = true;
            this.textBox_ValheimInstallDirectory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_ValheimInstallDirectory.Size = new System.Drawing.Size(326, 23);
            this.textBox_ValheimInstallDirectory.TabIndex = 1;
            // 
            // fbd_ValheimInstallDirectory
            // 
            this.fbd_ValheimInstallDirectory.Description = "Select the folder that contains your Valheim installation";
            this.fbd_ValheimInstallDirectory.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbd_ValheimInstallDirectory.ShowNewFolderButton = false;
            // 
            // button_ValheimInstallDirectory
            // 
            this.button_ValheimInstallDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ValheimInstallDirectory.Location = new System.Drawing.Point(344, 31);
            this.button_ValheimInstallDirectory.Name = "button_ValheimInstallDirectory";
            this.button_ValheimInstallDirectory.Size = new System.Drawing.Size(29, 23);
            this.button_ValheimInstallDirectory.TabIndex = 2;
            this.button_ValheimInstallDirectory.Text = "...";
            this.button_ValheimInstallDirectory.UseVisualStyleBackColor = true;
            this.button_ValheimInstallDirectory.Click += new System.EventHandler(this.button_ValheimInstallDirectory_Click);
            // 
            // label_BackupDirectory
            // 
            this.label_BackupDirectory.AutoSize = true;
            this.label_BackupDirectory.Location = new System.Drawing.Point(16, 57);
            this.label_BackupDirectory.Name = "label_BackupDirectory";
            this.label_BackupDirectory.Size = new System.Drawing.Size(120, 17);
            this.label_BackupDirectory.TabIndex = 3;
            this.label_BackupDirectory.Text = "Backup Directory:";
            // 
            // textBox_BackupDirectory
            // 
            this.textBox_BackupDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BackupDirectory.Enabled = false;
            this.textBox_BackupDirectory.Location = new System.Drawing.Point(12, 77);
            this.textBox_BackupDirectory.Name = "textBox_BackupDirectory";
            this.textBox_BackupDirectory.ReadOnly = true;
            this.textBox_BackupDirectory.Size = new System.Drawing.Size(326, 23);
            this.textBox_BackupDirectory.TabIndex = 4;
            // 
            // button_BackupDirectory
            // 
            this.button_BackupDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BackupDirectory.Location = new System.Drawing.Point(344, 77);
            this.button_BackupDirectory.Name = "button_BackupDirectory";
            this.button_BackupDirectory.Size = new System.Drawing.Size(29, 23);
            this.button_BackupDirectory.TabIndex = 5;
            this.button_BackupDirectory.Text = "...";
            this.button_BackupDirectory.UseVisualStyleBackColor = true;
            this.button_BackupDirectory.Click += new System.EventHandler(this.button_BackupDirectory_Click);
            // 
            // fbd_BackupDirectory
            // 
            this.fbd_BackupDirectory.Description = "Select the folder where you would like CVL to store Valheim backups";
            this.fbd_BackupDirectory.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // checkBox_BackupEnabled
            // 
            this.checkBox_BackupEnabled.AutoSize = true;
            this.checkBox_BackupEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BackupEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_BackupEnabled.Location = new System.Drawing.Point(0, 0);
            this.checkBox_BackupEnabled.Name = "checkBox_BackupEnabled";
            this.checkBox_BackupEnabled.Size = new System.Drawing.Size(361, 37);
            this.checkBox_BackupEnabled.TabIndex = 6;
            this.checkBox_BackupEnabled.Text = "Backups Enabled";
            this.checkBox_BackupEnabled.UseVisualStyleBackColor = true;
            this.checkBox_BackupEnabled.CheckedChanged += new System.EventHandler(this.checkBox_BackupEnabled_CheckedChanged);
            // 
            // panel_BackupEnabled
            // 
            this.panel_BackupEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_BackupEnabled.Controls.Add(this.checkBox_BackupEnabled);
            this.panel_BackupEnabled.Location = new System.Drawing.Point(12, 106);
            this.panel_BackupEnabled.Name = "panel_BackupEnabled";
            this.panel_BackupEnabled.Size = new System.Drawing.Size(361, 37);
            this.panel_BackupEnabled.TabIndex = 7;
            // 
            // label_DedicatedServers
            // 
            this.label_DedicatedServers.AutoSize = true;
            this.label_DedicatedServers.Location = new System.Drawing.Point(16, 146);
            this.label_DedicatedServers.Name = "label_DedicatedServers";
            this.label_DedicatedServers.Size = new System.Drawing.Size(129, 17);
            this.label_DedicatedServers.TabIndex = 8;
            this.label_DedicatedServers.Text = "Dedicated Servers:";
            // 
            // button_DedicatedServerAdd
            // 
            this.button_DedicatedServerAdd.Location = new System.Drawing.Point(12, 166);
            this.button_DedicatedServerAdd.Name = "button_DedicatedServerAdd";
            this.button_DedicatedServerAdd.Size = new System.Drawing.Size(361, 26);
            this.button_DedicatedServerAdd.TabIndex = 10;
            this.button_DedicatedServerAdd.Text = "Add Server";
            this.button_DedicatedServerAdd.UseVisualStyleBackColor = true;
            this.button_DedicatedServerAdd.Click += new System.EventHandler(this.button_DedicatedServerAdd_Click);
            // 
            // dgv_DedicatedServers
            // 
            this.dgv_DedicatedServers.AllowUserToAddRows = false;
            this.dgv_DedicatedServers.AllowUserToResizeRows = false;
            this.dgv_DedicatedServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DedicatedServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DedicatedServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_FriendlyName,
            this.clm_ServerAddress,
            this.clm_ServerPort});
            this.dgv_DedicatedServers.Location = new System.Drawing.Point(12, 198);
            this.dgv_DedicatedServers.Name = "dgv_DedicatedServers";
            this.dgv_DedicatedServers.Size = new System.Drawing.Size(361, 276);
            this.dgv_DedicatedServers.TabIndex = 13;
            this.dgv_DedicatedServers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DedicatedServers_CellEndEdit);
            this.dgv_DedicatedServers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_DedicatedServers_RowsAdded);
            this.dgv_DedicatedServers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_DedicatedServers_RowsRemoved);
            // 
            // clm_FriendlyName
            // 
            this.clm_FriendlyName.FillWeight = 160F;
            this.clm_FriendlyName.HeaderText = "Friendly Name";
            this.clm_FriendlyName.Name = "clm_FriendlyName";
            // 
            // clm_ServerAddress
            // 
            this.clm_ServerAddress.FillWeight = 80F;
            this.clm_ServerAddress.HeaderText = "Server Address";
            this.clm_ServerAddress.Name = "clm_ServerAddress";
            // 
            // clm_ServerPort
            // 
            this.clm_ServerPort.FillWeight = 77.04839F;
            this.clm_ServerPort.HeaderText = "Port";
            this.clm_ServerPort.MinimumWidth = 10;
            this.clm_ServerPort.Name = "clm_ServerPort";
            // 
            // settingsManagerBindingSource
            // 
            this.settingsManagerBindingSource.DataSource = typeof(CVL.Subsystem.SettingsManager);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 486);
            this.Controls.Add(this.button_DedicatedServerAdd);
            this.Controls.Add(this.dgv_DedicatedServers);
            this.Controls.Add(this.label_DedicatedServers);
            this.Controls.Add(this.panel_BackupEnabled);
            this.Controls.Add(this.button_BackupDirectory);
            this.Controls.Add(this.textBox_BackupDirectory);
            this.Controls.Add(this.label_BackupDirectory);
            this.Controls.Add(this.button_ValheimInstallDirectory);
            this.Controls.Add(this.textBox_ValheimInstallDirectory);
            this.Controls.Add(this.label_ValheimInstallDirectory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Valheim Launcher Settings";
            this.TopMost = true;
            this.panel_BackupEnabled.ResumeLayout(false);
            this.panel_BackupEnabled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DedicatedServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ValheimInstallDirectory;
        private System.Windows.Forms.TextBox textBox_ValheimInstallDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbd_ValheimInstallDirectory;
        private System.Windows.Forms.Button button_ValheimInstallDirectory;
        private System.Windows.Forms.Label label_BackupDirectory;
        private System.Windows.Forms.TextBox textBox_BackupDirectory;
        private System.Windows.Forms.Button button_BackupDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbd_BackupDirectory;
        private System.Windows.Forms.CheckBox checkBox_BackupEnabled;
        private System.Windows.Forms.Panel panel_BackupEnabled;
        private System.Windows.Forms.Label label_DedicatedServers;
        private System.Windows.Forms.BindingSource settingsManagerBindingSource;
        private System.Windows.Forms.Button button_DedicatedServerAdd;
        private System.Windows.Forms.DataGridView dgv_DedicatedServers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_FriendlyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ServerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ServerPort;
    }
}