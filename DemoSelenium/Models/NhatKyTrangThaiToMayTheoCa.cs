using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyTrangThaiToMayTheoCa
    {
        public int Id { get; set; }
        public string MaTm { get; set; }
        public int? Ca { get; set; }
        public DateTime? Ngay { get; set; }
        public int? TrangThai { get; set; }
        public int? IdNhatKyNhanCa { get; set; }
    }
}
