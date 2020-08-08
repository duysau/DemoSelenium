using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdnhaMayViPhamMucNuoc
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal MucNuoc0hChuNhat { get; set; }
        public decimal MucNuocGioiHan { get; set; }
        public string GhiChu { get; set; }
    }
}
