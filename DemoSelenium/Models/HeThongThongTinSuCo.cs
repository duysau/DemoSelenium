using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThongTinSuCo
    {
        public int Id { get; set; }
        public int? IdToMay { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string NoiDung { get; set; }
    }
}
