using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class GiaTriNuocTuan
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
