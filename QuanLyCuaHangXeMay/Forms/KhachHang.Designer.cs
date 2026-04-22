using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dsKhachHang = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.grpTimKH = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTim = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DrTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.DrNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.DrXeMay = new System.Windows.Forms.ToolStripMenuItem();
            this.DrHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.DrKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTaoMoi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).BeginInit();
            this.grpTimKH.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.grpTaoMoi.SuspendLayout();
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
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.Black;
            this.lblDanhSach.Location = new System.Drawing.Point(315, 360);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(373, 31);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH KHÁCH HÀNG";
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
            // dsKhachHang
            // 
            this.dsKhachHang.AllowUserToAddRows = false;
            this.dsKhachHang.AllowUserToDeleteRows = false;
            this.dsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dsKhachHang.Location = new System.Drawing.Point(0, 393);
            this.dsKhachHang.Name = "dsKhachHang";
            this.dsKhachHang.ReadOnly = true;
            this.dsKhachHang.RowHeadersWidth = 51;
            this.dsKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsKhachHang.Size = new System.Drawing.Size(1002, 360);
            this.dsKhachHang.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(440, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 22);
            this.txtSDT.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(350, 91);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(43, 19);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(254, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(495, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbNu.Location = new System.Drawing.Point(529, 49);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbNam.Location = new System.Drawing.Point(440, 49);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 1;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
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
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.lblGhiChu.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;
            this.lblGhiChu.Location = new System.Drawing.Point(350, 132);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(67, 19);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 89);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblHoTen.Location = new System.Drawing.Point(34, 91);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(78, 19);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(125, 48);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 22);
            this.txtMaKH.TabIndex = 0;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaKH.ForeColor = System.Drawing.Color.Black;
            this.lblMaKH.Location = new System.Drawing.Point(34, 50);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(64, 19);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(125, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(34, 132);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(63, 19);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(440, 130);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(150, 22);
            this.txtGhiChu.TabIndex = 6;
            // 
            // grpTimKH
            // 
            this.grpTimKH.Controls.Add(this.btnXuatExcel);
            this.grpTimKH.Controls.Add(this.btnInBaoCao);
            this.grpTimKH.Controls.Add(this.txtTim);
            this.grpTimKH.Controls.Add(this.btnHienThi);
            this.grpTimKH.Controls.Add(this.btnTim);
            this.grpTimKH.Controls.Add(this.lblTim);
            this.grpTimKH.Location = new System.Drawing.Point(12, 283);
            this.grpTimKH.Name = "grpTimKH";
            this.grpTimKH.Size = new System.Drawing.Size(978, 71);
            this.grpTimKH.TabIndex = 8;
            this.grpTimKH.TabStop = false;
            this.grpTimKH.Text = "Tìm kiếm khách hàng";
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
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTim.Location = new System.Drawing.Point(410, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 29);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "🔍  Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.BackColor = System.Drawing.Color.Transparent;
            this.lblTim.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTim.ForeColor = System.Drawing.Color.Black;
            this.lblTim.Location = new System.Drawing.Point(18, 27);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(152, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Nhập tên khách hàng:";
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
            // grpTaoMoi
            // 
            this.grpTaoMoi.Controls.Add(this.lblMaKH);
            this.grpTaoMoi.Controls.Add(this.txtMaKH);
            this.grpTaoMoi.Controls.Add(this.lblHoTen);
            this.grpTaoMoi.Controls.Add(this.txtGhiChu);
            this.grpTaoMoi.Controls.Add(this.txtHoTen);
            this.grpTaoMoi.Controls.Add(this.txtDiaChi);
            this.grpTaoMoi.Controls.Add(this.lblGhiChu);
            this.grpTaoMoi.Controls.Add(this.lblDiaChi);
            this.grpTaoMoi.Controls.Add(this.lblGioiTinh);
            this.grpTaoMoi.Controls.Add(this.rdbNam);
            this.grpTaoMoi.Controls.Add(this.rdbNu);
            this.grpTaoMoi.Controls.Add(this.lblSDT);
            this.grpTaoMoi.Controls.Add(this.txtSDT);
            this.grpTaoMoi.Location = new System.Drawing.Point(12, 86);
            this.grpTaoMoi.Name = "grpTaoMoi";
            this.grpTaoMoi.Size = new System.Drawing.Size(625, 191);
            this.grpTaoMoi.TabIndex = 1;
            this.grpTaoMoi.TabStop = false;
            this.grpTaoMoi.Text = "Tạo khách hàng mới";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1002, 753);
            this.Controls.Add(this.grpTaoMoi);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.grpTimKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dsKhachHang);
            this.Controls.Add(this.lblTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhachHang";
            this.Text = "Quản lý cửa hàng xe máy - Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dsKhachHang)).EndInit();
            this.grpTimKH.ResumeLayout(false);
            this.grpTimKH.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpTaoMoi.ResumeLayout(false);
            this.grpTaoMoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DataGridView dsKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox grpTimKH;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuForm;
        private System.Windows.Forms.ToolStripMenuItem DrTrangChu;
        private System.Windows.Forms.ToolStripMenuItem DrNhanVien;
        private System.Windows.Forms.ToolStripMenuItem DrXeMay;
        private System.Windows.Forms.ToolStripMenuItem DrHoaDon;
        private System.Windows.Forms.ToolStripMenuItem DrKhachHang;
        private GroupBox grpTaoMoi;
        private TextBox txtTim;
        private Button btnXuatExcel;
        private Button btnInBaoCao;
    }
}