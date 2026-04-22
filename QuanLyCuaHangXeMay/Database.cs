namespace QuanLyCuaHangXeMay
{
    public class Database
    {
        /**
         * Sửa DATA SOURCE theo cấu hình SqlServer | "." đồng nghĩa với (localhost)
         * 
         * Nếu sử dụng SQL Server Express, tên instance mặc định là SQLEXPRESS, thì DATA SOURCE sẽ là ".\SQLEXPRESS":
         *  Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCuaHangXeMay;Integrated Security=True;TrustServerCertificate=True
         *  hoặc
         *  Data Source=(localhost)\SQLEXPRESS;Initial Catalog=QuanLyCuaHangXeMay;Integrated Security=True;TrustServerCertificate=True
         * 
         * Nếu sử dụng SQL Server bình thường, thì DATA SOURCE sẽ là "." hoặc "(localhost)"
         * VD:
         *  Data Source=(localhost);Initial Catalog=QuanLyCuaHangXeMay;Integrated Security=True;TrustServerCertificate=True
         */
        
        // CẤU HÌNH KẾT NỐI SQL SERVER TẠI ĐÂY 👇👇👇
        public static string ConnectionString = @"
                Data Source=.;Initial Catalog=QuanLyCuaHangXeMay;Integrated Security=True;TrustServerCertificate=True
        ";
    }
}
