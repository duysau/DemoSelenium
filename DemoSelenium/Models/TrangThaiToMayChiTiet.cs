using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TrangThaiToMayChiTiet
    {
        public int Id { get; set; }
        public int IdTrangThaiToMayTongQuat { get; set; }
        public int? ChuKy { get; set; }
        public string GiaTri { get; set; }
    }
}
