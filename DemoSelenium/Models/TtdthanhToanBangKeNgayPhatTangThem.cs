using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthanhToanBangKeNgayPhatTangThem
    {
        public int Id { get; set; }
        public int IdTtdthanhToanBangKeNgayTongQuat { get; set; }
        public int IdToMay { get; set; }
        public int ChuKy { get; set; }
        public decimal? SanLuong { get; set; }
        public decimal? GiaThanhToan { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
