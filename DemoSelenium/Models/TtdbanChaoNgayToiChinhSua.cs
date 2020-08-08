using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoNgayToiChinhSua
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public int? IdToMay { get; set; }
        public DateTime? Ngay { get; set; }
        public int? ChuKy { get; set; }
        public int? Block { get; set; }
        public int? IdRefer { get; set; }
        public int? Loai { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
