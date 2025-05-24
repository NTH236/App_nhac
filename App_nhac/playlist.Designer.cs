namespace App_nhac
{
    partial class playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist));
            this.nhac_tre = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.nhac_au = new System.Windows.Forms.FlowLayoutPanel();
            this.title_song1 = new System.Windows.Forms.Label();
            this.title_song2 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhac_tre
            // 
            this.nhac_tre.AutoScroll = true;
            this.nhac_tre.Location = new System.Drawing.Point(11, 38);
            this.nhac_tre.Name = "nhac_tre";
            this.nhac_tre.Size = new System.Drawing.Size(808, 222);
            this.nhac_tre.TabIndex = 0;
            this.nhac_tre.Paint += new System.Windows.Forms.PaintEventHandler(this.listmusic_Paint);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(7, 689);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(813, 79);
            this.axWindowsMediaPlayer.TabIndex = 1;
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Enter);
            // 
            // nhac_au
            // 
            this.nhac_au.AutoScroll = true;
            this.nhac_au.Location = new System.Drawing.Point(11, 321);
            this.nhac_au.Name = "nhac_au";
            this.nhac_au.Size = new System.Drawing.Size(808, 222);
            this.nhac_au.TabIndex = 0;
            this.nhac_au.Paint += new System.Windows.Forms.PaintEventHandler(this.listmusic_Paint);
            // 
            // title_song1
            // 
            this.title_song1.AutoSize = true;
            this.title_song1.Location = new System.Drawing.Point(14, 12);
            this.title_song1.Name = "title_song1";
            this.title_song1.Size = new System.Drawing.Size(35, 13);
            this.title_song1.TabIndex = 3;
            this.title_song1.Text = "label1";
            // 
            // title_song2
            // 
            this.title_song2.AutoSize = true;
            this.title_song2.Location = new System.Drawing.Point(14, 291);
            this.title_song2.Name = "title_song2";
            this.title_song2.Size = new System.Drawing.Size(35, 13);
            this.title_song2.TabIndex = 3;
            this.title_song2.Text = "label1";
            // 
            // main_panel
            // 
            this.main_panel.AutoScrollMargin = new System.Drawing.Size(0, 600);
            this.main_panel.Controls.Add(this.nhac_au);
            this.main_panel.Controls.Add(this.title_song2);
            this.main_panel.Controls.Add(this.title_song1);
            this.main_panel.Controls.Add(this.nhac_tre);
            this.main_panel.Location = new System.Drawing.Point(1, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(847, 749);
            this.main_panel.TabIndex = 4;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(849, 749);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.MaximizeBox = false;
            this.Name = "playlist";
            this.Text = "playlist";
            this.Load += new System.EventHandler(this.playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel nhac_tre;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.FlowLayoutPanel nhac_au;
        private System.Windows.Forms.Label title_song1;
        private System.Windows.Forms.Label title_song2;
        private System.Windows.Forms.Panel main_panel;
    }
}