using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class ChiPhiCoDinhKhongTheThuHoi
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime Ngay { get; set; }
        public decimal? LnthieuHutDoTmbiSuCo { get; set; }
        public decimal? LnthieuHutDoTmsuyGiamCs { get; set; }
        public decimal? ChiPhiCoDinhBiCatDoBiCatQc { get; set; }
        public decimal? ChiPhiBienDoiThucTe { get; set; }
        public decimal? ChiPhiBienDoiCoDinh { get; set; }
        public int? UnitId { get; set; }
        public int? IdNhomBaoCao { get; set; }
        public decimal? GiaBienDoiThucTe { get; set; }
    }
}
