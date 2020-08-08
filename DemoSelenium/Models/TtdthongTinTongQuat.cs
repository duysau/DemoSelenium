using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthongTinTongQuat
    {
        public int Id { get; set; }
        public int SoChuKy { get; set; }
        public DateTime Ngay { get; set; }
        public int? IdNhaMay { get; set; }
        public int? UnitId { get; set; }
    }
}
