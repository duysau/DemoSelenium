using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyGhiChuNhienLieu
    {
        public int Id { get; set; }
        public string ThanTon { get; set; }
        public string DauDotLo { get; set; }
        public string DauTon { get; set; }
        public string GiaoCa { get; set; }
        public string NhanCa { get; set; }
        public int? IdNhatKyNhanCa { get; set; }
    }
}
