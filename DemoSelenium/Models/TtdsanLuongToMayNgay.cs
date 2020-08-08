using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdsanLuongToMayNgay
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public int IdLoaiSanLuong { get; set; }
        public int ChuKy { get; set; }
        public decimal GiaTri { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
