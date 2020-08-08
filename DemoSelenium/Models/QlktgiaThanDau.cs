using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class QlktgiaThanDau
    {
        public int Id { get; set; }
        public int? UnitId { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public decimal? GiaThan { get; set; }
        public decimal? GiaDau { get; set; }
        public string GiaThanNhiet { get; set; }
    }
}
