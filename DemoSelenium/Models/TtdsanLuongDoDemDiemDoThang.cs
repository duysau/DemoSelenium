using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdsanLuongDoDemDiemDoThang
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime? Ngay { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public int? IdDiemDo { get; set; }
        public int? IdLoaiKenhDiemDo { get; set; }
        public decimal? GiaTri { get; set; }
    }
}
