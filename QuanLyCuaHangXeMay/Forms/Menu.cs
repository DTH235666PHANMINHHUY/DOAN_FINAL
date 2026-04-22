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

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class Menu : Form
    {

        private string userQuyen;
        private string userMaNV;
        private Form frm = new Form();

        public Menu()
        {
            InitializeComponent();
            this.Load += new EventHandler(Menu_Load);
            btnNhanVien.Click += new EventHandler(btnNhanVien_Click);
            btnHoaDon.Click += new EventHandler(btnHoaDon_Click);
            btnXeMay.Click += new EventHandler(btnXeMay_Click);
            btnKhachHang.Click += new EventHandler(btnKhachHang_Click);
            btnThoat.Click += new EventHandler(btnThoat_Click);
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);

            Menu_Load(null, null);
        }

        public Menu(string quyen, string maNV)
        {
            InitializeComponent();
            this.Load += new EventHandler(Menu_Load);
            btnNhanVien.Click += new EventHandler(btnNhanVien_Click);
            btnHoaDon.Click += new EventHandler(btnHoaDon_Click);
            btnXeMay.Click += new EventHandler(btnXeMay_Click);
            btnKhachHang.Click += new EventHandler(btnKhachHang_Click);
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);

            Menu_Load(null, null);

            this.userQuyen = quyen;
            this.userMaNV = maNV;
            HienThiTenNhanVien(quyen);
            KiemTraQuyen(quyen);
            // Dựa vào userQuyen để ẩn/hiện các chức năng quản trị
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void KiemTraQuyen(string quyen)
        {
            string QuyenUser = quyen.ToUpper();

            if (QuyenUser != "ADMIN")
            {
                btnNhanVien.Enabled = false;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.frm = new NhanVien();
            this.frm.StartPosition = FormStartPosition.CenterScreen;
            this.frm.Show();
        }

        private void btnXeMay_Click(object sender, EventArgs e)
        {
            this.frm = new XeMay();
            this.frm.StartPosition = FormStartPosition.CenterScreen;
            this.frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.frm = new HoaDon();
            this.frm.StartPosition = FormStartPosition.CenterScreen;
            this.frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.frm = new KhachHang();
            this.frm.StartPosition = FormStartPosition.CenterScreen;
            this.frm.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có muốn thoát?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                    Application.Exit();
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void HienThiTenNhanVien(string quyen)
        {
            string query = "SELECT HoLot, Ten FROM NhanVien WHERE MaNV = @maNV";

            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", userMaNV);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string tenDayDu = reader["HoLot"].ToString() + " " + reader["Ten"].ToString() + " (" + quyen + ")";
                            // Gán tên vào Label (giả sử là lblTen)
                            lblTen.Text = tenDayDu;
                        }
                    }
                    catch { return; }
                }
            }
        }
    }
}
