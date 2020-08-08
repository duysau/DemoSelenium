using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThongTinCoSoDuLieu
    {
        public int Id { get; set; }
        public string SeverName { get; set; }
        public string Dbname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IdnhaMay { get; set; }
        public string Scada { get; set; }
    }
}
