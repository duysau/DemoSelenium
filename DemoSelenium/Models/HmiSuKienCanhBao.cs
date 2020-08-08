using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiSuKienCanhBao
    {
        public int Id { get; set; }
        public string TenOpc { get; set; }
        public string GiaTri { get; set; }
        public DateTime ThoiGian { get; set; }
        public int TrangThai { get; set; }
        public string MoTa { get; set; }
    }
}
