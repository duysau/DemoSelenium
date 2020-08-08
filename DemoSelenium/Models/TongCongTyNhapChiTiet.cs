using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TongCongTyNhapChiTiet
    {
        public int Id { get; set; }
        public int IdTongCongTyNhapTongQuat { get; set; }
        public int? ChuKy { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
