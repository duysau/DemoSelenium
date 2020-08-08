using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class SanLuongThieuHut
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime Ngay { get; set; }
        public decimal? SlthieuHutDoSuCoTm { get; set; }
        public decimal? SlthieuHutDoSuyGiamCs { get; set; }
        public decimal? SlthieuHutKhachQuan { get; set; }
        public decimal? SlhopDongQcBiCat { get; set; }
        public int? UnitId { get; set; }
    }
}
