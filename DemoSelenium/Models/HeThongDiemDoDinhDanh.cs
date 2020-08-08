using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongDiemDoDinhDanh
    {
        public int IdDiemDo { get; set; }
        public int MaDinhDanh { get; set; }
        public DateTime? NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
