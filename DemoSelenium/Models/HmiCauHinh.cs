using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiCauHinh
    {
        public int Id { get; set; }
        public string Khoa { get; set; }
        public DateTime ThoiGian { get; set; }
        public string DuLieu { get; set; }
        public int TenantId { get; set; }
    }
}
