namespace App_nhac
{
    partial class Main_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_app));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.playlist_btn = new System.Windows.Forms.Button();
            this.media_btn = new System.Windows.Forms.Button();
            this.logo_pict = new System.Windows.Forms.PictureBox();
            this.playlist = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menu_panel.Controls.Add(this.logOut_btn);
            this.menu_panel.Controls.Add(this.playlist_btn);
            this.menu_panel.Controls.Add(this.media_btn);
            this.menu_panel.Controls.Add(this.logo_pict);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(200, 450);
            this.menu_panel.TabIndex = 0;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.logOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOut_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOut_btn.Enabled = false;
            this.logOut_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.Color.White;
            this.logOut_btn.Image = global::App_nhac.Properties.Resources.Aniket_Suvarna_Box_Regular_Bx_log_in_48;
            this.logOut_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut_btn.Location = new System.Drawing.Point(0, 405);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(200, 45);
            this.logOut_btn.TabIndex = 1;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // playlist_btn
            // 
            this.playlist_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.playlist_btn.BackgroundImage = global::App_nhac.Properties.Resources.Steve_Zondicons_Playlist_48;
            this.playlist_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playlist_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlist_btn.ForeColor = System.Drawing.Color.White;
            this.playlist_btn.Location = new System.Drawing.Point(0, 261);
            this.playlist_btn.Name = "playlist_btn";
            this.playlist_btn.Size = new System.Drawing.Size(200, 59);
            this.playlist_btn.TabIndex = 1;
            this.playlist_btn.Text = "Playlist";
            this.playlist_btn.UseVisualStyleBackColor = false;
            this.playlist_btn.Click += new System.EventHandler(this.playlist_btn_Click);
            // 
            // media_btn
            // 
            this.media_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.media_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.media_btn.BackgroundImage = global::App_nhac.Properties.Resources.Icons8_Windows_8_Music_Note_Music_48;
            this.media_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.media_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.media_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media_btn.ForeColor = System.Drawing.Color.White;
            this.media_btn.Location = new System.Drawing.Point(0, 187);
            this.media_btn.Name = "media_btn";
            this.media_btn.Size = new System.Drawing.Size(200, 59);
            this.media_btn.TabIndex = 1;
            this.media_btn.Text = "Media";
            this.media_btn.UseVisualStyleBackColor = false;
            // 
            // logo_pict
            // 
            this.logo_pict.BackgroundImage = global::App_nhac.Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Headphones_Simple_128;
            this.logo_pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_pict.Location = new System.Drawing.Point(0, 0);
            this.logo_pict.Name = "logo_pict";
            this.logo_pict.Size = new System.Drawing.Size(200, 126);
            this.logo_pict.TabIndex = 0;
            this.logo_pict.TabStop = false;
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.MediumPurple;
            this.playlist.FormattingEnabled = true;
            this.playlist.Location = new System.Drawing.Point(572, 12);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(216, 368);
            this.playlist.TabIndex = 2;
            this.playlist.SelectedIndexChanged += new System.EventHandler(this.playlist_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(206, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(360, 368);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // Main_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menu_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Main_app_Load_1);
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox logo_pict;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Button playlist_btn;
        private System.Windows.Forms.Button media_btn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox playlist;
    }
}