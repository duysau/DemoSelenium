using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongNhanHmi
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public string LoaiNhan { get; set; }
        public string LoaiDuLieu { get; set; }
    }
}
