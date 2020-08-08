using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtinhHinhThuThapSoLieu
    {
        public int Id { get; set; }
        public int? IdLoaiNguon { get; set; }
        public int? IdLoaiDuPhong { get; set; }
        public int? ThuThapDu { get; set; }
        public int? ThuThapThieu { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
