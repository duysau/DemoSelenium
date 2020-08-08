using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThoiGianKhoiDong
    {
        public int Id { get; set; }
        public int? UnitId { get; set; }
        public int? ThoiGianDungMayNhoNhat { get; set; }
        public int? ThoiGianDungMayLonNhat { get; set; }
        public string TrangThai { get; set; }
        public decimal? ThoiGianKdhdb { get; set; }
        public decimal? ThoiGianHdbpmin { get; set; }
        public int? ThoiGianKhoiDong { get; set; }
    }
}
