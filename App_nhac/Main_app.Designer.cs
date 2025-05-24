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
            System.Windows.Forms.Button quit_btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_app));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.playlist_btn = new System.Windows.Forms.Button();
            this.media_btn = new System.Windows.Forms.Button();
            this.logo_pict = new System.Windows.Forms.PictureBox();
            this.main_panel = new System.Windows.Forms.Panel();
            this.main_picture = new System.Windows.Forms.PictureBox();
            quit_btn = new System.Windows.Forms.Button();
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pict)).BeginInit();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // quit_btn
            // 
            quit_btn.BackColor = System.Drawing.Color.MediumPurple;
            quit_btn.BackgroundImage = global::App_nhac.Properties.Resources.power_switch__1_;
            quit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            quit_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            quit_btn.Location = new System.Drawing.Point(106, 0);
            quit_btn.Name = "quit_btn";
            quit_btn.Size = new System.Drawing.Size(94, 58);
            quit_btn.TabIndex = 2;
            quit_btn.UseVisualStyleBackColor = false;
            quit_btn.Click += new System.EventHandler(this.quit_btn_Click_1);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menu_panel.Controls.Add(this.panel1);
            this.menu_panel.Controls.Add(this.playlist_btn);
            this.menu_panel.Controls.Add(this.media_btn);
            this.menu_panel.Controls.Add(this.logo_pict);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(200, 561);
            this.menu_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(quit_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 62);
            this.panel1.TabIndex = 3;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.logout_btn.BackgroundImage = global::App_nhac.Properties.Resources.logout__1_;
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.logout_btn.Location = new System.Drawing.Point(0, 0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(96, 59);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.UseVisualStyleBackColor = false;
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
            this.media_btn.Click += new System.EventHandler(this.media_btn_Click);
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
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.SlateBlue;
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel.Controls.Add(this.main_picture);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_panel.Location = new System.Drawing.Point(199, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(785, 561);
            this.main_panel.TabIndex = 1;
            // 
            // main_picture
            // 
            this.main_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_picture.Image = global::App_nhac.Properties.Resources.Wineass_Ios7_Redesign_Music_512;
            this.main_picture.Location = new System.Drawing.Point(130, 23);
            this.main_picture.Name = "main_picture";
            this.main_picture.Size = new System.Drawing.Size(514, 515);
            this.main_picture.TabIndex = 0;
            this.main_picture.TabStop = false;
            // 
            // Main_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menu_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Main_app_Load_1);
            this.menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pict)).EndInit();
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox logo_pict;
        private System.Windows.Forms.Button playlist_btn;
        private System.Windows.Forms.Button media_btn;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox main_picture;
    }
}