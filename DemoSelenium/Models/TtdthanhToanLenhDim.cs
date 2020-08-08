using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanLenhDim
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public string KieuLenh { get; set; }
        public DateTime ThoiDiemGuiLenh { get; set; }
        public DateTime ThoiDiemNhanLenh { get; set; }
        public DateTime ThoiDiemBatDau { get; set; }
        public decimal? CongSuatRaLenh { get; set; }
        public string NguoiRaLenh { get; set; }
        public DateTime ThoiDiemHoanThanh { get; set; }
        public decimal? CongSuatThucHien { get; set; }
        public string NguoiThucHien { get; set; }
        public string GhiChu { get; set; }
        public bool? LenhNhapLai { get; set; }
        public bool? LenhCum { get; set; }
        public string IdLenh { get; set; }
    }
}
