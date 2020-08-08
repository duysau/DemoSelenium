using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoThongTinNguoiSuDung
    {
        public int Id { get; set; }
        public int? IdDonVi { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayBanChao { get; set; }
        public long? NguoiTao { get; set; }
        public int? LoaiHinh { get; set; }
    }
}
