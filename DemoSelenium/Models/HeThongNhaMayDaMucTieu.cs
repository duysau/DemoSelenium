using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongNhaMayDaMucTieu
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int? IdNhaMay { get; set; }
        public int? UnitId { get; set; }
        public string TenTatNm { get; set; }
        public int? IdLoaiNhaMay { get; set; }
    }
}
