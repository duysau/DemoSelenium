using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtinhTrangThieuThan
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime? Ngay { get; set; }
        public int? IdToMay { get; set; }
        public DateTime? ThoiDiemBatDau { get; set; }
        public DateTime? ThoiDiemKetThuc { get; set; }
        public string GhiChu { get; set; }
    }
}
