using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_nhac
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-URMBO66\\SQLEXPRESS;Initial Catalog=USERS; Integrated Security=True";
        private bool CheckLogin(string username, string password)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM LOGIN WHERE USERNAME = @username AND PASSWORD = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    result = count > 0;
                }
            }
            return result;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Boolean check = this.checkBox1.Checked;
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (CheckLogin(username, password) && check == true)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form frm = new Main_app();
                frm.ShowDialog();
            }
            else if (check == false)
            {
                MessageBox.Show("Đọc và đồng ý các chính sách của chúng tôi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new register();
            frm.ShowDialog();
        }

        private void txt_password_TextChanged_1(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }
    }
}
