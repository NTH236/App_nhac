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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new login();
            frm.Show();
            this.Close();
        }
        string connectionString = "Data Source=DESKTOP-URMBO66\\SQLEXPRESS;Initial Catalog=USERS; Integrated Security=True";
        private bool isUsernameExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM LOGIN WHERE USERNAME = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void regi_btn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string account_name = Accountname.Text.Trim();
            string password = txt_password.Text.Trim();
            string conf_pass = txt_confirm_pass.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isUsernameExists(username))
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng tạo tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != conf_pass)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LOGIN(ACCOUNT_NAME, USERNAME, PASSWORD) VALUES(@account_name, @username, @password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@account_name", account_name);
                    cmd.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form frm = new login();
                        this.Close();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký Thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_password_TextChanged_1(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void txt_confirm_pass_TextChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                txt_confirm_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_confirm_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
