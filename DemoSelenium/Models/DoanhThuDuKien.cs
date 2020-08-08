using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class DoanhThuDuKien
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal? SanLuongDauCucKeHoach { get; set; }
        public decimal? GiaHopDong { get; set; }
        public decimal? GiaTtduKien { get; set; }
        public decimal? DoanhThuHopDong { get; set; }
        public decimal? DoanhThuThiTruong { get; set; }
        public decimal? DoanhThuPhatTangThem { get; set; }
        public int LoaiChiTieu { get; set; }
        public decimal? SanLuongThuongPhamKeHoach { get; set; }
    }
}
