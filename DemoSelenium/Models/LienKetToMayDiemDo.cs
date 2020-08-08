using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LienKetToMayDiemDo
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public int IdDiemDo { get; set; }
        public DateTime? NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
