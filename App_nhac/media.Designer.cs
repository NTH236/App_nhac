namespace App_nhac
{
    partial class media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(media));
            this.progress_bar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.play_btn = new System.Windows.Forms.PictureBox();
            this.prev_btn = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.PictureBox();
            this.update_progress = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(0, 323);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(800, 45);
            this.progress_bar.TabIndex = 1;
            this.progress_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.progress_bar.Scroll += new System.EventHandler(this.progress_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.play_btn);
            this.panel1.Controls.Add(this.prev_btn);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 2;
            // 
            // play_btn
            // 
            this.play_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_btn.Image = global::App_nhac.Properties.Resources.Github_Octicons_Play_16_64;
            this.play_btn.Location = new System.Drawing.Point(370, 15);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(66, 64);
            this.play_btn.TabIndex = 4;
            this.play_btn.TabStop = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Image = global::App_nhac.Properties.Resources.Pictogrammers_Material_Skip_previous_circle_outline_64;
            this.prev_btn.Location = new System.Drawing.Point(252, 16);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(61, 64);
            this.prev_btn.TabIndex = 6;
            this.prev_btn.TabStop = false;
            // 
            // next_btn
            // 
            this.next_btn.Image = global::App_nhac.Properties.Resources.Pictogrammers_Material_Skip_next_circle_outline_64;
            this.next_btn.Location = new System.Drawing.Point(495, 16);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(62, 64);
            this.next_btn.TabIndex = 5;
            this.next_btn.TabStop = false;
            // 
            // update_progress
            // 
            this.update_progress.Tick += new System.EventHandler(this.update_progress_Tick);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(409, 168);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(63, 44);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::App_nhac.Properties.Resources.Wineass_Ios7_Redesign_Music_512;
            this.pictureBox1.Location = new System.Drawing.Point(278, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.MaximizeBox = false;
            this.Name = "media";
            this.Text = "media";
            this.Load += new System.EventHandler(this.media_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.TrackBar progress_bar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer update_progress;
        private System.Windows.Forms.PictureBox play_btn;
        private System.Windows.Forms.PictureBox prev_btn;
        private System.Windows.Forms.PictureBox next_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}