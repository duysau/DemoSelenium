using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class SkTmDuPhongDieuChinhTanSoSmo
    {
        public int Id { get; set; }
        public int? IdToMay { get; set; }
        public DateTime ThoiDiemBatDau { get; set; }
        public DateTime ThoiDiemKetThuc { get; set; }
        public string MoTa { get; set; }
        public string DuongDanFile { get; set; }
    }
}
