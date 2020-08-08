using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdkeHoachVanHanhGioToiChiTiet
    {
        public int Id { get; set; }
        public int IdKeHoachVanHanhGioToiTongQuat { get; set; }
        public int ChuKy { get; set; }
        public decimal GiaTri { get; set; }
    }
}
