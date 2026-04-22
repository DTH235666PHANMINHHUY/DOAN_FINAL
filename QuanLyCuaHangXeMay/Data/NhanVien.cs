using QuanLyCuaHangXeMay.Forms;
using System;
using System.Collections.Generic;

namespace QuanLyCuaHangXeMay.Data
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public string Phai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string MaCV { get; set; }

        // Liên kết N-1: Thuộc về 1 Chức vụ
        public virtual ChucVu ChucVu { get; set; }

        // Quan hệ 1-N: 1 Nhân viên lập nhiều Hóa đơn
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new HashSet<HoaDon>();

        // Quan hệ 1-N: 1 Nhân viên có thể có Tài khoản (Thường là 1-1, nhưng thiết kế SQL cho phép 1-N)
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new HashSet<TaiKhoan>();
    }
}