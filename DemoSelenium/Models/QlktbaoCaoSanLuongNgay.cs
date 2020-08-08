using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class QlktbaoCaoSanLuongNgay
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public int IdToMay { get; set; }
        public decimal? CongSuatLonNhat { get; set; }
        public int? ChuKyCongSuatLonNhat { get; set; }
        public decimal? CongSuatNhoNhat { get; set; }
        public int? ChuKyCongSuatNhoNhat { get; set; }
        public decimal? SanLuongNgay { get; set; }
        public decimal? SanLuongTuan { get; set; }
        public decimal? SanLuongTuanPhuongThuc { get; set; }
        public decimal? SanLuongThang { get; set; }
        public decimal? SanLuongThangKeHoach { get; set; }
        public decimal? SanLuongThangPhuongThuc { get; set; }
        public decimal? SanLuongNam { get; set; }
        public decimal? SanLuongNamKeHoach { get; set; }
        public decimal? HeSoSuDung { get; set; }
        public decimal? HeSoKhaDung { get; set; }
    }
}
