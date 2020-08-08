using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtddinhDanhToMayNgay
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public int? SoChuKy { get; set; }
        public int? IdToMay { get; set; }
    }
}
