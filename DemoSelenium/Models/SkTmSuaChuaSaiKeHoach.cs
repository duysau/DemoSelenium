using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class SkTmSuaChuaSaiKeHoach
    {
        public int Id { get; set; }
        public int? IdToMay { get; set; }
        public int? IdLoMay { get; set; }
        public int LoaiSuKien { get; set; }
        public DateTime ThoiDiemBatDauKeHoach { get; set; }
        public DateTime ThoiDiemKetThucKeHoach { get; set; }
        public DateTime ThoiDiemBatDauThucTe { get; set; }
        public DateTime ThoiDiemKetThucThucTe { get; set; }
        public string MoTa { get; set; }
        public string DuongDanFile { get; set; }
    }
}
