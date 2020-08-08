using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeThangTongHopThang
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeThangTongQuat { get; set; }
        public decimal? ThanhToanGiaDienNangThiTruong { get; set; }
        public decimal? ThanhToanGiaChao { get; set; }
        public decimal? ThanhToanSanLuongPhatTangThem { get; set; }
        public decimal? ThanhToanSanLuongSaiKhac { get; set; }
        public decimal? ThanhToanCongSuatThiTruong { get; set; }
        public decimal? ThanhToanSanLuongDieuChinhTanSo { get; set; }
        public decimal? ThanhToanKhac { get; set; }
    }
}
