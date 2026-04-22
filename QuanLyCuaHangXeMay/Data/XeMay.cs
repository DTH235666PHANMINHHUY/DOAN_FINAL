using QuanLyCuaHangXeMay.Forms;
using System.Collections.Generic;

namespace QuanLyCuaHangXeMay.Data
{
    public class XeMay
    {
        public string MaXe { get; set; }
        public string LoaiXe { get; set; }
        public string TenXe { get; set; }
        public string MaHang { get; set; }
        public string MauSac { get; set; }
        public decimal? GiaBan { get; set; }

        // Liên kết N-1: Thuộc về 1 Hãng xe
        public virtual HangXe HangXe { get; set; }

        // Quan hệ 1-N: 1 Xe máy có thể xuất hiện trong nhiều Hóa đơn
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new HashSet<HoaDon>();
    }
}