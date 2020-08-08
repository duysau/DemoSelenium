using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoDuyet
    {
        public int Id { get; set; }
        public int? IdNhaMay { get; set; }
        public DateTime? Ngay { get; set; }
        public int? Duyet { get; set; }
    }
}
