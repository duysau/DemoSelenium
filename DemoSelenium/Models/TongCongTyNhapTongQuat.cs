using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TongCongTyNhapTongQuat
    {
        public int Id { get; set; }
        public int IdLoaiDuLieuNhap { get; set; }
        public int IdLoaiThoiGianNhapDuLieu { get; set; }
        public int? SoChuKy { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? IdNhaMay { get; set; }
        public int? IdToMay { get; set; }
    }
}
