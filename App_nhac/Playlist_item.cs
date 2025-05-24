using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_nhac
{
    public partial class Playlist_item : UserControl
    {
        public Playlist_item()
        {
            InitializeComponent();
            this.Click += OnClick;
            song_name.Click += OnClick;
            song_img.Click += OnClick;
        }

        private void Playlist_item_Load(object sender, EventArgs e)
        {
            
        }
        public string TenBaiHat
        {
            get { return song_name.Text; }
            set { song_name.Text = value; }
        }
        public string TenCaSi
        {
            get { return casi_name.Text; }
            set { casi_name.Text = value; }
        }
        public int id
        {
            get { return int.Parse(id_baihat.Text); }
            set { id_baihat.Text = value.ToString(); }
        }
        public string link_baihat
        {
            get { return link.Text; }
            set { link.Text = value; }
        }
        
        
        public event EventHandler<string> SongClicked;
        private void OnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(link_baihat))
            {
                SongClicked?.Invoke(this, link_baihat);
            }
        }
        private void song_name_Click(object sender, EventArgs e)
        {

        }

        private void casi_name_Click(object sender, EventArgs e)
        {

        }
    }
}
