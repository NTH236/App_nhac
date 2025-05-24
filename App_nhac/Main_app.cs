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
    public partial class Main_app : Form
    {
        public Main_app()
        {
            InitializeComponent();
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
        private void playlist_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new playlist());
        }
        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logOut_btn_Click(object sender, EventArgs e)
        {
           
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        List<string> musicPaths = new List<string>();
        private void Main_app_Load_1(object sender, EventArgs e)
        {
            
        }

        private void media_btn_Click(object sender, EventArgs e)
        {
            string connectString = @"Data Source=DESKTOP-URMBO66\SQLEXPRESS;Initial Catalog=music; Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                string query_1 = "select top 1 id_baihat, tenbaihat, tenCaSi, theloai, linknhac from baihat, casi WHERE baihat.id_casi = casi.id_casi order by newid()";
                using (SqlCommand cmd = new SqlCommand(query_1, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Playlist_item playlist_Item = new Playlist_item();
                            playlist_Item.id = reader.GetInt32(0);
                            playlist_Item.TenBaiHat = reader.GetString(1);
                            playlist_Item.TenCaSi = reader.GetString(2);
                            playlist_Item.link_baihat = @"C:\Users\ThanhHoang\source\repos\App_nhac\" + reader.GetString(4);
                            OpenChildForm(new media(playlist_Item.link_baihat));
                        }
                    }
                }
            }
        }
        private void quit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
