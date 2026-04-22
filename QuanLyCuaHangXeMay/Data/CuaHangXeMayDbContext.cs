using System.Data.Entity;

namespace QuanLyCuaHangXeMay.Data
{
    public class CuaHangXeMayDbContext : DbContext
    {
        // Gọi đích danh QuanLyCuaHangXeMay.Database để tránh xung đột với System.Data.Entity.Database
        public CuaHangXeMayDbContext() : base(QuanLyCuaHangXeMay.Database.ConnectionString)
        {
            // Tắt tính năng khởi tạo database tự động vì chúng ta đã có file SQL
            System.Data.Entity.Database.SetInitializer<CuaHangXeMayDbContext>(null);
        }

        // Khai báo các tập thực thể tương ứng với các bảng trong SQL
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<HangXe> HangXes { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<XeMay> XeMays { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Cấu hình Fluent API để khớp chính xác với cấu trúc bảng trong SQL

            // Bảng ChucVu
            modelBuilder.Entity<ChucVu>().ToTable("ChucVu").HasKey(c => c.MaCV);

            // Bảng HangXe
            modelBuilder.Entity<HangXe>().ToTable("HangXe").HasKey(h => h.MaHang);

            // Bảng KhachHang
            modelBuilder.Entity<KhachHang>().ToTable("KhachHang").HasKey(k => k.MaKH);

            // Bảng NhanVien
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien").HasKey(n => n.MaNV);
            modelBuilder.Entity<NhanVien>()
                .HasOptional(n => n.ChucVu)
                .WithMany(c => c.NhanViens)
                .HasForeignKey(n => n.MaCV);

            // Bảng XeMay
            modelBuilder.Entity<XeMay>().ToTable("XeMay").HasKey(x => x.MaXe);
            modelBuilder.Entity<XeMay>()
                .HasOptional(x => x.HangXe)
                .WithMany(h => h.XeMays)
                .HasForeignKey(x => x.MaHang);

            // Bảng HoaDon
            modelBuilder.Entity<HoaDon>().ToTable("HoaDon").HasKey(h => h.MaHD);
            modelBuilder.Entity<HoaDon>()
                .HasOptional(h => h.NhanVien)
                .WithMany(n => n.HoaDons)
                .HasForeignKey(h => h.MaNV);
            modelBuilder.Entity<HoaDon>()
                .HasOptional(h => h.KhachHang)
                .WithMany(k => k.HoaDons)
                .HasForeignKey(h => h.MaKH);
            modelBuilder.Entity<HoaDon>()
                .HasOptional(h => h.XeMay)
                .WithMany(x => x.HoaDons)
                .HasForeignKey(h => h.MaXe);

            // Bảng TaiKhoan
            modelBuilder.Entity<TaiKhoan>().ToTable("TaiKhoan").HasKey(t => t.MaTK);
            modelBuilder.Entity<TaiKhoan>()
                .HasOptional(t => t.NhanVien)
                .WithMany(n => n.TaiKhoans)
                .HasForeignKey(t => t.MaNV);

            base.OnModelCreating(modelBuilder);
        }
    }
}