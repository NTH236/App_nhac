using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_nhac
{
    public partial class Main_app : Form
    {
        public Main_app()
        {
            InitializeComponent();
        }

        private void playlist_btn_Click(object sender, EventArgs e)
        {

        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {

        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        List<string> musicPaths = new List<string>();
        private void loadBaiHat(string path)
        {
            this.playlist.Items.Clear();
            this.musicPaths.Clear();
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.mp3");
                foreach (string item in files)
                {
                    this.playlist.Items.Add(Path.GetFileName(item));
                    musicPaths.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = playlist.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < musicPaths.Count)
            {
                string selectedPath = musicPaths[selectedIndex];
                axWindowsMediaPlayer1.URL = selectedPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void Main_app_Load_1(object sender, EventArgs e)
        {
            string musicFolder = @"E:\myWork\App_nhac\App_nhac\audio";
            loadBaiHat(musicFolder);
        }
    }
}
