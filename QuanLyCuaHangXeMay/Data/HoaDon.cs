using System;

namespace QuanLyCuaHangXeMay.Data
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string MaXe { get; set; }
        public DateTime? NgayLap { get; set; }
        public int? SoLuong { get; set; }
        public decimal? ThanhTien { get; set; }

        // Liên kết N-1: Hóa đơn tham chiếu đến Nhân viên, Khách hàng, Xe máy
        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual XeMay XeMay { get; set; }
    }
}