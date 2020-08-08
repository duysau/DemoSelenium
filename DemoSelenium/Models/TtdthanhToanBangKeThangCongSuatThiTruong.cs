using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeThangCongSuatThiTruong
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeThangTongQuat { get; set; }
        public DateTime ThoiGian { get; set; }
        public decimal? ThanhToanCongSuatThiTruong { get; set; }
    }
}
