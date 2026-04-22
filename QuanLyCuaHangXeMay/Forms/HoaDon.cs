using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class HoaDon : Form
    {
        private bool isAdd = false; // Cờ theo dõi trạng thái Thêm hay Sửa
        private DataTable dtXeMayCache = new DataTable(); // Cache bảng xe máy để tra cứu giá lập tức

        public HoaDon()
        {
            InitializeComponent();
            this.Load += new EventHandler(HoaDon_Load);

            // Gắn sự kiện cho các nút chức năng chính
            btnThem.Click += new EventHandler(btnThem_Click);
            btnSua.Click += new EventHandler(btnSua_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnLuu.Click += new EventHandler(btnLuu_Click);
            btnHuy.Click += new EventHandler(btnHuy_Click);
            btnThoat.Click += new EventHandler(btnThoat_Click);

            // Gắn sự kiện các nút tiện ích
            btnTim.Click += new EventHandler(btnTim_Click);
            btnHienThi.Click += new EventHandler(btnHienThi_Click);
            btnInBaoCao.Click += new EventHandler(btnInBaoCao_Click);
            btnXuatExcel.Click += new EventHandler(btnXuatExcel_Click);

            // Gắn sự kiện DataGridView
            dsHoaDon.CellClick += new DataGridViewCellEventHandler(dsHoaDon_CellClick);

            // Gắn sự kiện tính tiền tự động khi thay đổi Xe hoặc Số lượng
            cboMaXe.SelectedIndexChanged += new EventHandler(cboMaXe_SelectedIndexChanged);
            numSoLuong.ValueChanged += new EventHandler(numSoLuong_ValueChanged);
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);

            // Menu
            DrTrangChu.Click += new EventHandler(DrTrangChu_Click);
            DrNhanVien.Click += new EventHandler(DrNhanVien_Click);
            DrXeMay.Click += new EventHandler(DrXeMay_Click);
            DrHoaDon.Click += new EventHandler(DrHoaDon_Click);
            DrKhachHang.Click += new EventHandler(DrKhachHang_Click);

            // Định dạng bộ chọn ngày và input số lượng
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            numSoLuong.Minimum = 0;
            numSoLuong.Maximum = 100;
            numSoLuong.DecimalPlaces = 0;
            numSoLuong.ThousandsSeparator = true;
            numSoLuong.Increment = 1;
            numThanhTien.Minimum = 0;
            numThanhTien.Maximum = Decimal.MaxValue;
            numThanhTien.DecimalPlaces = 0;
            numThanhTien.ThousandsSeparator = true;
            numThanhTien.Increment = 0;
            numThanhTien.Controls[0].Hide();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            numThanhTien.ReadOnly = true; // Khóa không cho người dùng tự gõ tiền
            LoadCacheGiaXe(); // Tải sẵn danh sách giá xe vào bộ nhớ
            LoadComboBoxes(); // Đổ dữ liệu vào 3 ComboBox
            LoadData(); // Tải danh sách Hóa đơn
            ToggleControls(false); // Đưa form về trạng thái khóa mặc định
        }

        #region Các hàm hỗ trợ xử lý dữ liệu
        private void LoadComboBoxes()
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                // Load dữ liệu Nhân Viên vào cbo
                SqlDataAdapter daNV = new SqlDataAdapter("SELECT MaNV, HoLot + ' ' + Ten AS TenNV FROM NhanVien", conn);
                DataTable dtNV = new DataTable();
                daNV.Fill(dtNV);
                cbo.DataSource = dtNV;
                cbo.DisplayMember = "TenNV";
                cbo.ValueMember = "MaNV";

                // Load dữ liệu Khách Hàng vào cboMaKH
                SqlDataAdapter daKH = new SqlDataAdapter("SELECT MaKH, HoTen FROM KhachHang", conn);
                DataTable dtKH = new DataTable();
                daKH.Fill(dtKH);
                cboMaKH.DataSource = dtKH;
                cboMaKH.DisplayMember = "HoTen";
                cboMaKH.ValueMember = "MaKH";

                // Load dữ liệu Xe Máy vào cboMaXe
                SqlDataAdapter daXe = new SqlDataAdapter("SELECT MaXe, TenXe FROM XeMay", conn);
                DataTable dtXe = new DataTable();
                daXe.Fill(dtXe);
                cboMaXe.DataSource = dtXe;
                cboMaXe.DisplayMember = "TenXe";
                cboMaXe.ValueMember = "MaXe";
            }
        }

        private void LoadCacheGiaXe()
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaXe, GiaBan FROM XeMay", conn);
                dtXeMayCache.Clear();
                da.Fill(dtXeMayCache);
            }
        }

        private void LoadData(string searchQuery = "")
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = @"
                    SELECT hd.MaHD, hd.NgayLap, 
                           hd.MaNV, nv.HoLot + ' ' + nv.Ten AS TenNV, 
                           hd.MaKH, kh.HoTen AS TenKH, 
                           hd.MaXe, xm.TenXe, 
                           hd.SoLuong, hd.ThanhTien 
                    FROM HoaDon hd
                    INNER JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                    INNER JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                    INNER JOIN XeMay xm ON hd.MaXe = xm.MaXe";

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE hd.MaHD LIKE @search OR kh.HoTen LIKE @search";
                }

                query += " ORDER BY hd.NgayLap DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dsHoaDon.DataSource = dt;

                // Tùy chỉnh GridView
                dsHoaDon.Columns["MaHD"].HeaderText = "Mã HĐ";
                dsHoaDon.Columns["NgayLap"].HeaderText = "Ngày lập";
                dsHoaDon.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dsHoaDon.Columns["TenNV"].HeaderText = "Nhân viên";
                dsHoaDon.Columns["TenKH"].HeaderText = "Khách hàng";
                dsHoaDon.Columns["TenXe"].HeaderText = "Tên xe máy";
                dsHoaDon.Columns["SoLuong"].HeaderText = "Số lượng";
                dsHoaDon.Columns["ThanhTien"].HeaderText = "Thành tiền";

                dsHoaDon.Columns["MaNV"].Visible = false;
                dsHoaDon.Columns["MaKH"].Visible = false;
                dsHoaDon.Columns["MaXe"].Visible = false;

                dsHoaDon.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dsHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ToggleControls(bool isEditing)
        {
            grpTaoMoi.Enabled = isEditing;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
        }

        private void ClearInputs()
        {
            txtMaHD.Clear();
            cbo.SelectedIndex = -1; // Xóa trạng thái chọn của ComboBox Nhân Viên
            cboMaKH.SelectedIndex = -1; // Khách Hàng
            cboMaXe.SelectedIndex = -1; // Xe Máy
            numSoLuong.Value = 0;
            numThanhTien.Value = 0;
            dtpNgayLap.Value = DateTime.Now;
        }

        private void TinhThanhTien()
        {
            if (cboMaXe.SelectedValue == null || numSoLuong.Value <= 0)
            {
                numThanhTien.Value = 0;
                return;
            }

            decimal giaBan = 0;
            foreach (DataRow row in dtXeMayCache.Rows)
            {
                if (row["MaXe"].ToString().Equals(cboMaXe.SelectedValue.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    giaBan = Convert.ToDecimal(row["GiaBan"]);
                    break;
                }
            }

            decimal thanhTien = giaBan * numSoLuong.Value;
            numThanhTien.Text = thanhTien.ToString("N0");
        }
        #endregion

        #region Xử lý Sự kiện các Nút (Buttons)
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearInputs();
            ToggleControls(true);
            txtMaHD.Enabled = true; // Cho phép nhập khóa chính
            txtMaHD.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdd = false;
            ToggleControls(true);
            txtMaHD.Enabled = false; // Khóa trường Mã HĐ
            cbo.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn giá trị ở ComboBox chưa
            if (string.IsNullOrEmpty(txtMaHD.Text) || cbo.SelectedValue == null ||
                cboMaKH.SelectedValue == null || cboMaXe.SelectedValue == null || numSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mã liên kết và số lượng lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                {
                    conn.Open();

                    // Lấy Giá Bán trực tiếp từ DB để đảm bảo tính an toàn
                    SqlCommand cmdPrice = new SqlCommand("SELECT GiaBan FROM XeMay WHERE MaXe = @MaXe", conn);
                    cmdPrice.Parameters.AddWithValue("@MaXe", cboMaXe.SelectedValue.ToString());
                    object priceObj = cmdPrice.ExecuteScalar();

                    if (priceObj == null)
                    {
                        MessageBox.Show("Mã xe máy không tồn tại trong hệ thống!", "Lỗi liên kết", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboMaXe.Focus();
                        return;
                    }

                    decimal thanhTien = Convert.ToDecimal(priceObj) * numSoLuong.Value;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (isAdd) // TRẠNG THÁI THÊM
                    {
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM HoaDon WHERE MaHD = @MaHD", conn);
                        checkCmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Mã hóa đơn đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaHD.Focus();
                            return;
                        }

                        cmd.CommandText = "INSERT INTO HoaDon (MaHD, MaNV, MaKH, MaXe, NgayLap, SoLuong, ThanhTien) VALUES (@MaHD, @MaNV, @MaKH, @MaXe, @NgayLap, @SoLuong, @ThanhTien)";
                    }
                    else // TRẠNG THÁI SỬA
                    {
                        cmd.CommandText = "UPDATE HoaDon SET MaNV = @MaNV, MaKH = @MaKH, MaXe = @MaXe, NgayLap = @NgayLap, SoLuong = @SoLuong, ThanhTien = @ThanhTien WHERE MaHD = @MaHD";
                    }

                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaNV", cbo.SelectedValue.ToString()); // Dùng SelectedValue để truyền Mã vào DB
                    cmd.Parameters.AddWithValue("@MaKH", cboMaKH.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaXe", cboMaXe.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value);
                    cmd.Parameters.AddWithValue("@SoLuong", numSoLuong.Value);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ToggleControls(false);
                    LoadData();
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Lỗi SQL: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ToggleControls(false); // Trả về trạng thái ban đầu
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                if (MessageBox.Show("Thao tác chưa được lưu! Xác nhận thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoá đơn hoặc tên khách hàng cần tìm!");
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
                formBaoCao frm = new formBaoCao(1); // Truyền ID báo cáo (1 = Hóa đơn)
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khởi tạo báo cáo: " + ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dsHoaDon.Rows.Count == 0 || dsHoaDon.Rows[0].Cells[0].Value == null)
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
                        for (int i = 0; i < dsHoaDon.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dsHoaDon.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }
                        for (int i = 0; i < dsHoaDon.Rows.Count; i++)
                        {
                            for (int j = 0; j < dsHoaDon.Columns.Count; j++)
                                worksheet.Cell(i + 2, j + 1).Value = dsHoaDon.Rows[i].Cells[j].Value?.ToString();
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

        #region Xử lý Sự kiện DataGridView và Menu
        private void dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dsHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHD"].Value?.ToString();

                // Đồng bộ ngược từ Lưới lên các ComboBox bằng SelectedValue
                cbo.SelectedValue = row.Cells["MaNV"].Value?.ToString();
                cboMaKH.SelectedValue = row.Cells["MaKH"].Value?.ToString();
                cboMaXe.SelectedValue = row.Cells["MaXe"].Value?.ToString();

                if (row.Cells["NgayLap"].Value != DBNull.Value)
                    dtpNgayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);

                if (row.Cells["SoLuong"].Value != DBNull.Value)
                    numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);

                if (row.Cells["ThanhTien"].Value != DBNull.Value)
                {
                    decimal tt = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    numThanhTien.Text = tt.ToString("N0");
                }
            }
        }

        private void cboMaXe_SelectedIndexChanged(object sender, EventArgs e) { TinhThanhTien(); }
        private void numSoLuong_ValueChanged(object sender, EventArgs e) { TinhThanhTien(); }
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

        private void DrTrangChu_Click(object sender, EventArgs e) { new Menu().Show(); this.Close(); }
        private void DrNhanVien_Click(object sender, EventArgs e) { new NhanVien().Show(); this.Close(); }
        private void DrXeMay_Click(object sender, EventArgs e) { new XeMay().Show(); this.Close(); }
        private void DrHoaDon_Click(object sender, EventArgs e) { new HoaDon().Show(); this.Close(); }
        private void DrKhachHang_Click(object sender, EventArgs e) { new KhachHang().Show(); this.Close(); }
        #endregion
    }
}