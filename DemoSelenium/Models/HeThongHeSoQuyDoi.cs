using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongHeSoQuyDoi
    {
        public int IdHeSoQuyDoi { get; set; }
        public int? UnitId { get; set; }
        public int? IdLoaiHeSoQuyDoi { get; set; }
        public DateTime? NgayApDung { get; set; }
        public decimal? HeSoQuyDoi { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? Id { get; set; }
    }
}
