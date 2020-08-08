using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiNhatKyDongCat
    {
        public int Id { get; set; }
        public string TaiKhoan { get; set; }
        public string TenEsLink { get; set; }
        public bool? GiaTri { get; set; }
        public bool? ThanhCong { get; set; }
        public DateTime? ThoiGian { get; set; }
    }
}
