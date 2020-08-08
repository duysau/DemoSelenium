using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class EsmSoLieuDoDem
    {
        public int Id { get; set; }
        public int MaDinhDanh { get; set; }
        public int IdLoaiCongSuatDiemDo { get; set; }
        public int IdLoaiKenhDiemDo { get; set; }
        public int ChuKi { get; set; }
        public decimal GiaTri { get; set; }
        public DateTime ThoiGian { get; set; }
        public int IdNhaMay { get; set; }
    }
}
