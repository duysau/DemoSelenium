using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeThangSanLuongNgoaiThiTruong
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeThangTongQuat { get; set; }
        public int IdToMay { get; set; }
        public DateTime ThoiGian { get; set; }
        public int Gio { get; set; }
        public decimal? SanLuong { get; set; }
    }
}
