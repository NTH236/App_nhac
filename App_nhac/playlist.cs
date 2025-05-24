using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_nhac
{
    public partial class playlist : Form
    {
        public playlist()
        {
            InitializeComponent();
            axWindowsMediaPlayer.Visible = true;
        }
        private void OpenChildForm(Form childForm)
        {
            main_panel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            main_panel.Controls.Add(childForm);
            childForm.Show();
        }
        string connectString = @"Data Source=DESKTOP-URMBO66\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=music";        
        private void Playlist_item_SongClicked(object sender, string path)
        {
            OpenChildForm(new media(path));
        }
        private void list_songs()
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string query_1 = "select id_baihat, tenbaihat, tenCaSi, theloai, linknhac from baihat, casi WHERE baihat.id_casi = casi.id_casi and theloai = @theloai order by newid()";
                using (SqlCommand cmd = new SqlCommand(query_1, conn))
                {
                    cmd.Parameters.AddWithValue("@theloai", "Nhạc trẻ");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //List<Playlist_item> list_song1 = new List<Playlist_item>();
                        while (reader.Read())
                        {
                            Playlist_item playlist_Item = new Playlist_item();
                            playlist_Item.id = reader.GetInt32(0);
                            playlist_Item.TenBaiHat = reader.GetString(1);
                            playlist_Item.TenCaSi = reader.GetString(2);
                            playlist_Item.link_baihat = @"C:\Users\ThanhHoang\source\repos\App_nhac\" + reader.GetString(4);
                            playlist_Item.SongClicked += Playlist_item_SongClicked;
                            nhac_tre.Controls.Add(playlist_Item);
                        }
                        title_song1.Text = "Nhạc trẻ";
                    }
                }
                string query_2 = "select id_baihat, tenbaihat, tenCaSi, theloai, linknhac from baihat, casi WHERE baihat.id_casi = casi.id_casi and theloai = @theloai order by newid()";
                using (SqlCommand cmd = new SqlCommand(query_2, conn))
                {
                    cmd.Parameters.AddWithValue("@theloai", "Nhạc âu");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //List<Playlist_item> list_song2 = new List<Playlist_item>();
                        while (reader.Read())
                        {
                            Playlist_item playlist_Item = new Playlist_item();
                            playlist_Item.id = reader.GetInt32(0);
                            playlist_Item.TenBaiHat = reader.GetString(1);
                            playlist_Item.TenCaSi = reader.GetString(2);
                            playlist_Item.link_baihat = @"C:\Users\ThanhHoang\source\repos\App_nhac\" + reader.GetString(4);
                            playlist_Item.SongClicked += Playlist_item_SongClicked;
                            nhac_au.Controls.Add(playlist_Item);
                        }
                        title_song2.Text = "Nhạc Âu";
                    }
                }
            }
        }
        
        private void playlist_Load(object sender, EventArgs e)
        {
            list_songs();
        }

        private void listmusic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
