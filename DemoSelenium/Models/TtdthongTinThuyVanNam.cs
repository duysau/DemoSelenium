using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthongTinThuyVanNam
    {
        public int Id { get; set; }
        public int Nam { get; set; }
        public int Thang { get; set; }
        public decimal MucNuocDauThang { get; set; }
        public decimal MucNuocCuoiThang { get; set; }
        public decimal ChenhLech { get; set; }
        public decimal LuongNuocXa { get; set; }
        public decimal LuuLuongNuocVeTrungBinhTuan { get; set; }
        public string GhiChu { get; set; }
        public int IdHoChua { get; set; }
    }
}
