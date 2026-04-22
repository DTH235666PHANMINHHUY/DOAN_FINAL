using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using QuanLyCuaHangXeMay.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class NhanVien : Form
    {
        private bool isAdd = false;

        public NhanVien()
        {
            InitializeComponent();
            this.Load += new EventHandler(NhanVien_Load);
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
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);
            dsNhanVien.CellClick += new DataGridViewCellEventHandler(dsNhanVien_CellClick);
            DrTrangChu.Click += new EventHandler(DrTrangChu_Click);
            DrNhanVien.Click += new EventHandler(DrNhanVien_Click);
            DrXeMay.Click += new EventHandler(DrXeMay_Click);
            DrHoaDon.Click += new EventHandler(DrHoaDon_Click);
            DrKhachHang.Click += new EventHandler(DrKhachHang_Click);

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxChucVu();
            LoadData();
            ToggleControls(false); // Khóa các ô nhập liệu khi mới tải Form
        }

        #region Các hàm hỗ trợ xử lý dữ liệu
        private void LoadComboBoxChucVu()
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT MaCV, TenCV FROM ChucVu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "TenCV";
                cboChucVu.ValueMember = "MaCV";
                cboChucVu.SelectedIndex = -1;
            }
        }

        private void LoadData(string searchQuery = "")
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = @"SELECT n.MaNV, n.HoLot, n.Ten, n.Phai, n.NgaySinh, n.MaCV, c.TenCV 
                                 FROM NhanVien n 
                                 INNER JOIN ChucVu c ON n.MaCV = c.MaCV ";

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE n.Ten LIKE @search OR n.HoLot LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dsNhanVien.DataSource = dt;

                // Định dạng hiển thị DataGridView
                dsNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                dsNhanVien.Columns["HoLot"].HeaderText = "Họ lót";
                dsNhanVien.Columns["Ten"].HeaderText = "Tên";
                dsNhanVien.Columns["Phai"].HeaderText = "Phái";
                dsNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dsNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dsNhanVien.Columns["TenCV"].HeaderText = "Chức vụ";
                dsNhanVien.Columns["MaCV"].Visible = false; // Ẩn cột Mã chức vụ
                dsNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ToggleControls(bool isEditing)
        {
            // Bật/tắt các ô nhập liệu
            txtMaNV.Enabled = isEditing;
            txtHoTenLot.Enabled = isEditing;
            txtTen.Enabled = isEditing;
            rdbNam.Enabled = isEditing;
            rdbNu.Enabled = isEditing;
            dtpNgaySinh.Enabled = isEditing;
            cboChucVu.Enabled = isEditing;

            // Bật/tắt các nút thao tác
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
        }

        private void ClearInputs()
        {
            txtMaNV.Clear();
            txtHoTenLot.Clear();
            txtTen.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cboChucVu.SelectedIndex = -1;
        }
        #endregion

        #region Xử lý Sự kiện các Nút (Buttons)
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearInputs();
            ToggleControls(true);
            txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdd = false;
            ToggleControls(true);
            txtMaNV.Enabled = false; // Không cho phép sửa Mã nhân viên
            txtHoTenLot.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa (Có thể nhân viên này đang có Hóa đơn): \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Ràng buộc dữ liệu
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTen.Text) ||
                cboChucVu.SelectedValue == null || (!rdbNam.Checked && !rdbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (isAdd)
                    {
                        // Kiểm tra trùng Mã nhân viên
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV", conn);
                        checkCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.CommandText = "INSERT INTO NhanVien (MaNV, HoLot, Ten, Phai, NgaySinh, MaCV) VALUES (@MaNV, @HoLot, @Ten, @Phai, @NgaySinh, @MaCV)";
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE NhanVien SET HoLot = @HoLot, Ten = @Ten, Phai = @Phai, NgaySinh = @NgaySinh, MaCV = @MaCV WHERE MaNV = @MaNV";
                    }

                    // Truyền tham số an toàn (Chống SQL Injection)
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@HoLot", txtHoTenLot.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@Phai", phai);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@MaCV", cboChucVu.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ToggleControls(false);
                    LoadData();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled) // Nếu đang thao tác dở dang
            {
                if (MessageBox.Show("Thao tác chưa được lưu! Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTim.Focus();
                return;
            }
            LoadData(txtTim.Text.Trim());
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            LoadData();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                formBaoCao frm = new formBaoCao(2); // Truyền ID báo cáo (2 = Nhân viên)
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khởi tạo báo cáo: " + ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dsNhanVien.Rows.Count == 0 || dsNhanVien.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "DS_NhanVien.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Danh sách");
                        for (int i = 0; i < dsNhanVien.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dsNhanVien.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }
                        for (int i = 0; i < dsNhanVien.Rows.Count; i++)
                        {
                            for (int j = 0; j < dsNhanVien.Columns.Count; j++)
                                worksheet.Cell(i + 2, j + 1).Value = dsNhanVien.Rows[i].Cells[j].Value?.ToString();
                        }
                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHienThi_Click(sender, e);
                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Escape
            }
        }
        #endregion

        #region Xử lý GridView và Menu
        private void dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled) // Chỉ cho phép xem khi không ở trạng thái Thêm/Sửa
            {
                DataGridViewRow row = dsNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTenLot.Text = row.Cells["HoLot"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();

                string phai = row.Cells["Phai"].Value.ToString();
                if (phai == "Nam") rdbNam.Checked = true;
                else if (phai == "Nữ") rdbNu.Checked = true;

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                cboChucVu.SelectedValue = row.Cells["MaCV"].Value.ToString();
            }
        }

        private void DrTrangChu_Click(object sender, EventArgs e) { new Menu().Show(); this.Close(); }
        private void DrNhanVien_Click(object sender, EventArgs e) { new NhanVien().Show(); this.Close(); }
        private void DrXeMay_Click(object sender, EventArgs e) { new XeMay().Show(); this.Close(); }
        private void DrHoaDon_Click(object sender, EventArgs e) { new HoaDon().Show(); this.Close(); }
        private void DrKhachHang_Click(object sender, EventArgs e) { new KhachHang().Show(); this.Close(); }
        #endregion
    }
}