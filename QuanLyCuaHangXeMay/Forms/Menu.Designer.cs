using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.grpDanhMuc = new System.Windows.Forms.GroupBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnXeMay = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDeP1 = new System.Windows.Forms.Label();
            this.lblTieuDeP2 = new System.Windows.Forms.Label();
            this.grpDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.grpDanhMuc.Controls.Add(this.btnNhanVien);
            this.grpDanhMuc.Controls.Add(this.btnKhachHang);
            this.grpDanhMuc.Controls.Add(this.btnXeMay);
            this.grpDanhMuc.Controls.Add(this.btnHoaDon);
            this.grpDanhMuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhMuc.ForeColor = System.Drawing.Color.White;
            this.grpDanhMuc.Location = new System.Drawing.Point(35, 192);
            this.grpDanhMuc.Name = "grpDanhMuc";
            this.grpDanhMuc.Size = new System.Drawing.Size(711, 223);
            this.grpDanhMuc.TabIndex = 1;
            this.grpDanhMuc.TabStop = false;
            this.grpDanhMuc.Text = "Danh mục quản lý";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Black;
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(92, 53);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(206, 54);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "NHÂN VIÊN 🔒";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Black;
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(412, 136);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(206, 54);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnXeMay
            // 
            this.btnXeMay.BackColor = System.Drawing.Color.Black;
            this.btnXeMay.ForeColor = System.Drawing.Color.White;
            this.btnXeMay.Location = new System.Drawing.Point(92, 136);
            this.btnXeMay.Name = "btnXeMay";
            this.btnXeMay.Size = new System.Drawing.Size(206, 54);
            this.btnXeMay.TabIndex = 1;
            this.btnXeMay.Text = "XE MÁY";
            this.btnXeMay.UseVisualStyleBackColor = false;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Black;
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(412, 53);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(206, 54);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "HOÁ ĐƠN";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.BackColor = System.Drawing.Color.Transparent;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.White;
            this.lblXinChao.Location = new System.Drawing.Point(35, 151);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(92, 28);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTen.Location = new System.Drawing.Point(126, 153);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(216, 25);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "tên nhân viên (chức vụ)";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.FloralWhite;
            this.linkLabel.Location = new System.Drawing.Point(655, 151);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(101, 28);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Đăng xuất";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(592, 433);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 34);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTieuDeP1
            // 
            this.lblTieuDeP1.AutoSize = true;
            this.lblTieuDeP1.BackColor = System.Drawing.Color.Black;
            this.lblTieuDeP1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeP1.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeP1.Location = new System.Drawing.Point(272, 21);
            this.lblTieuDeP1.Name = "lblTieuDeP1";
            this.lblTieuDeP1.Size = new System.Drawing.Size(239, 53);
            this.lblTieuDeP1.TabIndex = 0;
            this.lblTieuDeP1.Text = "QUẢN LÝ";
            // 
            // lblTieuDeP2
            // 
            this.lblTieuDeP2.AutoSize = true;
            this.lblTieuDeP2.BackColor = System.Drawing.Color.Black;
            this.lblTieuDeP2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeP2.ForeColor = System.Drawing.Color.White;
            this.lblTieuDeP2.Location = new System.Drawing.Point(86, 78);
            this.lblTieuDeP2.Name = "lblTieuDeP2";
            this.lblTieuDeP2.Size = new System.Drawing.Size(610, 68);
            this.lblTieuDeP2.TabIndex = 0;
            this.lblTieuDeP2.Text = "CỬA HÀNG XE MÁY";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyCuaHangXeMay.Properties.Resources.menu_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.lblTieuDeP2);
            this.Controls.Add(this.lblTieuDeP1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.grpDanhMuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng xe máy - Trang chủ";
            this.grpDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpDanhMuc;
        private Label lblXinChao;
        private Button btnKhachHang;
        private Button btnXeMay;
        private Button btnHoaDon;
        private Label lblTen;
        private LinkLabel linkLabel;
        private Button btnNhanVien;
        private Button btnThoat;
        private Label lblTieuDeP1;
        private Label lblTieuDeP2;
    }
}