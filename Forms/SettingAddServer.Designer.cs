
namespace CVL.Forms
{
    partial class SettingAddServer
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
            this.label_FriendlyName = new System.Windows.Forms.Label();
            this.textBox_FriendlyName = new System.Windows.Forms.TextBox();
            this.textBox_ServerAddress = new System.Windows.Forms.TextBox();
            this.label_serverAddress = new System.Windows.Forms.Label();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.lalbel_serverPort = new System.Windows.Forms.Label();
            this.button_AddServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_FriendlyName
            // 
            this.label_FriendlyName.AutoSize = true;
            this.label_FriendlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FriendlyName.Location = new System.Drawing.Point(11, 15);
            this.label_FriendlyName.Name = "label_FriendlyName";
            this.label_FriendlyName.Size = new System.Drawing.Size(99, 16);
            this.label_FriendlyName.TabIndex = 0;
            this.label_FriendlyName.Text = "Friendly Name:";
            // 
            // textBox_FriendlyName
            // 
            this.textBox_FriendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FriendlyName.Location = new System.Drawing.Point(116, 12);
            this.textBox_FriendlyName.MaxLength = 16;
            this.textBox_FriendlyName.Name = "textBox_FriendlyName";
            this.textBox_FriendlyName.Size = new System.Drawing.Size(318, 23);
            this.textBox_FriendlyName.TabIndex = 1;
            this.textBox_FriendlyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_FriendlyName_KeyDown);
            // 
            // textBox_ServerAddress
            // 
            this.textBox_ServerAddress.Location = new System.Drawing.Point(12, 63);
            this.textBox_ServerAddress.Name = "textBox_ServerAddress";
            this.textBox_ServerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_ServerAddress.Size = new System.Drawing.Size(285, 23);
            this.textBox_ServerAddress.TabIndex = 2;
            this.textBox_ServerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ServerAddress_KeyDown);
            // 
            // label_serverAddress
            // 
            this.label_serverAddress.Location = new System.Drawing.Point(12, 43);
            this.label_serverAddress.Name = "label_serverAddress";
            this.label_serverAddress.Size = new System.Drawing.Size(285, 17);
            this.label_serverAddress.TabIndex = 3;
            this.label_serverAddress.Text = "Server Address";
            this.label_serverAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ServerPort.Location = new System.Drawing.Point(303, 63);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(131, 23);
            this.textBox_ServerPort.TabIndex = 4;
            this.textBox_ServerPort.Text = "2456";
            this.textBox_ServerPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ServerPort_KeyDown);
            // 
            // lalbel_serverPort
            // 
            this.lalbel_serverPort.Location = new System.Drawing.Point(303, 43);
            this.lalbel_serverPort.Name = "lalbel_serverPort";
            this.lalbel_serverPort.Size = new System.Drawing.Size(131, 17);
            this.lalbel_serverPort.TabIndex = 5;
            this.lalbel_serverPort.Text = "Port";
            this.lalbel_serverPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AddServer
            // 
            this.button_AddServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddServer.Location = new System.Drawing.Point(12, 92);
            this.button_AddServer.Name = "button_AddServer";
            this.button_AddServer.Size = new System.Drawing.Size(422, 26);
            this.button_AddServer.TabIndex = 6;
            this.button_AddServer.Text = "Add Server";
            this.button_AddServer.UseVisualStyleBackColor = true;
            this.button_AddServer.Click += new System.EventHandler(this.button_AddServer_Click);
            // 
            // SettingAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 130);
            this.Controls.Add(this.button_AddServer);
            this.Controls.Add(this.lalbel_serverPort);
            this.Controls.Add(this.textBox_ServerPort);
            this.Controls.Add(this.label_serverAddress);
            this.Controls.Add(this.textBox_ServerAddress);
            this.Controls.Add(this.textBox_FriendlyName);
            this.Controls.Add(this.label_FriendlyName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingAddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FriendlyName;
        private System.Windows.Forms.TextBox textBox_FriendlyName;
        private System.Windows.Forms.TextBox textBox_ServerAddress;
        private System.Windows.Forms.Label label_serverAddress;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.Label lalbel_serverPort;
        private System.Windows.Forms.Button button_AddServer;
    }
}