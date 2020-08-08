using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeNgayTongHopNgay
    {
        public int Id { get; set; }
        public int IdThanhToanBangKeNgayTongQuat { get; set; }
        public decimal? ThanhToanTheoGiaDienNang { get; set; }
        public decimal? ThanhToanTheoGiaChao { get; set; }
        public decimal? ThanhToanSanLuongPhatTangThem { get; set; }
        public decimal? ThanhToanSanLuongSaiKhac { get; set; }
        public decimal? ThanhToanCongSuatThiTruong { get; set; }
        public decimal? ThanhToanSanLuongDieuChinhTanSo { get; set; }
        public decimal? ThanhToanKhac { get; set; }
    }
}
