using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtrangThaiToMayChiTiet
    {
        public int Id { get; set; }
        public int IdTrangThaiToMayTongQuat { get; set; }
        public int ChuKy { get; set; }
        public bool? IsChuKyKhoiDong { get; set; }
        public bool? IsChuKyNgungMay { get; set; }
        public bool? IsChuKyThamGiaAgc { get; set; }
        public bool? IsChuKyChuTrinhDon { get; set; }
        public bool? IsChuKyChayDau { get; set; }
        public bool? IsChuKyDieuTan { get; set; }
        public bool? IsChuKyNgoaiThiTruong { get; set; }
        public bool? IsChuKyKhongTinhQdu { get; set; }
        public bool? IsChuKyThieuKhi { get; set; }
        public bool? IsChuKyThieuThan { get; set; }
        public bool? IsChuKySuCoQua72h { get; set; }
        public bool? IsChuKySuaChuaKeoDai { get; set; }
    }
}
