using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NhatKyNhanCa
    {
        public int Id { get; set; }
        public DateTime? ThoiDiemNhanCa { get; set; }
        public int? IdUser { get; set; }
        public string UserA0 { get; set; }
        public string UserA1 { get; set; }
        public string TkLoMay { get; set; }
        public string TkDien { get; set; }
        public string TkHoa { get; set; }
        public string TkNhienLieu { get; set; }
        public string CI { get; set; }
        public DateTime? ThoiDiemGiaoCa { get; set; }
        public DateTime? NgayThuchien { get; set; }
    }
}
