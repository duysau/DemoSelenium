using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LuuTruTaiLieuThanhToan
    {
        public int Id { get; set; }
        public string TenFile { get; set; }
        public string DuongDan { get; set; }
        public int? IdNhaMay { get; set; }
        public int? IdDonVi { get; set; }
        public string MoTa { get; set; }
        public DateTime? Ngay { get; set; }
        public string MaTaiLieu { get; set; }
    }
}
