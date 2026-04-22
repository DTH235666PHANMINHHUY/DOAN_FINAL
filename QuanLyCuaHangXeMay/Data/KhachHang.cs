using QuanLyCuaHangXeMay.Forms;
using System.Collections.Generic;

namespace QuanLyCuaHangXeMay.Data
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string Phai { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }

        // Quan hệ 1-N: 1 Khách hàng có nhiều Hóa đơn
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new HashSet<HoaDon>();
    }
}