using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dsHoaDon = new System.Windows.Forms.DataGridView();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.grpTaoMoi = new System.Windows.Forms.GroupBox();
            this.numThanhTien = new System.Windows.Forms.NumericUpDown();
            this.cboMaXe = new System.Windows.Forms.ComboBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.grpTimHD = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DrTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.DrNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.DrXeMay = new System.Windows.Forms.ToolStripMenuItem();
            this.DrHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.DrKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).BeginInit();
            this.grpTaoMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grpTimHD.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(841, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(299, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(404, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaHD.ForeColor = System.Drawing.Color.Black;
            this.lblMaHD.Location = new System.Drawing.Point(19, 29);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(64, 19);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã HĐ:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.lblMaNV.Location = new System.Drawing.Point(19, 70);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(103, 19);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.BackColor = System.Drawing.Color.Transparent;
            this.lblMaXe.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaXe.ForeColor = System.Drawing.Color.Black;
            this.lblMaXe.Location = new System.Drawing.Point(335, 70);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(88, 19);
            this.lblMaXe.TabIndex = 0;
            this.lblMaXe.Text = "Mã xe máy:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaKH.ForeColor = System.Drawing.Color.Black;
            this.lblMaKH.Location = new System.Drawing.Point(335, 29);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(114, 19);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayLap.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblNgayLap.ForeColor = System.Drawing.Color.Black;
            this.lblNgayLap.Location = new System.Drawing.Point(18, 111);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(101, 19);
            this.lblNgayLap.TabIndex = 0;
            this.lblNgayLap.Text = "Ngày lập HĐ:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(335, 111);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(75, 19);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lblThanhTien.Location = new System.Drawing.Point(192, 152);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(84, 19);
            this.lblThanhTien.TabIndex = 0;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.BackColor = System.Drawing.Color.Transparent;
            this.lblTim.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTim.ForeColor = System.Drawing.Color.Black;
            this.lblTim.Location = new System.Drawing.Point(18, 27);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(131, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Nhập mã hoá đơn:";
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.Black;
            this.lblDanhSach.Location = new System.Drawing.Point(345, 360);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(312, 31);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(841, 168);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 29);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ  ↩️";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(841, 122);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 29);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu  💾";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(678, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 29);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá  🗑️";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(678, 122);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ➕";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(678, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa  ✏️";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // dsHoaDon
            // 
            this.dsHoaDon.AllowUserToAddRows = false;
            this.dsHoaDon.AllowUserToDeleteRows = false;
            this.dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dsHoaDon.Location = new System.Drawing.Point(0, 393);
            this.dsHoaDon.MultiSelect = false;
            this.dsHoaDon.Name = "dsHoaDon";
            this.dsHoaDon.ReadOnly = true;
            this.dsHoaDon.RowHeadersWidth = 51;
            this.dsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsHoaDon.Size = new System.Drawing.Size(1002, 360);
            this.dsHoaDon.TabIndex = 9;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(128, 109);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(150, 22);
            this.dtpNgayLap.TabIndex = 4;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(128, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 22);
            this.txtMaHD.TabIndex = 0;
            // 
            // grpTaoMoi
            // 
            this.grpTaoMoi.Controls.Add(this.numThanhTien);
            this.grpTaoMoi.Controls.Add(this.cboMaXe);
            this.grpTaoMoi.Controls.Add(this.cbo);
            this.grpTaoMoi.Controls.Add(this.cboMaKH);
            this.grpTaoMoi.Controls.Add(this.numSoLuong);
            this.grpTaoMoi.Controls.Add(this.lblThanhTien);
            this.grpTaoMoi.Controls.Add(this.lblSoLuong);
            this.grpTaoMoi.Controls.Add(this.lblMaXe);
            this.grpTaoMoi.Controls.Add(this.lblMaKH);
            this.grpTaoMoi.Controls.Add(this.lblMaNV);
            this.grpTaoMoi.Controls.Add(this.dtpNgayLap);
            this.grpTaoMoi.Controls.Add(this.lblNgayLap);
            this.grpTaoMoi.Controls.Add(this.txtMaHD);
            this.grpTaoMoi.Controls.Add(this.lblMaHD);
            this.grpTaoMoi.Location = new System.Drawing.Point(12, 86);
            this.grpTaoMoi.Name = "grpTaoMoi";
            this.grpTaoMoi.Size = new System.Drawing.Size(625, 191);
            this.grpTaoMoi.TabIndex = 1;
            this.grpTaoMoi.TabStop = false;
            this.grpTaoMoi.Text = "Tạo hoá đơn mới";
            // 
            // numThanhTien
            // 
            this.numThanhTien.Location = new System.Drawing.Point(282, 150);
            this.numThanhTien.Name = "numThanhTien";
            this.numThanhTien.Size = new System.Drawing.Size(150, 22);
            this.numThanhTien.TabIndex = 10;
            // 
            // cboMaXe
            // 
            this.cboMaXe.FormattingEnabled = true;
            this.cboMaXe.Location = new System.Drawing.Point(455, 67);
            this.cboMaXe.Name = "cboMaXe";
            this.cboMaXe.Size = new System.Drawing.Size(150, 24);
            this.cboMaXe.TabIndex = 9;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(128, 67);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(148, 24);
            this.cbo.TabIndex = 8;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(455, 26);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(150, 24);
            this.cboMaKH.TabIndex = 7;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(455, 109);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(150, 22);
            this.numSoLuong.TabIndex = 5;
            // 
            // grpTimHD
            // 
            this.grpTimHD.Controls.Add(this.txtTim);
            this.grpTimHD.Controls.Add(this.btnHienThi);
            this.grpTimHD.Controls.Add(this.btnTim);
            this.grpTimHD.Controls.Add(this.lblTim);
            this.grpTimHD.Controls.Add(this.btnXuatExcel);
            this.grpTimHD.Controls.Add(this.btnInBaoCao);
            this.grpTimHD.Location = new System.Drawing.Point(12, 283);
            this.grpTimHD.Name = "grpTimHD";
            this.grpTimHD.Size = new System.Drawing.Size(978, 71);
            this.grpTimHD.TabIndex = 8;
            this.grpTimHD.TabStop = false;
            this.grpTimHD.Text = "Tìm kiếm hoá đơn";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(195, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(200, 22);
            this.txtTim.TabIndex = 3;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHienThi.Location = new System.Drawing.Point(555, 22);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(129, 29);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển thị tất cả";
            this.btnHienThi.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTim.Location = new System.Drawing.Point(410, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 29);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "🔍  Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.Location = new System.Drawing.Point(843, 22);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(129, 29);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất danh sách";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnInBaoCao.Location = new System.Drawing.Point(708, 22);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(129, 29);
            this.btnInBaoCao.TabIndex = 2;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuForm});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuForm
            // 
            this.mnuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrTrangChu,
            this.DrNhanVien,
            this.DrXeMay,
            this.DrHoaDon,
            this.DrKhachHang});
            this.mnuForm.Name = "mnuForm";
            this.mnuForm.Size = new System.Drawing.Size(82, 24);
            this.mnuForm.Text = "🏍️ Form";
            // 
            // DrTrangChu
            // 
            this.DrTrangChu.Name = "DrTrangChu";
            this.DrTrangChu.Size = new System.Drawing.Size(169, 26);
            this.DrTrangChu.Text = "Trang chủ";
            // 
            // DrNhanVien
            // 
            this.DrNhanVien.Name = "DrNhanVien";
            this.DrNhanVien.Size = new System.Drawing.Size(169, 26);
            this.DrNhanVien.Text = "Nhân viên";
            // 
            // DrXeMay
            // 
            this.DrXeMay.Name = "DrXeMay";
            this.DrXeMay.Size = new System.Drawing.Size(169, 26);
            this.DrXeMay.Text = "Xe máy";
            // 
            // DrHoaDon
            // 
            this.DrHoaDon.Name = "DrHoaDon";
            this.DrHoaDon.Size = new System.Drawing.Size(169, 26);
            this.DrHoaDon.Text = "Hoá đơn";
            // 
            // DrKhachHang
            // 
            this.DrKhachHang.Name = "DrKhachHang";
            this.DrKhachHang.Size = new System.Drawing.Size(169, 26);
            this.DrKhachHang.Text = "Khách hàng";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpTimHD);
            this.Controls.Add(this.grpTaoMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dsHoaDon);
            this.Controls.Add(this.lblTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDon";
            this.Text = "Quản lý cửa hàng xe máy - Hoá đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dsHoaDon)).EndInit();
            this.grpTaoMoi.ResumeLayout(false);
            this.grpTaoMoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grpTimHD.ResumeLayout(false);
            this.grpTimHD.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dsHoaDon;
        private System.Windows.Forms.GroupBox grpTaoMoi;
        private System.Windows.Forms.GroupBox grpTimHD;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuForm;
        private System.Windows.Forms.ToolStripMenuItem DrTrangChu;
        private System.Windows.Forms.ToolStripMenuItem DrNhanVien;
        private System.Windows.Forms.ToolStripMenuItem DrXeMay;
        private System.Windows.Forms.ToolStripMenuItem DrHoaDon;
        private System.Windows.Forms.ToolStripMenuItem DrKhachHang;
        private Button btnInBaoCao;
        private Button btnXuatExcel;
        private NumericUpDown numSoLuong;
        private ComboBox cboMaXe;
        private ComboBox cbo;
        private ComboBox cboMaKH;
        private NumericUpDown numThanhTien;
        private TextBox txtTim;
    }
}