using QuanLyCuaHangXeMay.Forms;
using System.Collections.Generic;

namespace QuanLyCuaHangXeMay.Data
{
    public class HangXe
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }

        // Quan hệ 1-N: 1 Hãng xe có nhiều Xe máy
        public virtual ICollection<XeMay> XeMays { get; set; } = new HashSet<XeMay>();
    }
}