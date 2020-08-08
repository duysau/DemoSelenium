using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthiTruongSauVanHanh
    {
        public int Id { get; set; }
        public int ChuKy { get; set; }
        public decimal GiaChaoLapLichLonNhat { get; set; }
        public decimal GiaChaoLapLichNhoNhat { get; set; }
        public decimal SanLuongThuongPham { get; set; }
        public decimal SanLuongLapLichTinhToan { get; set; }
        public int IdThongTinTongQuat { get; set; }
    }
}
