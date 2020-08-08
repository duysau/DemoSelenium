using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdphuTaiChuKyToi
    {
        public int Id { get; set; }
        public int ChuKy { get; set; }
        public decimal GiaTri { get; set; }
        public int IdDinhDanhVungMienNgay { get; set; }
    }
}
