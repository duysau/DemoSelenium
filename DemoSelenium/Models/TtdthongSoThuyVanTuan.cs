using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthongSoThuyVanTuan
    {
        public int Id { get; set; }
        public int IdHoChua { get; set; }
        public decimal MucNuocDauTuan { get; set; }
        public decimal MucNuocCuoiTuan { get; set; }
        public decimal MucNuocGioiHan { get; set; }
        public decimal ChenhLech { get; set; }
        public decimal LuongNuocXa { get; set; }
        public decimal LuuLuongNuocVeTrungBinhTuan { get; set; }
        public decimal? GiaTriNuoc { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
