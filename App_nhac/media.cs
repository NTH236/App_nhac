using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_nhac
{
    public partial class media : Form
    {
        public media(string path)
        {
            InitializeComponent();
            play_new_song(path);
            axWindowsMediaPlayer.Ctlcontrols.play();
            update_progress.Start();
        }
        public void play_new_song(string newpath)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
            axWindowsMediaPlayer.URL = newpath;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void update_progradess_Tick(object sender, EventArgs e)
        {
            
        }

        private void media_Load(object sender, EventArgs e)
        {
            
        }
        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void progress_Scroll(object sender, EventArgs e)
        {

        }

        private void update_progress_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.currentMedia != null)
            {
                double duration = axWindowsMediaPlayer.currentMedia.duration;
                double current = axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                if (duration > 0)
                {
                    progress_bar.Maximum = (int)duration;
                    progress_bar.Value = (int)Math.Min(current, duration);
                }
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            var state = axWindowsMediaPlayer.playState;
            if (state == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer.Ctlcontrols.pause();
            }
            else
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }
    }
}
