namespace LAB10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cichaNocŚwiętaNocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bogSieRodziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonForword = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerProgresBar = new System.Windows.Forms.Timer(this.components);
            this.labelTimeSong = new System.Windows.Forms.Label();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songsToolStripMenuItem,
            this.selectSongToolStripMenuItem,
            this.selectTextToolStripMenuItem,
            this.clearTextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstSongToolStripMenuItem,
            this.cichaNocŚwiętaNocToolStripMenuItem,
            this.bogSieRodziToolStripMenuItem});
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // firstSongToolStripMenuItem
            // 
            this.firstSongToolStripMenuItem.Name = "firstSongToolStripMenuItem";
            this.firstSongToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.firstSongToolStripMenuItem.Text = "Feliz Navidad";
            this.firstSongToolStripMenuItem.Click += new System.EventHandler(this.firstSongToolStripMenuItem_Click);
            // 
            // cichaNocŚwiętaNocToolStripMenuItem
            // 
            this.cichaNocŚwiętaNocToolStripMenuItem.Name = "cichaNocŚwiętaNocToolStripMenuItem";
            this.cichaNocŚwiętaNocToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.cichaNocŚwiętaNocToolStripMenuItem.Text = "Cicha noc święta noc";
            this.cichaNocŚwiętaNocToolStripMenuItem.Click += new System.EventHandler(this.cichaNocŚwiętaNocToolStripMenuItem_Click);
            // 
            // bogSieRodziToolStripMenuItem
            // 
            this.bogSieRodziToolStripMenuItem.Name = "bogSieRodziToolStripMenuItem";
            this.bogSieRodziToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.bogSieRodziToolStripMenuItem.Text = "Bóg sie rodzi";
            this.bogSieRodziToolStripMenuItem.Click += new System.EventHandler(this.bogSieRodziToolStripMenuItem_Click);
            // 
            // selectSongToolStripMenuItem
            // 
            this.selectSongToolStripMenuItem.Name = "selectSongToolStripMenuItem";
            this.selectSongToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.selectSongToolStripMenuItem.Text = "Select song";
            this.selectSongToolStripMenuItem.Click += new System.EventHandler(this.selectSongToolStripMenuItem_Click);
            // 
            // selectTextToolStripMenuItem
            // 
            this.selectTextToolStripMenuItem.Name = "selectTextToolStripMenuItem";
            this.selectTextToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.selectTextToolStripMenuItem.Text = "Select Text";
            this.selectTextToolStripMenuItem.Click += new System.EventHandler(this.selectTextToolStripMenuItem_Click);
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.clearTextToolStripMenuItem.Text = "Clear text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 228);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(151, 46);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(416, 228);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(151, 46);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Song name";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(555, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // buttonRewind
            // 
            this.buttonRewind.Location = new System.Drawing.Point(169, 228);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(75, 46);
            this.buttonRewind.TabIndex = 7;
            this.buttonRewind.Text = "<<";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonForword
            // 
            this.buttonForword.Location = new System.Drawing.Point(335, 228);
            this.buttonForword.Name = "buttonForword";
            this.buttonForword.Size = new System.Drawing.Size(75, 46);
            this.buttonForword.TabIndex = 8;
            this.buttonForword.Text = ">>";
            this.buttonForword.UseVisualStyleBackColor = true;
            this.buttonForword.Click += new System.EventHandler(this.buttonForword_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(254, 228);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 46);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "||";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerProgresBar
            // 
            this.timerProgresBar.Enabled = true;
            this.timerProgresBar.Tick += new System.EventHandler(this.timerProgresBar_Tick);
            // 
            // labelTimeSong
            // 
            this.labelTimeSong.AutoSize = true;
            this.labelTimeSong.Location = new System.Drawing.Point(454, 44);
            this.labelTimeSong.Name = "labelTimeSong";
            this.labelTimeSong.Size = new System.Drawing.Size(41, 16);
            this.labelTimeSong.TabIndex = 12;
            this.labelTimeSong.Text = "0 Sec";
            // 
            // textBoxSong
            // 
            this.textBoxSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSong.Location = new System.Drawing.Point(12, 63);
            this.textBoxSong.Multiline = true;
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.ReadOnly = true;
            this.textBoxSong.Size = new System.Drawing.Size(493, 128);
            this.textBoxSong.TabIndex = 13;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(511, 63);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(56, 128);
            this.trackBarVolume.TabIndex = 14;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(517, 44);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(33, 16);
            this.labelVolume.TabIndex = 15;
            this.labelVolume.Text = "50%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 286);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.textBoxSong);
            this.Controls.Add(this.labelTimeSong);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonForword);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstSongToolStripMenuItem;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonForword;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.ToolStripMenuItem selectSongToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem selectTextToolStripMenuItem;
        private System.Windows.Forms.Timer timerProgresBar;
        private System.Windows.Forms.Label labelTimeSong;
        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.ToolStripMenuItem cichaNocŚwiętaNocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bogSieRodziToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
    }
}

