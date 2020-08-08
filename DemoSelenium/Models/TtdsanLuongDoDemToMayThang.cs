using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdsanLuongDoDemToMayThang
    {
        public int Id { get; set; }
        public int? IdToMay { get; set; }
        public DateTime? Ngay { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public int? IdLoaiSanLuong { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
