using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongDonVi
    {
        public int Id { get; set; }
        public int MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public string TenTatDonVi { get; set; }
        public decimal? CongSuatDat { get; set; }
        public int? IdLoaiDonVi { get; set; }
        public int? UnitId { get; set; }
    }
}
