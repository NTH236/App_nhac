namespace App_nhac
{
    partial class Playlist_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.song_img = new System.Windows.Forms.PictureBox();
            this.song_name = new System.Windows.Forms.Label();
            this.casi_name = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.id_baihat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.song_img)).BeginInit();
            this.SuspendLayout();
            // 
            // song_img
            // 
            this.song_img.Image = global::App_nhac.Properties.Resources.Wineass_Ios7_Redesign_Music_512;
            this.song_img.Location = new System.Drawing.Point(36, 15);
            this.song_img.Name = "song_img";
            this.song_img.Size = new System.Drawing.Size(110, 104);
            this.song_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.song_img.TabIndex = 0;
            this.song_img.TabStop = false;
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.Location = new System.Drawing.Point(55, 142);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(35, 13);
            this.song_name.TabIndex = 1;
            this.song_name.Text = "label1";
            this.song_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // casi_name
            // 
            this.casi_name.AutoSize = true;
            this.casi_name.Location = new System.Drawing.Point(55, 179);
            this.casi_name.Name = "casi_name";
            this.casi_name.Size = new System.Drawing.Size(35, 13);
            this.casi_name.TabIndex = 2;
            this.casi_name.Text = "label2";
            this.casi_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(231, 123);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(35, 13);
            this.link.TabIndex = 3;
            this.link.Text = "label3";
            // 
            // id_baihat
            // 
            this.id_baihat.AutoSize = true;
            this.id_baihat.Location = new System.Drawing.Point(231, 200);
            this.id_baihat.Name = "id_baihat";
            this.id_baihat.Size = new System.Drawing.Size(35, 13);
            this.id_baihat.TabIndex = 4;
            this.id_baihat.Text = "label1";
            // 
            // Playlist_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.id_baihat);
            this.Controls.Add(this.link);
            this.Controls.Add(this.casi_name);
            this.Controls.Add(this.song_name);
            this.Controls.Add(this.song_img);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Playlist_item";
            this.Size = new System.Drawing.Size(184, 214);
            this.Load += new System.EventHandler(this.Playlist_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.song_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox song_img;
        private System.Windows.Forms.Label song_name;
        private System.Windows.Forms.Label casi_name;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label id_baihat;
    }
}
