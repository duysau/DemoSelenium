using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtoMayBienChuKyToi
    {
        public int Id { get; set; }
        public int ChuKy { get; set; }
        public string ToMay { get; set; }
        public int IdDinhDanhVungMienNgay { get; set; }
    }
}
