using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    partial class NhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTenLot = new System.Windows.Forms.TextBox();
            this.lblHoTenLot = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.dsNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTim = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.grpTim = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DrTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.DrNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.DrXeMay = new System.Windows.Forms.ToolStripMenuItem();
            this.DrHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.DrKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTaoMoi = new System.Windows.Forms.GroupBox();
            this.lblTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            this.grpTim.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.grpTaoMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaNV.ForeColor = System.Drawing.Color.Black;
            this.lblMaNV.Location = new System.Drawing.Point(34, 50);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(62, 19);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtMaNV.Location = new System.Drawing.Point(125, 48);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 22);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtHoTenLot.Location = new System.Drawing.Point(125, 89);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Size = new System.Drawing.Size(264, 22);
            this.txtHoTenLot.TabIndex = 3;
            // 
            // lblHoTenLot
            // 
            this.lblHoTenLot.AutoSize = true;
            this.lblHoTenLot.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTenLot.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblHoTenLot.ForeColor = System.Drawing.Color.Black;
            this.lblHoTenLot.Location = new System.Drawing.Point(34, 91);
            this.lblHoTenLot.Name = "lblHoTenLot";
            this.lblHoTenLot.Size = new System.Drawing.Size(87, 19);
            this.lblHoTenLot.TabIndex = 0;
            this.lblHoTenLot.Text = "Họ, tên lót:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(350, 132);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 19);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(350, 50);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(44, 19);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Phái:";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.BackColor = System.Drawing.Color.Transparent;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rdbNam.ForeColor = System.Drawing.Color.Black;
            this.rdbNam.Location = new System.Drawing.Point(440, 49);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 1;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.BackColor = System.Drawing.Color.Transparent;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rdbNu.ForeColor = System.Drawing.Color.Black;
            this.rdbNu.Location = new System.Drawing.Point(529, 49);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(440, 89);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(153, 22);
            this.txtTen.TabIndex = 4;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(280, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(442, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(440, 130);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(153, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblChucVu.ForeColor = System.Drawing.Color.Black;
            this.lblChucVu.Location = new System.Drawing.Point(34, 132);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(69, 19);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(125, 129);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(200, 24);
            this.cboChucVu.TabIndex = 5;
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.AllowUserToResizeColumns = false;
            this.dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dsNhanVien.Location = new System.Drawing.Point(0, 393);
            this.dsNhanVien.MultiSelect = false;
            this.dsNhanVien.Name = "dsNhanVien";
            this.dsNhanVien.ReadOnly = true;
            this.dsNhanVien.RowHeadersWidth = 51;
            this.dsNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsNhanVien.Size = new System.Drawing.Size(1002, 360);
            this.dsNhanVien.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(678, 122);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ➕";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(678, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa  ✏️";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(678, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 29);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá  🗑️";
            this.btnXoa.UseVisualStyleBackColor = true;
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
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.Black;
            this.lblDanhSach.Location = new System.Drawing.Point(333, 360);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(337, 31);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH NHÂN VIÊN";
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
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.BackColor = System.Drawing.Color.Transparent;
            this.lblTim.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTim.ForeColor = System.Drawing.Color.Black;
            this.lblTim.Location = new System.Drawing.Point(18, 27);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(141, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Nhập tên nhân viên:";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(410, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 29);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "🔍  Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.White;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHienThi.ForeColor = System.Drawing.Color.Black;
            this.btnHienThi.Location = new System.Drawing.Point(555, 22);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(129, 29);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển thị tất cả";
            this.btnHienThi.UseVisualStyleBackColor = false;
            // 
            // grpTim
            // 
            this.grpTim.BackColor = System.Drawing.Color.Transparent;
            this.grpTim.Controls.Add(this.btnXuatExcel);
            this.grpTim.Controls.Add(this.txtTim);
            this.grpTim.Controls.Add(this.btnInBaoCao);
            this.grpTim.Controls.Add(this.btnHienThi);
            this.grpTim.Controls.Add(this.btnTim);
            this.grpTim.Controls.Add(this.lblTim);
            this.grpTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.grpTim.ForeColor = System.Drawing.Color.Black;
            this.grpTim.Location = new System.Drawing.Point(12, 283);
            this.grpTim.Name = "grpTim";
            this.grpTim.Size = new System.Drawing.Size(978, 71);
            this.grpTim.TabIndex = 8;
            this.grpTim.TabStop = false;
            this.grpTim.Text = "Tìm kiếm nhân viên";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.Location = new System.Drawing.Point(843, 22);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(129, 29);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất danh sách";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(195, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(200, 22);
            this.txtTim.TabIndex = 3;
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnInBaoCao.Location = new System.Drawing.Point(708, 22);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(129, 29);
            this.btnInBaoCao.TabIndex = 11;
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
            // grpTaoMoi
            // 
            this.grpTaoMoi.Controls.Add(this.lblTen);
            this.grpTaoMoi.Controls.Add(this.lblMaNV);
            this.grpTaoMoi.Controls.Add(this.txtMaNV);
            this.grpTaoMoi.Controls.Add(this.lblHoTenLot);
            this.grpTaoMoi.Controls.Add(this.txtHoTenLot);
            this.grpTaoMoi.Controls.Add(this.lblNgaySinh);
            this.grpTaoMoi.Controls.Add(this.lblGioiTinh);
            this.grpTaoMoi.Controls.Add(this.rdbNam);
            this.grpTaoMoi.Controls.Add(this.rdbNu);
            this.grpTaoMoi.Controls.Add(this.txtTen);
            this.grpTaoMoi.Controls.Add(this.dtpNgaySinh);
            this.grpTaoMoi.Controls.Add(this.lblChucVu);
            this.grpTaoMoi.Controls.Add(this.cboChucVu);
            this.grpTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.grpTaoMoi.Location = new System.Drawing.Point(12, 86);
            this.grpTaoMoi.Name = "grpTaoMoi";
            this.grpTaoMoi.Size = new System.Drawing.Size(625, 191);
            this.grpTaoMoi.TabIndex = 1;
            this.grpTaoMoi.TabStop = false;
            this.grpTaoMoi.Text = "Tạo nhân viên mới";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(395, 91);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(39, 19);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.grpTaoMoi);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dsNhanVien);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanVien";
            this.Text = "Quản lý cửa hàng xe máy - Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            this.grpTim.ResumeLayout(false);
            this.grpTim.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpTaoMoi.ResumeLayout(false);
            this.grpTaoMoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMaNV;
        private TextBox txtMaNV;
        private TextBox txtHoTenLot;
        private Label lblHoTenLot;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtTen;
        private Label lblTieuDe;
        private DateTimePicker dtpNgaySinh;
        private Label lblChucVu;
        private ComboBox cboChucVu;
        private DataGridView dsNhanVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnLuu;
        private Label lblDanhSach;
        private Button btnThoat;
        private Label lblTim;
        private Button btnTim;
        private Button btnHienThi;
        private GroupBox grpTim;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem DrTrangChu;
        private ToolStripMenuItem DrNhanVien;
        private ToolStripMenuItem DrXeMay;
        private ToolStripMenuItem DrHoaDon;
        private ToolStripMenuItem DrKhachHang;
        private GroupBox grpTaoMoi;
        private Label lblTen;
        private TextBox txtTim;
        private Button btnXuatExcel;
        private Button btnInBaoCao;
    }
}