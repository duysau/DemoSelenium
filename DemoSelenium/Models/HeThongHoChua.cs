using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongHoChua
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }
        public string DiaChi { get; set; }
        public decimal? DungTichTong { get; set; }
        public decimal? DungTichHuuIch { get; set; }
        public decimal? DungTichChet { get; set; }
        public decimal? MucNuocChet { get; set; }
        public int? IdHoChua { get; set; }
        public string LuuVucSong { get; set; }
        public int? IdNhaMay { get; set; }
    }
}
