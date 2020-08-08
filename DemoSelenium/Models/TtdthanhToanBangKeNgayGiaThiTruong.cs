using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeNgayGiaThiTruong
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeNgayTongQuat { get; set; }
        public int ChuKy { get; set; }
        public decimal? SanLuong { get; set; }
        public decimal? GiaDienNangThiTruong { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
