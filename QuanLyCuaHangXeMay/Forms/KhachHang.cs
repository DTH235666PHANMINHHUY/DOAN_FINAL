using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using QuanLyCuaHangXeMay.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class KhachHang : Form
    {
        private bool isAdd = false; // Cờ theo dõi trạng thái Thêm hay Sửa

        public KhachHang()
        {
            InitializeComponent();

            this.Load += new EventHandler(KhachHang_Load);

            // Đăng ký sự kiện cho các nút thao tác
            btnThem.Click += new EventHandler(btnThem_Click);
            btnSua.Click += new EventHandler(btnSua_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnLuu.Click += new EventHandler(btnLuu_Click);
            btnHuy.Click += new EventHandler(btnHuy_Click);
            btnThoat.Click += new EventHandler(btnThoat_Click);
            btnTim.Click += new EventHandler(btnTim_Click);
            btnHienThi.Click += new EventHandler(btnHienThi_Click);
            btnInBaoCao.Click += new EventHandler(btnInBaoCao_Click);
            btnXuatExcel.Click += new EventHandler(btnXuatExcel_Click);

            // Đăng ký sự kiện cho TextBox tìm kiếm (nhấn Enter để tìm, Escape để hiện thị lại toàn bộ)
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);

            // Đăng ký sự kiện Click lên lưới DataGridView
            dsKhachHang.CellClick += new DataGridViewCellEventHandler(dsKhachHang_CellClick);

            // Đăng ký sự kiện cho thanh Menu
            DrTrangChu.Click += new EventHandler(DrTrangChu_Click);
            DrNhanVien.Click += new EventHandler(DrNhanVien_Click);
            DrXeMay.Click += new EventHandler(DrXeMay_Click);
            DrHoaDon.Click += new EventHandler(DrHoaDon_Click);
            DrKhachHang.Click += new EventHandler(DrKhachHang_Click);
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ToggleControls(false); // Vô hiệu hóa các ô nhập liệu ban đầu
        }

        #region Các hàm hỗ trợ xử lý dữ liệu
        private void LoadData(string searchQuery = "")
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT MaKH, HoTen, Phai, DiaChi, SDT, GhiChu FROM KhachHang";

                // Nếu có từ khóa tìm kiếm
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE HoTen LIKE @search OR MaKH LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dsKhachHang.DataSource = dt;

                // Tùy chỉnh tiêu đề cột trên DataGridView
                dsKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                dsKhachHang.Columns["HoTen"].HeaderText = "Họ tên";
                dsKhachHang.Columns["Phai"].HeaderText = "Phái";
                dsKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dsKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
                dsKhachHang.Columns["GhiChu"].HeaderText = "Ghi chú";

                dsKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ToggleControls(bool isEditing)
        {
            // Bật/tắt các ô nhập liệu
            txtMaKH.Enabled = isEditing;
            txtHoTen.Enabled = isEditing;
            txtDiaChi.Enabled = isEditing;
            txtSDT.Enabled = isEditing;
            txtGhiChu.Enabled = isEditing;
            rdbNam.Enabled = isEditing;
            rdbNu.Enabled = isEditing;

            // Bật/tắt các nút thao tác
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
        }

        private void ClearInputs()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
        }
        #endregion

        #region Xử lý Sự kiện các Nút (Buttons)
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearInputs();
            ToggleControls(true);
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdd = false;
            ToggleControls(true);
            txtMaKH.Enabled = false; // Không cho phép sửa Mã khách hàng (Khóa chính)
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa (Có thể khách hàng này đang có hóa đơn giao dịch): \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu đầu vào
            if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtHoTen.Text) || (!rdbNam.Checked && !rdbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã, Họ tên và Phái khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phai = rdbNam.Checked ? "Nam" : "Nữ";

            try
            {
                using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (isAdd) // Nếu đang ở trạng thái thêm mới
                    {
                        // Kiểm tra trùng Mã Khách Hàng
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH", conn);
                        checkCmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Mã khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.CommandText = "INSERT INTO KhachHang (MaKH, HoTen, Phai, DiaChi, SDT, GhiChu) VALUES (@MaKH, @HoTen, @Phai, @DiaChi, @SDT, @GhiChu)";
                    }
                    else // Trạng thái sửa (Update)
                    {
                        cmd.CommandText = "UPDATE KhachHang SET HoTen = @HoTen, Phai = @Phai, DiaChi = @DiaChi, SDT = @SDT, GhiChu = @GhiChu WHERE MaKH = @MaKH";
                    }

                    // Truyền tham số để tránh lỗi SQL Injection
                    cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@DiaChi", string.IsNullOrEmpty(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@SDT", string.IsNullOrEmpty(txtSDT.Text) ? (object)DBNull.Value : txtSDT.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrEmpty(txtGhiChu.Text) ? (object)DBNull.Value : txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu dữ liệu khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ToggleControls(false); // Khóa lại Form
                    LoadData(); // Cập nhật lại GridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ToggleControls(false);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc mã khách hàng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTim.Focus();
                return;
            }
            LoadData(txtTim.Text.Trim());
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            LoadData(); // Load lại toàn bộ danh sách không có điều kiện lọc
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled) // Đang trong quá trình thêm/sửa mà nhấn Thoát
            {
                if (MessageBox.Show("Thao tác chưa được lưu! Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            this.Close();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                formBaoCao frm = new formBaoCao(4); // Truyền ID báo cáo (4 = Khách hàng)
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khởi tạo báo cáo: " + ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dsKhachHang.Rows.Count == 0 || dsKhachHang.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "DS_HoaDon.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Danh sách");
                        for (int i = 0; i < dsKhachHang.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dsKhachHang.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }
                        for (int i = 0; i < dsKhachHang.Rows.Count; i++)
                        {
                            for (int j = 0; j < dsKhachHang.Columns.Count; j++)
                                worksheet.Cell(i + 2, j + 1).Value = dsKhachHang.Rows[i].Cells[j].Value?.ToString();
                        }
                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        #endregion

        #region Xử lý Sự kiện GridView và MenuStrip
        private void dsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu người dùng click vào dòng hợp lệ và không ở chế độ Đang sửa/thêm
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dsKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

                string phai = row.Cells["Phai"].Value.ToString();
                if (phai == "Nam") rdbNam.Checked = true;
                else if (phai == "Nữ") rdbNu.Checked = true;
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.Handled = true; // Ngăn chặn tiếng "ding" khi nhấn Enter
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHienThi_Click(sender, e);
                e.Handled = true; // Ngăn chặn tiếng "ding" khi nhấn Escape
            }
        }

        // Chuyển hướng các Menu Form
        private void DrTrangChu_Click(object sender, EventArgs e) { new Menu().Show(); this.Close(); }
        private void DrNhanVien_Click(object sender, EventArgs e) { new NhanVien().Show(); this.Close(); }
        private void DrXeMay_Click(object sender, EventArgs e) { new XeMay().Show(); this.Close(); }
        private void DrHoaDon_Click(object sender, EventArgs e) { new HoaDon().Show(); this.Close(); }
        private void DrKhachHang_Click(object sender, EventArgs e) { new KhachHang().Show(); this.Close(); }
        #endregion
    }
}