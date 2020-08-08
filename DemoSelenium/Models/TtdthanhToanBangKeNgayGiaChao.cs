using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeNgayGiaChao
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeNgayTongQuat { get; set; }
        public int ChuKy { get; set; }
        public int IdToMay { get; set; }
        public decimal? CongSuat { get; set; }
        public decimal? GiaChao { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? Block { get; set; }
    }
}
