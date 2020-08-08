using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyDanhSachThietBi
    {
        public int Id { get; set; }
        public string TenThietBi { get; set; }
        public int? LoaiHinhThietBi { get; set; }
        public int? Stt { get; set; }
        public bool? CoGiaTri { get; set; }
    }
}
