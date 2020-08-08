using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class SanLuongKeHoachThuyVan
    {
        public int Id { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? UnitId { get; set; }
        public decimal? TanSuatKh { get; set; }
        public decimal? TanSuatTh { get; set; }
        public decimal? LuuLuongNuocVeKh { get; set; }
        public decimal? LuuLuongNuocVeTh { get; set; }
        public decimal? MucNuocKh { get; set; }
        public decimal? MucNuocTh { get; set; }
        public decimal? SuatHaoNuocKh { get; set; }
        public decimal? SuatHaoNuocTh { get; set; }
        public decimal? LuuLuongChayMay { get; set; }
        public decimal? YeuCauCapNuocHaDu { get; set; }
        public decimal? SanLuongHopDong { get; set; }
        public decimal? MucNuocDauThangQtlh { get; set; }
        public decimal? SanLuongDauCuc { get; set; }
        public decimal? SanLuongThucHien { get; set; }
    }
}
