using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class CauHinh
    {
        public int Id { get; set; }
        public int? SoChuKy { get; set; }
        public int? SoBlock { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
