
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
            this.hopeProgressBar1 = new ReaLTaiizor.Controls.HopeProgressBar();
            this.foxButton2 = new ReaLTaiizor.Controls.FoxButton();
            this.foxCheckBox7 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxCheckBox6 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxCheckBox5 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxCheckBox4 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxCheckBox3 = new ReaLTaiizor.Controls.FoxCheckBox();
            this.foxCheckBox2 = new ReaLTaiizor.Controls.FoxCheckBox();
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
            this.panel1.Controls.Add(this.hopeProgressBar1);
            this.panel1.Controls.Add(this.foxButton2);
            this.panel1.Controls.Add(this.foxCheckBox7);
            this.panel1.Controls.Add(this.foxCheckBox6);
            this.panel1.Controls.Add(this.foxCheckBox5);
            this.panel1.Controls.Add(this.foxCheckBox4);
            this.panel1.Controls.Add(this.foxCheckBox3);
            this.panel1.Controls.Add(this.foxCheckBox2);
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
            this.labelStatusMain.Text = "게시글, 사진, 동영상 다운로드 진행 중";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.labelStatus.Location = new System.Drawing.Point(19, 41);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(402, 19);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "게시글 3000개 중 1개 다운로드";
            // 
            // hopeProgressBar1
            // 
            this.hopeProgressBar1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeProgressBar1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeProgressBar1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeProgressBar1.FullBallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeProgressBar1.FullBallonText = "Ok!";
            this.hopeProgressBar1.FullBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeProgressBar1.IsError = false;
            this.hopeProgressBar1.Location = new System.Drawing.Point(3, 66);
            this.hopeProgressBar1.Name = "hopeProgressBar1";
            this.hopeProgressBar1.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            this.hopeProgressBar1.Size = new System.Drawing.Size(434, 32);
            this.hopeProgressBar1.TabIndex = 20;
            this.hopeProgressBar1.Text = "hopeProgressBar1";
            this.hopeProgressBar1.ValueNumber = 0;
            // 
            // foxButton2
            // 
            this.foxButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.foxButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.foxButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxButton2.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.foxButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.foxButton2.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.foxButton2.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.foxButton2.EnabledCalc = true;
            this.foxButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foxButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.foxButton2.Location = new System.Drawing.Point(19, 397);
            this.foxButton2.Name = "foxButton2";
            this.foxButton2.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.foxButton2.Size = new System.Drawing.Size(403, 32);
            this.foxButton2.TabIndex = 19;
            this.foxButton2.Text = "백업";
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
            // foxCheckBox6
            // 
            this.foxCheckBox6.Checked = true;
            this.foxCheckBox6.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox6.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox6.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox6.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox6.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox6.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox6.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox6.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox6.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox6.EnabledCalc = true;
            this.foxCheckBox6.Location = new System.Drawing.Point(352, 320);
            this.foxCheckBox6.Name = "foxCheckBox6";
            this.foxCheckBox6.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox6.TabIndex = 17;
            this.foxCheckBox6.Text = "foxCheckBox6";
            this.foxCheckBox6.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox6.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox6.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // foxCheckBox5
            // 
            this.foxCheckBox5.Checked = true;
            this.foxCheckBox5.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox5.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox5.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox5.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox5.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox5.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox5.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox5.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox5.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox5.EnabledCalc = true;
            this.foxCheckBox5.Location = new System.Drawing.Point(132, 320);
            this.foxCheckBox5.Name = "foxCheckBox5";
            this.foxCheckBox5.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox5.TabIndex = 16;
            this.foxCheckBox5.Text = "foxCheckBox5";
            this.foxCheckBox5.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox5.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox5.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // foxCheckBox4
            // 
            this.foxCheckBox4.Checked = true;
            this.foxCheckBox4.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox4.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox4.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox4.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox4.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox4.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox4.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox4.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox4.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox4.EnabledCalc = true;
            this.foxCheckBox4.Location = new System.Drawing.Point(352, 286);
            this.foxCheckBox4.Name = "foxCheckBox4";
            this.foxCheckBox4.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox4.TabIndex = 15;
            this.foxCheckBox4.Text = "foxCheckBox4";
            this.foxCheckBox4.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox4.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox4.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // foxCheckBox3
            // 
            this.foxCheckBox3.Checked = true;
            this.foxCheckBox3.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox3.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox3.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox3.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox3.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox3.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox3.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox3.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox3.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox3.EnabledCalc = true;
            this.foxCheckBox3.Location = new System.Drawing.Point(132, 286);
            this.foxCheckBox3.Name = "foxCheckBox3";
            this.foxCheckBox3.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox3.TabIndex = 14;
            this.foxCheckBox3.Text = "foxCheckBox3";
            this.foxCheckBox3.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox3.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox3.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            // 
            // foxCheckBox2
            // 
            this.foxCheckBox2.Checked = true;
            this.foxCheckBox2.CheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox2.CheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            this.foxCheckBox2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.foxCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foxCheckBox2.DisabledCheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox2.DisabledCheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(166)))), ((int)(((byte)(191)))));
            this.foxCheckBox2.DisabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.foxCheckBox2.DisabledUncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.foxCheckBox2.DisabledUncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(189)))), ((int)(((byte)(133)))));
            this.foxCheckBox2.DisabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(124)))));
            this.foxCheckBox2.EnabledCalc = true;
            this.foxCheckBox2.Location = new System.Drawing.Point(352, 252);
            this.foxCheckBox2.Name = "foxCheckBox2";
            this.foxCheckBox2.Size = new System.Drawing.Size(55, 28);
            this.foxCheckBox2.TabIndex = 13;
            this.foxCheckBox2.Text = "foxCheckBox2";
            this.foxCheckBox2.UncheckedBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.foxCheckBox2.UncheckedBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.foxCheckBox2.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
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
            this.labelSavePath.Text = "C:\\Temp";
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
            this.progressStatus.FullBallonText = "Ok!";
            this.progressStatus.FullBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.progressStatus.IsError = false;
            this.progressStatus.Location = new System.Drawing.Point(3, 3);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            this.progressStatus.Size = new System.Drawing.Size(434, 32);
            this.progressStatus.TabIndex = 0;
            this.progressStatus.Text = "hopeProgressBar1";
            this.progressStatus.ValueNumber = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Story Downloader 3";
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
        private ReaLTaiizor.Controls.HopeProgressBar hopeProgressBar1;
        private ReaLTaiizor.Controls.FoxButton foxButton2;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox7;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox6;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox5;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox4;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox3;
        private ReaLTaiizor.Controls.FoxCheckBox foxCheckBox2;
        private ReaLTaiizor.Controls.FoxCheckBox chkArticle;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
    }
}