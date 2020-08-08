using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LienKetToMayNhienLieuNgay
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public int IdNhienLieu { get; set; }
        public DateTime Ngay { get; set; }
    }
}
