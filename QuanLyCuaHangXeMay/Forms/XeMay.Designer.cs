using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    partial class XeMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XeMay));
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dsXeMay = new System.Windows.Forms.DataGridView();
            this.cboHangXe = new System.Windows.Forms.ComboBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblHangXe = new System.Windows.Forms.Label();
            this.grpTim = new System.Windows.Forms.GroupBox();
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
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dsXeMay)).BeginInit();
            this.grpTim.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.grpTaoMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
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
            this.lblDanhSach.Location = new System.Drawing.Point(356, 360);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(291, 31);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH XE MÁY";
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
            // dsXeMay
            // 
            this.dsXeMay.AllowUserToAddRows = false;
            this.dsXeMay.AllowUserToDeleteRows = false;
            this.dsXeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsXeMay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dsXeMay.Location = new System.Drawing.Point(0, 393);
            this.dsXeMay.MultiSelect = false;
            this.dsXeMay.Name = "dsXeMay";
            this.dsXeMay.ReadOnly = true;
            this.dsXeMay.RowHeadersWidth = 51;
            this.dsXeMay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsXeMay.Size = new System.Drawing.Size(1002, 360);
            this.dsXeMay.TabIndex = 9;
            // 
            // cboHangXe
            // 
            this.cboHangXe.FormattingEnabled = true;
            this.cboHangXe.Location = new System.Drawing.Point(440, 88);
            this.cboHangXe.Name = "cboHangXe";
            this.cboHangXe.Size = new System.Drawing.Size(150, 24);
            this.cboHangXe.TabIndex = 3;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblMaLoai.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaLoai.ForeColor = System.Drawing.Color.Black;
            this.lblMaLoai.Location = new System.Drawing.Point(350, 50);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(86, 19);
            this.lblMaLoai.TabIndex = 0;
            this.lblMaLoai.Text = "Mã loại xe:";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(125, 130);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(200, 22);
            this.txtMauSac.TabIndex = 4;
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.BackColor = System.Drawing.Color.Transparent;
            this.lblMauSac.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMauSac.ForeColor = System.Drawing.Color.Black;
            this.lblMauSac.Location = new System.Drawing.Point(34, 132);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(70, 19);
            this.lblMauSac.TabIndex = 0;
            this.lblMauSac.Text = "Màu sắc:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(313, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(376, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ XE MÁY";
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Location = new System.Drawing.Point(440, 48);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.Size = new System.Drawing.Size(150, 22);
            this.txtLoaiXe.TabIndex = 1;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaBan.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblGiaBan.ForeColor = System.Drawing.Color.Black;
            this.lblGiaBan.Location = new System.Drawing.Point(350, 132);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(65, 19);
            this.lblGiaBan.TabIndex = 0;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(125, 89);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(200, 22);
            this.txtTenXe.TabIndex = 2;
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.BackColor = System.Drawing.Color.Transparent;
            this.lblTenXe.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTenXe.ForeColor = System.Drawing.Color.Black;
            this.lblTenXe.Location = new System.Drawing.Point(34, 91);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(59, 19);
            this.lblTenXe.TabIndex = 0;
            this.lblTenXe.Text = "Tên xe:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(125, 48);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(200, 22);
            this.txtMaXe.TabIndex = 0;
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.BackColor = System.Drawing.Color.Transparent;
            this.lblMaXe.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblMaXe.ForeColor = System.Drawing.Color.Black;
            this.lblMaXe.Location = new System.Drawing.Point(34, 50);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(56, 19);
            this.lblMaXe.TabIndex = 0;
            this.lblMaXe.Text = "Mã xe:";
            // 
            // lblHangXe
            // 
            this.lblHangXe.AutoSize = true;
            this.lblHangXe.BackColor = System.Drawing.Color.Transparent;
            this.lblHangXe.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblHangXe.ForeColor = System.Drawing.Color.Black;
            this.lblHangXe.Location = new System.Drawing.Point(350, 91);
            this.lblHangXe.Name = "lblHangXe";
            this.lblHangXe.Size = new System.Drawing.Size(69, 19);
            this.lblHangXe.TabIndex = 0;
            this.lblHangXe.Text = "Hãng xe:";
            // 
            // grpTim
            // 
            this.grpTim.Controls.Add(this.btnXuatExcel);
            this.grpTim.Controls.Add(this.btnInBaoCao);
            this.grpTim.Controls.Add(this.txtTim);
            this.grpTim.Controls.Add(this.btnHienThi);
            this.grpTim.Controls.Add(this.btnTim);
            this.grpTim.Controls.Add(this.lblTim);
            this.grpTim.Location = new System.Drawing.Point(12, 283);
            this.grpTim.Name = "grpTim";
            this.grpTim.Size = new System.Drawing.Size(978, 71);
            this.grpTim.TabIndex = 8;
            this.grpTim.TabStop = false;
            this.grpTim.Text = "Tìm kiếm xe máy";
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
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.BackColor = System.Drawing.Color.Transparent;
            this.lblTim.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.lblTim.ForeColor = System.Drawing.Color.Black;
            this.lblTim.Location = new System.Drawing.Point(18, 27);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(125, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Nhập mã xe máy:";
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
            this.grpTaoMoi.Controls.Add(this.numGiaBan);
            this.grpTaoMoi.Controls.Add(this.lblMaXe);
            this.grpTaoMoi.Controls.Add(this.txtMaXe);
            this.grpTaoMoi.Controls.Add(this.lblTenXe);
            this.grpTaoMoi.Controls.Add(this.lblHangXe);
            this.grpTaoMoi.Controls.Add(this.txtTenXe);
            this.grpTaoMoi.Controls.Add(this.lblGiaBan);
            this.grpTaoMoi.Controls.Add(this.txtLoaiXe);
            this.grpTaoMoi.Controls.Add(this.lblMauSac);
            this.grpTaoMoi.Controls.Add(this.txtMauSac);
            this.grpTaoMoi.Controls.Add(this.lblMaLoai);
            this.grpTaoMoi.Controls.Add(this.cboHangXe);
            this.grpTaoMoi.Location = new System.Drawing.Point(12, 86);
            this.grpTaoMoi.Name = "grpTaoMoi";
            this.grpTaoMoi.Size = new System.Drawing.Size(625, 191);
            this.grpTaoMoi.TabIndex = 1;
            this.grpTaoMoi.TabStop = false;
            this.grpTaoMoi.Text = "Tạo xe máy mới";
            // 
            // numGiaBan
            // 
            this.numGiaBan.Location = new System.Drawing.Point(440, 130);
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(150, 22);
            this.numGiaBan.TabIndex = 5;
            // 
            // XeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Controls.Add(this.dsXeMay);
            this.Controls.Add(this.lblTieuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XeMay";
            this.Text = "Quản lý cửa hàng xe máy - Xe máy";
            ((System.ComponentModel.ISupportInitialize)(this.dsXeMay)).EndInit();
            this.grpTim.ResumeLayout(false);
            this.grpTim.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpTaoMoi.ResumeLayout(false);
            this.grpTaoMoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThoat;
        private Label lblDanhSach;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dsXeMay;
        private ComboBox cboHangXe;
        private Label lblMaLoai;
        private TextBox txtMauSac;
        private Label lblMauSac;
        private Label lblTieuDe;
        private TextBox txtLoaiXe;
        private Label lblGiaBan;
        private TextBox txtTenXe;
        private Label lblTenXe;
        private TextBox txtMaXe;
        private Label lblMaXe;
        private Label lblHangXe;
        private GroupBox grpTim;
        private Button btnHienThi;
        private Button btnTim;
        private Label lblTim;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem DrTrangChu;
        private ToolStripMenuItem DrNhanVien;
        private ToolStripMenuItem DrXeMay;
        private ToolStripMenuItem DrHoaDon;
        private ToolStripMenuItem DrKhachHang;
        private GroupBox grpTaoMoi;
        private NumericUpDown numGiaBan;
        private TextBox txtTim;
        private Button btnXuatExcel;
        private Button btnInBaoCao;
    }
}