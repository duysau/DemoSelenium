using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongChiTieu
    {
        public int Id { get; set; }
        public int? UnitId { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public decimal? ChiTieuKhaDung { get; set; }
        public decimal? HeSoHuyDong { get; set; }
        public decimal? GiaThiTruongDuKien { get; set; }
        public decimal? GiaBanDienGiaoTangThem { get; set; }
        public decimal? SldauCucKeHoach { get; set; }
        public decimal? SlthuongPhamKehoach { get; set; }
        public decimal? DtthiTruong { get; set; }
        public decimal? DthopDong { get; set; }
        public decimal? GiaHopDong { get; set; }
        public decimal? DoanhThuKhac { get; set; }
        public decimal? GiaCoDinh { get; set; }
        public decimal? DonGiaCoDinh { get; set; }
    }
}
