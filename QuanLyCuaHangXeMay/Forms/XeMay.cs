using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using QuanLyCuaHangXeMay.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class XeMay : Form
    {
        private bool isAdd = false;

        public XeMay()
        {
            InitializeComponent();

            this.Load += new EventHandler(XeMay_Load);
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
            dsXeMay.CellClick += new DataGridViewCellEventHandler(dsXeMay_CellClick);

            DrTrangChu.Click += new EventHandler(DrTrangChu_Click);
            DrNhanVien.Click += new EventHandler(DrNhanVien_Click);
            DrXeMay.Click += new EventHandler(DrXeMay_Click);
            DrHoaDon.Click += new EventHandler(DrHoaDon_Click);
            DrKhachHang.Click += new EventHandler(DrKhachHang_Click);

            numGiaBan.Minimum = 0;
            numGiaBan.Maximum = Decimal.MaxValue;
            numGiaBan.DecimalPlaces = 0;
            numGiaBan.ThousandsSeparator = true;
            numGiaBan.Increment = 1000;
        }

        private void XeMay_Load(object sender, EventArgs e)
        {
            LoadComboBoxHangXe();
            LoadData();
            ToggleControls(false);
        }

        #region Các hàm hỗ trợ và xử lý dữ liệu
        private void LoadComboBoxHangXe()
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = "SELECT MaHang, TenHang FROM HangXe";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboHangXe.DataSource = dt;
                cboHangXe.DisplayMember = "TenHang";
                cboHangXe.ValueMember = "MaHang";
                cboHangXe.SelectedIndex = -1;
            }
        }

        private void LoadData(string searchQuery = "")
        {
            using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
            {
                string query = @"SELECT x.MaXe, x.TenXe, x.LoaiXe, x.MauSac, x.GiaBan, x.MaHang, h.TenHang 
                                 FROM XeMay x 
                                 INNER JOIN HangXe h ON x.MaHang = h.MaHang";

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE x.TenXe LIKE @search OR x.MaXe LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dsXeMay.DataSource = dt;

                // Tùy chỉnh tiêu đề cột trên DataGridView
                dsXeMay.Columns["MaXe"].HeaderText = "Mã Xe";
                dsXeMay.Columns["TenXe"].HeaderText = "Tên xe";
                dsXeMay.Columns["LoaiXe"].HeaderText = "Loại xe";
                dsXeMay.Columns["MauSac"].HeaderText = "Màu sắc";
                dsXeMay.Columns["GiaBan"].HeaderText = "Giá bán";
                dsXeMay.Columns["TenHang"].HeaderText = "Hãng xe";

                dsXeMay.Columns["MaHang"].Visible = false; // Ẩn cột Mã Hãng Xe

                // Format cột giá bán theo kiểu tiền tệ (#,##0)
                dsXeMay.Columns["GiaBan"].DefaultCellStyle.Format = "N0";

                dsXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ToggleControls(bool isEditing)
        {
            // Bật/tắt các ô nhập liệu
            txtMaXe.Enabled = isEditing;
            txtTenXe.Enabled = isEditing;
            txtLoaiXe.Enabled = isEditing;
            txtMauSac.Enabled = isEditing;
            numGiaBan.Enabled = isEditing;
            cboHangXe.Enabled = isEditing;

            // Bật/tắt các nút thao tác
            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnHuy.Enabled = isEditing;
        }

        private void ClearInputs()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            txtLoaiXe.Clear();
            txtMauSac.Clear();
            numGiaBan.Value = 0;
            cboHangXe.SelectedIndex = -1;
        }
        #endregion

        #region Xử lý sự kiện các Nút (Buttons)
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearInputs();
            ToggleControls(true);
            txtMaXe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe máy cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isAdd = false;
            ToggleControls(true);
            txtMaXe.Enabled = false; // Không cho phép sửa Mã xe (Khóa chính)
            txtTenXe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaXe.Text))
            {
                MessageBox.Show("Vui lòng chọn xe máy cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng xe này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM XeMay WHERE MaXe = @MaXe";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa (Có thể xe này đã có trong hóa đơn giao dịch): \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu đầu vào
            if (string.IsNullOrEmpty(txtMaXe.Text) || string.IsNullOrEmpty(txtTenXe.Text) || cboHangXe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã xe, Tên xe và Hãng xe!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ép kiểu Giá Bán sang kiểu Decimal hợp lệ để lưu vào SQL
            decimal giaBan = 0;
            if (!string.IsNullOrEmpty(numGiaBan.Text) && !decimal.TryParse(numGiaBan.Text, out giaBan))
            {
                MessageBox.Show("Giá bán phải là một số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numGiaBan.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (isAdd) // Nếu đang ở trạng thái thêm mới
                    {
                        // Kiểm tra trùng Mã Xe
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM XeMay WHERE MaXe = @MaXe", conn);
                        checkCmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Mã xe này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.CommandText = "INSERT INTO XeMay (MaXe, LoaiXe, TenXe, MaHang, MauSac, GiaBan) VALUES (@MaXe, @LoaiXe, @TenXe, @MaHang, @MauSac, @GiaBan)";
                    }
                    else // Trạng thái sửa (Update)
                    {
                        cmd.CommandText = "UPDATE XeMay SET LoaiXe = @LoaiXe, TenXe = @TenXe, MaHang = @MaHang, MauSac = @MauSac, GiaBan = @GiaBan WHERE MaXe = @MaXe";
                    }

                    // Truyền tham số để tránh lỗi SQL Injection
                    cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                    cmd.Parameters.AddWithValue("@LoaiXe", string.IsNullOrEmpty(txtLoaiXe.Text) ? (object)DBNull.Value : txtLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@MaHang", cboHangXe.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MauSac", string.IsNullOrEmpty(txtMauSac.Text) ? (object)DBNull.Value : txtMauSac.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", giaBan);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thông tin xe máy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled) // Đang trong quá trình thêm/sửa mà nhấn Thoát
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
                MessageBox.Show("Vui lòng nhập mã xe hoặc tên xe cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                formBaoCao frm = new formBaoCao(3); // Truyền ID báo cáo (3 = Xe máy)
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khởi tạo báo cáo: " + ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dsXeMay.Rows.Count == 0 || dsXeMay.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "DS_XeMay.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Danh sách");
                        for (int i = 0; i < dsXeMay.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dsXeMay.Columns[i].HeaderText;
                            worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        }
                        for (int i = 0; i < dsXeMay.Rows.Count; i++)
                        {
                            for (int j = 0; j < dsXeMay.Columns.Count; j++)
                                worksheet.Cell(i + 2, j + 1).Value = dsXeMay.Rows[i].Cells[j].Value?.ToString();
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

        #region Xử lý sự kiện khác (KeyDown, CellClick, Menu)
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e); // Gọi sự kiện tìm kiếm khi nhấn Enter
                e.Handled = true; // Ngăn chặn tiếng bíp khi nhấn Enter
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHienThi_Click(sender, e); // Gọi sự kiện hiển thị lại toàn bộ danh sách khi nhấn Escape
                e.Handled = true; // Ngăn chặn tiếng bíp khi nhấn Escape
            }
        }

        private void dsXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu người dùng click vào dòng hợp lệ và không ở chế độ Đang sửa/thêm
            if (e.RowIndex >= 0 && !btnLuu.Enabled)
            {
                DataGridViewRow row = dsXeMay.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["MaXe"].Value.ToString();
                txtTenXe.Text = row.Cells["TenXe"].Value.ToString();
                txtLoaiXe.Text = row.Cells["LoaiXe"].Value.ToString();
                txtMauSac.Text = row.Cells["MauSac"].Value.ToString();

                // Xử lý loại bỏ phần thập phân dư thừa nếu có khi lấy Giá bán lên Textbox
                if (row.Cells["GiaBan"].Value != DBNull.Value)
                {
                    decimal giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                    numGiaBan.Text = Math.Round(giaBan, 0).ToString();
                }
                else
                {
                    numGiaBan.Text = "";
                }

                cboHangXe.SelectedValue = row.Cells["MaHang"].Value.ToString();
            }
        }

        // Chuyển hướng các Menu Form
        private void DrTrangChu_Click(object sender, EventArgs e) { new Menu().Show(); this.Close(); }
        private void DrNhanVien_Click(object sender, EventArgs e) { new NhanVien().Show(); this.Close(); }
        private void DrXeMay_Click(object sender, EventArgs e) { /* Đang mở Form này */ }
        private void DrHoaDon_Click(object sender, EventArgs e) { new HoaDon().Show(); this.Close(); }
        private void DrKhachHang_Click(object sender, EventArgs e) { new KhachHang().Show(); this.Close(); }
    }
    #endregion
}