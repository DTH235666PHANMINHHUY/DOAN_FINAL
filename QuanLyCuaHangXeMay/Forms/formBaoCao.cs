using CrystalDecisions.CrystalReports.Engine;
using QuanLyCuaHangXeMay.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay.Forms
{
    public partial class formBaoCao : Form
    {
        private int ReportId = 0;
        ReportClass rpt;

        public formBaoCao()
        {
            InitializeComponent();
            this.Load += formBaoCao_Load;
        }

        public formBaoCao(int reportId)
        {
            InitializeComponent();
            this.ReportId = reportId;
            this.Load += formBaoCao_Load;
        }

        private void formBaoCao_Load(object sender, EventArgs e)
        {
            string sql = string.Empty;

            /**
             * Điều hướng dữ liệu vào đúng đối tượng Report tương ứng
             * 
             * ReportId:
             * 1 - Báo cáo hóa đơn
             * 2 - Báo cáo nhân viên
             * 3 - Báo cáo xe máy
             * 4 - Báo cáo khách hàng
             */
            if (this.ReportId == 1)
            {
                sql = @"
                    SELECT HD.MaHD, HD.NgayLap, (NV.HoLot + ' ' + NV.Ten) AS TenNV, 
                           KH.HoTen AS TenKH, XM.TenXe, HD.SoLuong, HD.ThanhTien
                    FROM HoaDon HD
                    INNER JOIN NhanVien NV ON HD.MaNV = NV.MaNV
                    INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
                    INNER JOIN XeMay XM ON HD.MaXe = XM.MaXe
                    ORDER BY HD.NgayLap DESC";
                rpt = new rptHoaDon();
            }
            else if (this.ReportId == 2)
            {
                sql = @"
                    SELECT 
                        NV.MaNV, 
                        (NV.HoLot + ' ' + NV.Ten) AS HoTen, 
                        NV.Phai, 
                        NV.NgaySinh, 
                        CV.TenCV, 
                        ISNULL(SUM(HD.SoLuong), 0) AS DaBan, 
                        ISNULL(SUM(HD.ThanhTien), 0) AS TongThanhTien
                    FROM NhanVien NV
                    LEFT JOIN ChucVu CV ON NV.MaCV = CV.MaCV
                    LEFT JOIN HoaDon HD ON NV.MaNV = HD.MaNV
                    GROUP BY NV.MaNV, NV.HoLot, NV.Ten, NV.Phai, NV.NgaySinh, CV.TenCV
                    ORDER BY TongThanhTien DESC";
                rpt = new rptNhanVien();
            }
            else if (this.ReportId == 3)
            {
                sql = @"
                    SELECT 
                        XM.MaXe, 
                        HX.TenHang, 
                        XM.TenXe, 
                        XM.LoaiXe, 
                        XM.MauSac, 
                        XM.GiaBan, 
                        ISNULL(SUM(HD.SoLuong), 0) AS DaBan,
                        ISNULL(SUM(HD.ThanhTien), 0) AS TongThanhTien
                    FROM XeMay XM
                    LEFT JOIN HangXe HX ON XM.MaHang = HX.MaHang
                    LEFT JOIN HoaDon HD ON XM.MaXe = HD.MaXe
                    GROUP BY XM.MaXe, HX.TenHang, XM.TenXe, XM.LoaiXe, XM.MauSac, XM.GiaBan
                    ORDER BY DaBan DESC";
                rpt = new rptXeMay();
            }
            else if (this.ReportId == 4)
            {
                sql = @"
                    SELECT 
                        KH.MaKH, 
                        KH.HoTen, 
                        KH.Phai, 
                        KH.SDT, 
                        KH.DiaChi, 
                        KH.GhiChu, 
                        ISNULL(SUM(HD.SoLuong), 0) AS DaMua,
                        ISNULL(SUM(HD.ThanhTien), 0) AS TongThanhTien
                    FROM KhachHang KH
                    LEFT JOIN HoaDon HD ON KH.MaKH = HD.MaKH
                    GROUP BY KH.MaKH, KH.HoTen, KH.Phai, KH.SDT, KH.DiaChi, KH.GhiChu
                    ORDER BY TongThanhTien DESC";
                rpt = new rptKhachHang();
            }
            else
            { // Trường hợp không mong muốn, nhưng vẫn cần xử lý để tránh lỗi runtime
                MessageBox.Show("Mã báo cáo (ReportId: " + this.ReportId + ") không hợp lệ.", "Lỗi Báo Cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Database.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dtResult = new DataTable();
                    da.Fill(dtResult);

                    if (dtResult.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để lập báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }

                    rpt.SetDataSource(dtResult);
                    cryRptViewer.ReportSource = rpt;
                    cryRptViewer.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngoại lệ phát sinh trong quá trình truy xuất: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}