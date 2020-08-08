using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongSanLuongChotThang
    {
        public int Id { get; set; }
        public int? UnitId { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public decimal? SanLuongDauCuc { get; set; }
    }
}
