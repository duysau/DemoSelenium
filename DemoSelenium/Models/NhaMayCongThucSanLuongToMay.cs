using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhaMayCongThucSanLuongToMay
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public string CongThuc { get; set; }
        public string Mota { get; set; }
        public DateTime? ThoiDiemBatDau { get; set; }
        public DateTime? ThoiDiemKetThuc { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public int IdLoaiCongThuc { get; set; }
    }
}
