using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThongSoHoChua
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public decimal? MucNuoc { get; set; }
        public decimal? DungTich { get; set; }
        public decimal? CotNuoc { get; set; }
        public decimal? SuatTieuHaoNuoc { get; set; }
        public decimal? CotNuocThuongLuu { get; set; }
    }
}
