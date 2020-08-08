using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyThucHienCa
    {
        public int Id { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string NoiDung { get; set; }
        public string TrangThai { get; set; }
        public int? IdNhatKyNhanCa { get; set; }
    }
}
