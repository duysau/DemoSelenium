using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LuuLuongNuocVeTheoTanSuat
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public int TanSuat { get; set; }
        public decimal LuuLuong { get; set; }
        public int Thang { get; set; }
    }
}
