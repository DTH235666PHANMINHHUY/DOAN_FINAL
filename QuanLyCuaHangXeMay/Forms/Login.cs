using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using QuanLyCuaHangXeMay.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection();

        public Login()
        {
            InitializeComponent();
            this.Load += new EventHandler(Login_Load);
            btnDangNhap.Click += new EventHandler(btnDangNhap_Click);
            btnThoat.Click += new EventHandler(btnThoat_Click);
            CPHienMK.CheckedChanged += new EventHandler(CPHienMK_CheckedChanged);
            txtMatKhau.KeyDown += new KeyEventHandler(txtMatKhau_KeyDown);

            Login_Load(null, null);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = Database.ConnectionString;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string query = "SELECT Quyen, MaNV FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Cần mã hóa trong thực tế

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string quyen = reader["Quyen"].ToString();
                            string maNV = reader["MaNV"].ToString();

                            Forms.Menu frm = new Forms.Menu(quyen, maNV);

                            frm.FormClosed += (s, args) => this.Close();

                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhau.Clear();
                            txtMatKhau.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối Cơ sở dữ liệu:\n" + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void CPHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CPHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
