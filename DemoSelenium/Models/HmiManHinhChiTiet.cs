using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiManHinhChiTiet
    {
        public int Id { get; set; }
        public DateTime Timeline { get; set; }
        public string DuLieu { get; set; }
        public int IdHmiManHinh { get; set; }
        public string Svg { get; set; }

        public virtual HmiManHinh IdHmiManHinhNavigation { get; set; }
    }
}
