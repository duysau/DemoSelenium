using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdsanLuongHopDongNam
    {
        public int Id { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal? GiaTri { get; set; }
        public int UnitId { get; set; }
    }
}
