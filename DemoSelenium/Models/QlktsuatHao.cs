using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class QlktsuatHao
    {
        public int Id { get; set; }
        public int? UnitId { get; set; }
        public DateTime? Ngay { get; set; }
        public decimal? SuatHaoThan { get; set; }
        public decimal? SuatHaoDau { get; set; }
        public decimal? SuatHaoNhiet { get; set; }
    }
}
