using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeNgayNgoaiLenhDieuDo
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeNgayTongQuat { get; set; }
        public int IdToMay { get; set; }
        public int ChuKy { get; set; }
        public decimal? SanLuong { get; set; }
        public decimal? Gia { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
