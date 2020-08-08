using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongTaiChinh
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime Ngay { get; set; }
        public decimal? DoanhThuTheoThiTruongThucTe { get; set; }
        public decimal? DoanhThuKhac { get; set; }
        public decimal? DoanhThuTheoThiTruongTuDong { get; set; }
        public decimal? DoanhThuTheoHopDong { get; set; }
        public decimal? DoanhThuTheoGiaHopDong { get; set; }
        public int? ChuKy { get; set; }
        public int? UnitId { get; set; }
        public decimal? ChiPhiBienDoiCoDinh { get; set; }
        public decimal? ChiPhiBienDoiThucTe { get; set; }
        public decimal? SanLuongDuTinh { get; set; }
    }
}
