using QuanLyCuaHangXeMay.Forms;
using System.Collections.Generic;

namespace QuanLyCuaHangXeMay.Data
{
    public class ChucVu
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }

        // Quan hệ 1-N: 1 Chức vụ có nhiều Nhân viên
        public virtual ICollection<NhanVien> NhanViens { get; set; } = new HashSet<NhanVien>();
    }
}