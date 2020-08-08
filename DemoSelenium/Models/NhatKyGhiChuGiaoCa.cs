using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyGhiChuGiaoCa
    {
        public int Id { get; set; }
        public int? IdNhatKyNhanCa { get; set; }
        public DateTime? Ngay { get; set; }
        public string NoiDung { get; set; }
    }
}
