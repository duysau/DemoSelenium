using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdcongSuatCongBoChuKyToiChiTiet
    {
        public int Id { get; set; }
        public int? ChuKy { get; set; }
        public decimal? Pmin { get; set; }
        public decimal? Pmax { get; set; }
        public int? IdCongSuatCongBoTongQuat { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
