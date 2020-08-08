using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class GctrangThaiVanHanhToMay
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public DateTime ThoiDiemBatDau { get; set; }
        public int IdLoaiSuKien { get; set; }
        public string MoTa { get; set; }
    }
}
