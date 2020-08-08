using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TrangThaiToMayTongQuat
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public decimal? HeSoKhaDung { get; set; }
        public int? SoChuKy { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
