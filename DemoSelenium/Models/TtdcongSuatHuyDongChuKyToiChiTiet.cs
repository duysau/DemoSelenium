using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdcongSuatHuyDongChuKyToiChiTiet
    {
        public int Id { get; set; }
        public int? ChuKy { get; set; }
        public decimal? GiaTri { get; set; }
        public int? IdCongSuatHuyDongChuKyToiTongQuat { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
