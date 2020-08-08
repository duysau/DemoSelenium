using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongHoChuaDaMucTieu
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int IdHoChua { get; set; }
        public int IdNhaMay { get; set; }
    }
}
