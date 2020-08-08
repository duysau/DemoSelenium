using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyTrangThaiThietBiKhiGiao
    {
        public int Id { get; set; }
        public int? IdThietBi { get; set; }
        public int? TrangThai { get; set; }
        public string GiaTri { get; set; }
        public int? IdNhatKyNhanCa { get; set; }
    }
}
