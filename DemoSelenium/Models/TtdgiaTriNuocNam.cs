using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdgiaTriNuocNam
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal GiaTriNuoc { get; set; }
        public int? Nam { get; set; }
    }
}
