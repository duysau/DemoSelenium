using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoNguoiDungGhiChu
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public int? IdDonVi { get; set; }
        public DateTime? NgayBanChao { get; set; }
        public int? NguoiGhiChu { get; set; }
        public DateTime? NgayGhiChu { get; set; }
        public string NoiDung { get; set; }
        public int? LoaiHinh { get; set; }
    }
}
