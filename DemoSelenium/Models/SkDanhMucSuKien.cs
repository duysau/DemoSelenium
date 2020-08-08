using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class SkDanhMucSuKien
    {
        public int IdSuKien { get; set; }
        public string TenSuKien { get; set; }
        public string MaSuKien { get; set; }
        public string BangLuuTru { get; set; }
        public int? Stt { get; set; }
    }
}
