namespace QuanLyCuaHangXeMay.Data
{
    public class TaiKhoan
    {
        public string MaTK { get; set; }
        public string MaNV { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }

        // Liên kết N-1: Thuộc về 1 Nhân viên
        public virtual NhanVien NhanVien { get; set; }
    }
}