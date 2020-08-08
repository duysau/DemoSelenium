using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtddinhDanhVungMienNgay
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public int SoChuKy { get; set; }
        public int IdVungMien { get; set; }
    }
}
