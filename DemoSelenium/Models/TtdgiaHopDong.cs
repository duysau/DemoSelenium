using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdgiaHopDong
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public DateTime NgayApDung { get; set; }
        public decimal? GiaHopDong { get; set; }
    }
}
