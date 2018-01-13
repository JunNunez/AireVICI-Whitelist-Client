namespace AireVICI_Whitelist_Client
{
    partial class frmAireVICI_whitelistClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAireVICI_whitelistClient));
            this.TimerWhitelist = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoftphone = new System.Windows.Forms.TextBox();
            this.txtBrowser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.openFileDialog_browser = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_softphone = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerWhitelist
            // 
            this.TimerWhitelist.Enabled = true;
            this.TimerWhitelist.Interval = 5000;
            this.TimerWhitelist.Tick += new System.EventHandler(this.TimerWhitelist_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Location = new System.Drawing.Point(13, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 234);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open Softphone";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Agent Interface";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.txtSoftphone);
            this.tabSettings.Controls.Add(this.txtBrowser);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.buttonSaveSettings);
            this.tabSettings.Controls.Add(this.txtPassword);
            this.tabSettings.Controls.Add(this.txtUsername);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(251, 208);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Softphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Browser";
            // 
            // txtSoftphone
            // 
            this.txtSoftphone.Location = new System.Drawing.Point(87, 117);
            this.txtSoftphone.Name = "txtSoftphone";
            this.txtSoftphone.Size = new System.Drawing.Size(142, 20);
            this.txtSoftphone.TabIndex = 14;
            this.txtSoftphone.Click += new System.EventHandler(this.txtSoftphone_Click);
            // 
            // txtBrowser
            // 
            this.txtBrowser.Location = new System.Drawing.Point(88, 85);
            this.txtBrowser.Name = "txtBrowser";
            this.txtBrowser.Size = new System.Drawing.Size(142, 20);
            this.txtBrowser.TabIndex = 13;
            this.txtBrowser.Click += new System.EventHandler(this.txtBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(86, 167);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 10;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Location = new System.Drawing.Point(88, 54);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(78, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(139, 45);
            this.pictureBox_logo.TabIndex = 10;
            this.pictureBox_logo.TabStop = false;
            // 
            // openFileDialog_browser
            // 
            this.openFileDialog_browser.Title = "Choose Browser";
            // 
            // openFileDialog_softphone
            // 
            this.openFileDialog_softphone.Title = "Choose Softphone";
            // 
            // frmAireVICI_whitelistClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAireVICI_whitelistClient";
            this.Text = "AireVICI Whitelist Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerWhitelist;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.OpenFileDialog openFileDialog_browser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoftphone;
        private System.Windows.Forms.TextBox txtBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog_softphone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

