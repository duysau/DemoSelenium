using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThongBao
    {
        public int Id { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string NoiDungThongBao { get; set; }
        public int? IdDonVi { get; set; }
    }
}
