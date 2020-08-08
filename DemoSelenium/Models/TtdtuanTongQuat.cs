using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdtuanTongQuat
    {
        public int Id { get; set; }
        public DateTime NgayBatDau { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
