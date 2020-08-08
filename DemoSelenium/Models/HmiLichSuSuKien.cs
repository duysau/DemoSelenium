using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiLichSuSuKien
    {
        public int Id { get; set; }
        public string TenOpc { get; set; }
        public int NhomTheId { get; set; }
        public DateTime ThoiGian { get; set; }
        public string GiaTri { get; set; }
        public string State { get; set; }
        public string Operator { get; set; }
        public int Loai { get; set; }
        public string MoTa { get; set; }
    }
}
