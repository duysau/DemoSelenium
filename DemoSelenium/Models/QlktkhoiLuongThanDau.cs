using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class QlktkhoiLuongThanDau
    {
        public int Id { get; set; }
        public DateTime? Ngay { get; set; }
        public int? UnitId { get; set; }
        public decimal? KhoiLuongThan { get; set; }
        public decimal? KhoiLuongDau { get; set; }
    }
}
