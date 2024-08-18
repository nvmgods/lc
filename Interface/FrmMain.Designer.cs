using System;
using System.Windows.Forms;
namespace RavenDevLauncher.Interface
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.StatusLable = new System.Windows.Forms.Label();
            this.percentLable = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.FullCheckButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.SpeedLable = new System.Windows.Forms.Label();
            this.TotalProgBar = new System.Windows.Forms.PictureBox();
            this.TotalLable = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.websitebtn = new System.Windows.Forms.Button();
            this.facebookbtn = new System.Windows.Forms.Button();
            this.discordbtn = new System.Windows.Forms.Button();
            this.noticeBoxLabel = new System.Windows.Forms.Label();
            this.AccretiaOnline = new System.Windows.Forms.Label();
            this.BellatoOnline = new System.Windows.Forms.Label();
            this.CoraOnline = new System.Windows.Forms.Label();
            this.bannerBox = new System.Windows.Forms.PictureBox();
            this.CurrentProgBar = new System.Windows.Forms.PictureBox();
            this.InfoBoxLabel = new System.Windows.Forms.Label();
            this.serverinfobtn = new System.Windows.Forms.Button();
            this.boxinfobtn = new System.Windows.Forms.Button();
            this.questinfobtn = new System.Windows.Forms.Button();
            this.combineinfobtn = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.server_list = new System.Windows.Forms.ListView();
            this.server_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLable
            // 
            resources.ApplyResources(this.StatusLable, "StatusLable");
            this.StatusLable.BackColor = System.Drawing.Color.Transparent;
            this.StatusLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusLable.Name = "StatusLable";
            // 
            // percentLable
            // 
            resources.ApplyResources(this.percentLable, "percentLable");
            this.percentLable.BackColor = System.Drawing.Color.Transparent;
            this.percentLable.ForeColor = System.Drawing.SystemColors.Control;
            this.percentLable.Name = "percentLable";
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_cancel1;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Name = "StopButton";
            this.StopButton.UseVisualStyleBackColor = false;
            
            this.StopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseEnter);
            this.StopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // FullCheckButton
            // 
            this.FullCheckButton.BackColor = System.Drawing.Color.Transparent;
            this.FullCheckButton.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_fix_client1;
            this.FullCheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.FullCheckButton, "FullCheckButton");
            this.FullCheckButton.Name = "FullCheckButton";
            this.FullCheckButton.UseVisualStyleBackColor = false;
            
            this.FullCheckButton.MouseEnter += new System.EventHandler(this.FullCheckButton_MouseEnter);
            this.FullCheckButton.MouseLeave += new System.EventHandler(this.FullCheckButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_close1;
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // SpeedLable
            // 
            resources.ApplyResources(this.SpeedLable, "SpeedLable");
            this.SpeedLable.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedLable.Name = "SpeedLable";
            // 
            // TotalProgBar
            // 
            this.TotalProgBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.TotalProgBar, "TotalProgBar");
            this.TotalProgBar.Name = "TotalProgBar";
            this.TotalProgBar.TabStop = false;
            // 
            // TotalLable
            // 
            resources.ApplyResources(this.TotalLable, "TotalLable");
            this.TotalLable.BackColor = System.Drawing.Color.Transparent;
            this.TotalLable.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalLable.Name = "TotalLable";
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startGameBtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_login1;
            resources.ApplyResources(this.startGameBtn, "startGameBtn");
            this.startGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            this.startGameBtn.MouseEnter += new System.EventHandler(this.startGameBtn_MouseEnter);
            this.startGameBtn.MouseLeave += new System.EventHandler(this.startGameBtn_MouseLeave);
            // 
            // minimizeBox
            // 
            this.minimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBox.BackgroundImage = global::RavenDevLauncher.Properties.Resources.minimize;
            resources.ApplyResources(this.minimizeBox, "minimizeBox");
            this.minimizeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.PictureBox1_Click);
            this.minimizeBox.MouseEnter += new System.EventHandler(this.minimizeBox_MouseEnter);
            this.minimizeBox.MouseLeave += new System.EventHandler(this.minimizeBox_MouseLeave);
            // 
            // txtboxUsername
            // 
            resources.ApplyResources(this.txtboxUsername, "txtboxUsername");
            this.txtboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPassword.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtboxPassword, "txtboxPassword");
            this.txtboxPassword.Name = "txtboxPassword";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_setup;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Transparent;
            this.registerbtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_join1;
            resources.ApplyResources(this.registerbtn, "registerbtn");
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            this.registerbtn.MouseEnter += new System.EventHandler(this.registerbtn_MouseEnter);
            this.registerbtn.MouseLeave += new System.EventHandler(this.registerbtn_MouseLeave);
            // 
            // websitebtn
            // 
            this.websitebtn.BackColor = System.Drawing.Color.Transparent;
            this.websitebtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_gameguide;
            this.websitebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.websitebtn, "websitebtn");
            this.websitebtn.Name = "websitebtn";
            this.websitebtn.UseVisualStyleBackColor = false;
            this.websitebtn.Click += new System.EventHandler(this.websitebtn_Click);
            this.websitebtn.MouseEnter += new System.EventHandler(this.websitebtn_MouseEnter);
            this.websitebtn.MouseLeave += new System.EventHandler(this.websitebtn_MouseLeave);
            // 
            // facebookbtn
            // 
            this.facebookbtn.BackColor = System.Drawing.Color.Transparent;
            this.facebookbtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_facebook1;
            this.facebookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.facebookbtn, "facebookbtn");
            this.facebookbtn.Name = "facebookbtn";
            this.facebookbtn.UseVisualStyleBackColor = false;
            this.facebookbtn.Click += new System.EventHandler(this.facebookbtn_Click);
            this.facebookbtn.MouseEnter += new System.EventHandler(this.facebookbtn_MouseEnter);
            this.facebookbtn.MouseLeave += new System.EventHandler(this.facebookbtn_MouseLeave);
            // 
            // discordbtn
            // 
            this.discordbtn.BackColor = System.Drawing.Color.Transparent;
            this.discordbtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_discord1;
            this.discordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.discordbtn, "discordbtn");
            this.discordbtn.Name = "discordbtn";
            this.discordbtn.UseVisualStyleBackColor = false;
            this.discordbtn.Click += new System.EventHandler(this.discordbtn_Click);
            this.discordbtn.MouseEnter += new System.EventHandler(this.discordbtn_MouseEnter);
            this.discordbtn.MouseLeave += new System.EventHandler(this.discordbtn_MouseLeave);
            // 
            // noticeBoxLabel
            // 
            this.noticeBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.noticeBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.noticeBoxLabel, "noticeBoxLabel");
            this.noticeBoxLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.noticeBoxLabel.Name = "noticeBoxLabel";
            // 
            // AccretiaOnline
            // 
            resources.ApplyResources(this.AccretiaOnline, "AccretiaOnline");
            this.AccretiaOnline.BackColor = System.Drawing.Color.Transparent;
            this.AccretiaOnline.ForeColor = System.Drawing.Color.Green;
            this.AccretiaOnline.Name = "AccretiaOnline";
            // 
            // BellatoOnline
            // 
            resources.ApplyResources(this.BellatoOnline, "BellatoOnline");
            this.BellatoOnline.BackColor = System.Drawing.Color.Transparent;
            this.BellatoOnline.ForeColor = System.Drawing.Color.Green;
            this.BellatoOnline.Name = "BellatoOnline";
            // 
            // CoraOnline
            // 
            resources.ApplyResources(this.CoraOnline, "CoraOnline");
            this.CoraOnline.BackColor = System.Drawing.Color.Transparent;
            this.CoraOnline.ForeColor = System.Drawing.Color.Green;
            this.CoraOnline.Name = "CoraOnline";
            // 
            // bannerBox
            // 
            this.bannerBox.BackColor = System.Drawing.Color.Transparent;
            this.bannerBox.Image = global::RavenDevLauncher.Properties.Resources.serverbanner;
            resources.ApplyResources(this.bannerBox, "bannerBox");
            this.bannerBox.Name = "bannerBox";
            this.bannerBox.TabStop = false;
            // 
            // CurrentProgBar
            // 
            this.CurrentProgBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.CurrentProgBar, "CurrentProgBar");
            this.CurrentProgBar.Name = "CurrentProgBar";
            this.CurrentProgBar.TabStop = false;
            // 
            // InfoBoxLabel
            // 
            this.InfoBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoBoxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoBoxLabel.ForeColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.InfoBoxLabel, "InfoBoxLabel");
            this.InfoBoxLabel.Name = "InfoBoxLabel";
            // 
            // serverinfobtn
            // 
            this.serverinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.serverinfobtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_info1;
            this.serverinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.serverinfobtn, "serverinfobtn");
            this.serverinfobtn.Name = "serverinfobtn";
            this.serverinfobtn.UseVisualStyleBackColor = false;
            this.serverinfobtn.Click += new System.EventHandler(this.serverinfobtn_Click);
            this.serverinfobtn.MouseEnter += new System.EventHandler(this.serverinfobtn_MouseEnter);
            this.serverinfobtn.MouseLeave += new System.EventHandler(this.serverinfobtn_MouseLeave);
            // 
            // boxinfobtn
            // 
            this.boxinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.boxinfobtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_boxinfo1;
            this.boxinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.boxinfobtn, "boxinfobtn");
            this.boxinfobtn.Name = "boxinfobtn";
            this.boxinfobtn.UseVisualStyleBackColor = false;
            this.boxinfobtn.Click += new System.EventHandler(this.boxinfobtn_Click);
            this.boxinfobtn.MouseEnter += new System.EventHandler(this.boxinfobtn_MouseEnter);
            this.boxinfobtn.MouseLeave += new System.EventHandler(this.boxinfobtn_MouseLeave);
            // 
            // questinfobtn
            // 
            this.questinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.questinfobtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_questinfo1;
            this.questinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.questinfobtn, "questinfobtn");
            this.questinfobtn.Name = "questinfobtn";
            this.questinfobtn.UseVisualStyleBackColor = false;
            this.questinfobtn.Click += new System.EventHandler(this.questinfobtn_Click);
            this.questinfobtn.MouseEnter += new System.EventHandler(this.questinfobtn_MouseEnter);
            this.questinfobtn.MouseLeave += new System.EventHandler(this.questinfobtn_MouseLeave);
            // 
            // combineinfobtn
            // 
            this.combineinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.combineinfobtn.BackgroundImage = global::RavenDevLauncher.Properties.Resources.btn_combineinfo1;
            this.combineinfobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.combineinfobtn, "combineinfobtn");
            this.combineinfobtn.Name = "combineinfobtn";
            this.combineinfobtn.UseVisualStyleBackColor = false;
            this.combineinfobtn.Click += new System.EventHandler(this.combineinfobtn_Click);
            this.combineinfobtn.MouseEnter += new System.EventHandler(this.combineinfobtn_MouseEnter);
            this.combineinfobtn.MouseLeave += new System.EventHandler(this.combineinfobtn_MouseLeave);
            // 
            // status_label
            // 
            resources.ApplyResources(this.status_label, "status_label");
            this.status_label.BackColor = System.Drawing.Color.Transparent;
            this.status_label.ForeColor = System.Drawing.Color.Coral;
            this.status_label.Name = "status_label";
            // 
            // server_list
            // 
            this.server_list.AutoArrange = false;
            this.server_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.server_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.server_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.server_name,
            this.status_name});
            this.server_list.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.server_list, "server_list");
            this.server_list.ForeColor = System.Drawing.Color.Gold;
            this.server_list.FullRowSelect = true;
            this.server_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.server_list.HideSelection = false;
            this.server_list.MultiSelect = false;
            this.server_list.Name = "server_list";
            this.server_list.OwnerDraw = true;
            this.server_list.Scrollable = false;
            this.server_list.UseCompatibleStateImageBehavior = false;
            this.server_list.View = System.Windows.Forms.View.Details;
            this.server_list.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.server_list_DrawItem);
            this.server_list.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.server_list_DrawSubItem);
            this.server_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.server_list_DoubleClick);
            this.server_list.MouseMove += new System.Windows.Forms.MouseEventHandler(this.server_list_MouseMove);
            // 
            // server_name
            // 
            this.server_name.Name = "server_name";
            resources.ApplyResources(this.server_name, "server_name");
            // 
            // status_name
            // 
            this.status_name.Name = "status_name";
            resources.ApplyResources(this.status_name, "status_name");
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.ImageList, "ImageList");
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.BackgroundImage = global::RavenDevLauncher.Properties.Resources.server_list;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PingLabel
            // 
            resources.ApplyResources(this.PingLabel, "PingLabel");
            this.PingLabel.BackColor = System.Drawing.Color.Transparent;
            this.PingLabel.ForeColor = System.Drawing.Color.Gray;
            this.PingLabel.Name = "PingLabel";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.startGameBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::RavenDevLauncher.Properties.Resources.background;
            this.Controls.Add(this.PingLabel);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.percentLable);
            this.Controls.Add(this.SpeedLable);
            this.Controls.Add(this.combineinfobtn);
            this.Controls.Add(this.questinfobtn);
            this.Controls.Add(this.boxinfobtn);
            this.Controls.Add(this.serverinfobtn);
            this.Controls.Add(this.websitebtn);
            this.Controls.Add(this.InfoBoxLabel);
            this.Controls.Add(this.CurrentProgBar);
            this.Controls.Add(this.bannerBox);
            this.Controls.Add(this.CoraOnline);
            this.Controls.Add(this.BellatoOnline);
            this.Controls.Add(this.AccretiaOnline);
            this.Controls.Add(this.noticeBoxLabel);
            this.Controls.Add(this.discordbtn);
            this.Controls.Add(this.facebookbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.TotalProgBar);
            this.Controls.Add(this.FullCheckButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.server_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.Updater_Load);
            
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label percentLable;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FullCheckButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label SpeedLable;
        private System.Windows.Forms.PictureBox TotalProgBar;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.PictureBox minimizeBox;
        public System.Windows.Forms.TextBox txtboxUsername;
        public System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button websitebtn;
        private System.Windows.Forms.Button facebookbtn;
        private System.Windows.Forms.Button discordbtn;
        private System.Windows.Forms.Label noticeBoxLabel;
        private System.Windows.Forms.Label AccretiaOnline;
        private System.Windows.Forms.Label BellatoOnline;
        private System.Windows.Forms.Label CoraOnline;
        private PictureBox bannerBox;
        private PictureBox CurrentProgBar;
        private Label InfoBoxLabel;
        private Button serverinfobtn;
        private Button boxinfobtn;
        private Button questinfobtn;
        private Button combineinfobtn;
        private Label status_label;
        private System.Windows.Forms.ListView server_list;
        private ImageList ImageList;
        private ColumnHeader server_name;
        private ColumnHeader status_name;
        private Panel panel1;
        private Label PingLabel;
    }
}

