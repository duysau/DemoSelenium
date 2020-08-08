using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeThangThiTruong
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeThangTongQuat { get; set; }
        public DateTime ThoiGian { get; set; }
        public decimal? ThanhToanGiaSmp { get; set; }
        public decimal? ThanhToanGiaChao { get; set; }
        public decimal? ThanhToanSanLuongPhatTangThem { get; set; }
        public decimal? ThanhToanDienNangPhatTangThem { get; set; }
        public decimal? Tong { get; set; }
    }
}
