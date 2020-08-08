using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyMenhLenhCapTren
    {
        public int Id { get; set; }
        public int? IdUserRaLenh { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string NoiDung { get; set; }
    }
}
