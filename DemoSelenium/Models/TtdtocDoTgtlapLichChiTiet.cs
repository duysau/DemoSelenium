using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtocDoTgtlapLichChiTiet
    {
        public int Id { get; set; }
        public int? ChuKy { get; set; }
        public decimal? TangTai { get; set; }
        public decimal? GiamTai { get; set; }
        public int? IdTocDoTgtlapLichTongQuat { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
