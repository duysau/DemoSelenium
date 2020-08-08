using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoNgayToiChiTiet
    {
        public int Id { get; set; }
        public int ChuKy { get; set; }
        public decimal CongSuat { get; set; }
        public decimal? GiaChao { get; set; }
        public int IdBanChaoTongQuat { get; set; }
        public int? IdLoaiNguonBanChao { get; set; }
    }
}
