using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiLichSuDuLieu
    {
        public int Id { get; set; }
        public string TenOpc { get; set; }
        public string GiaTri { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int Loai { get; set; }
    }
}
