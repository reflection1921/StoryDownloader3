
namespace StoryDownloader3
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
            this.labelTitle = new ReaLTaiizor.Controls.FoxBigLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatusMain = new ReaLTaiizor.Controls.FoxLabel();
            this.labelStatus = new ReaLTaiizor.Controls.FoxLabel();
            this.progressStatusMain = new ReaLTaiizor.Controls.HopeProgressBar();
            this.btnStart = new ReaLTaiizor.Controls.FoxButton();
            this.foxCheckBox7 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkInvitations = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkFriends = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkComments = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkVideo = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkPhoto = new ReaLTaiizor.Controls.FoxCheckBox();
            this.chkArticle = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxLabel7 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.labelBackupTitle = new ReaLTaiizor.Controls.FoxBigLabel();
            this.btnSelectPath = new ReaLTaiizor.Controls.FoxButton();
            this.labelSavePath = new ReaLTaiizor.Controls.FoxBigLabel();
            this.labelSaveTitle = new ReaLTaiizor.Controls.FoxBigLabel();
            this.progressStatus = new ReaLTaiizor.Controls.HopeProgressBar();
            this.labelNickname = new ReaLTaiizor.Controls.FoxLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelTitle.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelTitle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(440, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Story Downloader 3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStatusMain);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.progressStatusMain);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.foxCheckBox7);
            this.panel1.Controls.Add(this.chkInvitations);
            this.panel1.Controls.Add(this.chkFriends);
            this.panel1.Controls.Add(this.chkComments);
            this.panel1.Controls.Add(this.chkVideo);
            this.panel1.Controls.Add(this.chkPhoto);
            this.panel1.Controls.Add(this.chkArticle);
            this.panel1.Controls.Add(this.foxLabel7);
            this.panel1.Controls.Add(this.foxLabel6);
            this.panel1.Controls.Add(this.foxLabel5);
            this.panel1.Controls.Add(this.foxLabel4);
            this.panel1.Controls.Add(this.foxLabel3);
            this.panel1.Controls.Add(this.foxLabel2);
            this.panel1.Controls.Add(this.foxLabel1);
            this.panel1.Controls.Add(this.labelBackupTitle);
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Controls.Add(this.labelSavePath);
            this.panel1.Controls.Add(this.labelSaveTitle);
            this.panel1.Controls.Add(this.progressStatus);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 441);
            this.panel1.TabIndex = 1;
            // 
            // labelStatusMain
            // 
            this.labelStatusMain.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatusMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelStatusMain.Location = new System.Drawing.Point(18, 104);
            this.labelStatusMain.Name = "labelStatusMain";
            this.labelStatusMain.Size = new System.Drawing.Size(402, 19);
            this.labelStatusMain.TabIndex = 22;
            this.labelStatusMain.Text = "대기";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelStatus.Location = new System.Drawing.Point(19, 41);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(402, 19);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "대기";
            // 
            // progressStatusMain
            // 
            this.progressStatusMain.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.progressStatusMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.progressStatusMain.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.progressStatusMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressStatusMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.progressStatusMain.FullBallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.progressStatusMain.FullBallonText = "Fin";
            this.progressStatusMain.FullBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.progressStatusMain.IsError = false;
            this.progressStatusMain.Location = new System.Drawing.Point(3, 66);
            this.progressStatusMain.Name = "progressStatusMain";
            this.progressStatusMain.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            this.progressStatusMain.Size = new System.Drawing.Size(434, 32);
            this.progressStatusMain.TabIndex = 20;
            this.progressStatusMain.ValueNumber = 0;
            // 
            // btnStart
            // 
            this.btnStart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnStart.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btnStart.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnStart.EnabledCalc = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnStart.Location = new System.Drawing.Point(19, 397);
            this.btnStart.Name = "btnStart";
            this.btnStart.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnStart.Size = new System.Drawing.Size(403, 32);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "백업";
            this.btnStart.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.btnStart_Click);
            // 
            // foxCheckBox7
            // 
            this.foxCheckBox7.Checked = true;
            this.foxCheckBox7.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox7.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox7.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox7.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox7.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox7.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox7.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox7.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox7.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox7.EnabledCalc = true;
            this.foxCheckBox7.Location = new System.Drawing.Point(132, 354);
            this.foxCheckBox7.Name = "foxCheckBox7";
            this.foxCheckBox7.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox7.TabIndex = 18;
            this.foxCheckBox7.Text = "foxCheckBox7";
            this.foxCheckBox7.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox7.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox7.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkInvitations
            // 
            this.chkInvitations.Checked = true;
            this.chkInvitations.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkInvitations.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkInvitations.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkInvitations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkInvitations.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkInvitations.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkInvitations.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkInvitations.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkInvitations.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkInvitations.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkInvitations.EnabledCalc = true;
            this.chkInvitations.Location = new System.Drawing.Point(352, 320);
            this.chkInvitations.Name = "chkInvitations";
            this.chkInvitations.Size = new System.Drawing.Size(55, 28);
            this.chkInvitations.TabIndex = 17;
            this.chkInvitations.Text = "foxCheckBox6";
            this.chkInvitations.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkInvitations.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkInvitations.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkFriends
            // 
            this.chkFriends.Checked = true;
            this.chkFriends.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkFriends.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkFriends.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFriends.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkFriends.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkFriends.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkFriends.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkFriends.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkFriends.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkFriends.EnabledCalc = true;
            this.chkFriends.Location = new System.Drawing.Point(132, 320);
            this.chkFriends.Name = "chkFriends";
            this.chkFriends.Size = new System.Drawing.Size(55, 28);
            this.chkFriends.TabIndex = 16;
            this.chkFriends.Text = "foxCheckBox5";
            this.chkFriends.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkFriends.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkFriends.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkComments
            // 
            this.chkComments.Checked = true;
            this.chkComments.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkComments.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkComments.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkComments.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkComments.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkComments.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkComments.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkComments.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkComments.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkComments.EnabledCalc = true;
            this.chkComments.Location = new System.Drawing.Point(352, 286);
            this.chkComments.Name = "chkComments";
            this.chkComments.Size = new System.Drawing.Size(55, 28);
            this.chkComments.TabIndex = 15;
            this.chkComments.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkComments.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkComments.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkVideo
            // 
            this.chkVideo.Checked = true;
            this.chkVideo.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkVideo.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkVideo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkVideo.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkVideo.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkVideo.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkVideo.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkVideo.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkVideo.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkVideo.EnabledCalc = false;
            this.chkVideo.Location = new System.Drawing.Point(132, 286);
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.Size = new System.Drawing.Size(55, 28);
            this.chkVideo.TabIndex = 14;
            this.chkVideo.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkVideo.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkVideo.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkPhoto
            // 
            this.chkPhoto.Checked = true;
            this.chkPhoto.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkPhoto.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkPhoto.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPhoto.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkPhoto.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkPhoto.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkPhoto.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkPhoto.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkPhoto.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkPhoto.EnabledCalc = false;
            this.chkPhoto.Location = new System.Drawing.Point(352, 252);
            this.chkPhoto.Name = "chkPhoto";
            this.chkPhoto.Size = new System.Drawing.Size(55, 28);
            this.chkPhoto.TabIndex = 13;
            this.chkPhoto.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkPhoto.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkPhoto.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // chkArticle
            // 
            this.chkArticle.Checked = true;
            this.chkArticle.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkArticle.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.chkArticle.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.chkArticle.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkArticle.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkArticle.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.chkArticle.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.chkArticle.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkArticle.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.chkArticle.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.chkArticle.EnabledCalc = false;
            this.chkArticle.Location = new System.Drawing.Point(132, 252);
            this.chkArticle.Name = "chkArticle";
            this.chkArticle.Size = new System.Drawing.Size(55, 28);
            this.chkArticle.TabIndex = 12;
            this.chkArticle.Text = "foxCheckBox1";
            this.chkArticle.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkArticle.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.chkArticle.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // foxLabel7
            // 
            this.foxLabel7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel7.Location = new System.Drawing.Point(256, 325);
            this.foxLabel7.Name = "foxLabel7";
            this.foxLabel7.Size = new System.Drawing.Size(92, 19);
            this.foxLabel7.TabIndex = 11;
            this.foxLabel7.Text = "친구신청 목록";
            // 
            // foxLabel6
            // 
            this.foxLabel6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel6.Location = new System.Drawing.Point(34, 325);
            this.foxLabel6.Name = "foxLabel6";
            this.foxLabel6.Size = new System.Drawing.Size(92, 19);
            this.foxLabel6.TabIndex = 10;
            this.foxLabel6.Text = "친구목록";
            // 
            // foxLabel5
            // 
            this.foxLabel5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel5.Location = new System.Drawing.Point(256, 290);
            this.foxLabel5.Name = "foxLabel5";
            this.foxLabel5.Size = new System.Drawing.Size(92, 19);
            this.foxLabel5.TabIndex = 9;
            this.foxLabel5.Text = "댓글";
            // 
            // foxLabel4
            // 
            this.foxLabel4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel4.Location = new System.Drawing.Point(36, 359);
            this.foxLabel4.Name = "foxLabel4";
            this.foxLabel4.Size = new System.Drawing.Size(90, 19);
            this.foxLabel4.TabIndex = 8;
            this.foxLabel4.Text = "쪽지";
            // 
            // foxLabel3
            // 
            this.foxLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel3.Location = new System.Drawing.Point(34, 290);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(92, 19);
            this.foxLabel3.TabIndex = 7;
            this.foxLabel3.Text = "동영상";
            // 
            // foxLabel2
            // 
            this.foxLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(256, 257);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(92, 19);
            this.foxLabel2.TabIndex = 6;
            this.foxLabel2.Text = "사진";
            // 
            // foxLabel1
            // 
            this.foxLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(34, 257);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(92, 19);
            this.foxLabel1.TabIndex = 5;
            this.foxLabel1.Text = "게시글";
            // 
            // labelBackupTitle
            // 
            this.labelBackupTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelBackupTitle.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelBackupTitle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelBackupTitle.Location = new System.Drawing.Point(19, 210);
            this.labelBackupTitle.Name = "labelBackupTitle";
            this.labelBackupTitle.Size = new System.Drawing.Size(403, 32);
            this.labelBackupTitle.TabIndex = 4;
            this.labelBackupTitle.Text = "백업할 내용 선택";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSelectPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnSelectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPath.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSelectPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSelectPath.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.btnSelectPath.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSelectPath.EnabledCalc = true;
            this.btnSelectPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnSelectPath.Location = new System.Drawing.Point(354, 172);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSelectPath.Size = new System.Drawing.Size(53, 25);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.btnSelectPath_Click);
            // 
            // labelSavePath
            // 
            this.labelSavePath.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSavePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelSavePath.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelSavePath.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelSavePath.Location = new System.Drawing.Point(34, 172);
            this.labelSavePath.Name = "labelSavePath";
            this.labelSavePath.Size = new System.Drawing.Size(314, 25);
            this.labelSavePath.TabIndex = 2;
            this.labelSavePath.Text = "경로를 설정하세요.";
            // 
            // labelSaveTitle
            // 
            this.labelSaveTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSaveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelSaveTitle.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.labelSaveTitle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelSaveTitle.Location = new System.Drawing.Point(18, 128);
            this.labelSaveTitle.Name = "labelSaveTitle";
            this.labelSaveTitle.Size = new System.Drawing.Size(403, 32);
            this.labelSaveTitle.TabIndex = 1;
            this.labelSaveTitle.Text = "저장 경로";
            // 
            // progressStatus
            // 
            this.progressStatus.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.progressStatus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.progressStatus.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.progressStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.progressStatus.FullBallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.progressStatus.FullBallonText = "Fin";
            this.progressStatus.FullBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.progressStatus.IsError = false;
            this.progressStatus.Location = new System.Drawing.Point(3, 3);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            this.progressStatus.Size = new System.Drawing.Size(434, 32);
            this.progressStatus.TabIndex = 0;
            this.progressStatus.ValueNumber = 0;
            // 
            // labelNickname
            // 
            this.labelNickname.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelNickname.Location = new System.Drawing.Point(327, 35);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(122, 19);
            this.labelNickname.TabIndex = 7;
            this.labelNickname.Text = "로드중...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 516);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Story Downloader 3";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.FoxBigLabel labelTitle;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.FoxBigLabel labelSaveTitle;
        private ReaLTaiizor.Controls.HopeProgressBar progressStatus;
        private ReaLTaiizor.Controls.FoxBigLabel labelBackupTitle;
        private ReaLTaiizor.Controls.FoxButton btnSelectPath;
        private ReaLTaiizor.Controls.FoxBigLabel labelSavePath;
        private ReaLTaiizor.Controls.FoxLabel labelStatusMain;
        private ReaLTaiizor.Controls.FoxLabel labelStatus;
        private ReaLTaiizor.Controls.HopeProgressBar progressStatusMain;
        private ReaLTaiizor.Controls.FoxButton btnStart;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox7;
        private ReaLTaiizor.Controls.FoxCheckBox chkInvitations;
        private ReaLTaiizor.Controls.FoxCheckBox chkFriends;
        private ReaLTaiizor.Controls.FoxCheckBox chkComments;
        private ReaLTaiizor.Controls.FoxCheckBox chkVideo;
        private ReaLTaiizor.Controls.FoxCheckBox chkPhoto;
        private ReaLTaiizor.Controls.FoxCheckBox chkArticle;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel labelNickname;
    }
}