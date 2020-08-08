using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongSoLieuNhanHmi
    {
        public int Id { get; set; }
        public int? IdNhanHmi { get; set; }
        public DateTime? Ngay { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
