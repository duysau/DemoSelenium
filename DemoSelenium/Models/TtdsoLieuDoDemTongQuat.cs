using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdsoLieuDoDemTongQuat
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public int IdLoaiKenhDiemDo { get; set; }
        public int IdDiemDo { get; set; }
        public int SoChuKy { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
