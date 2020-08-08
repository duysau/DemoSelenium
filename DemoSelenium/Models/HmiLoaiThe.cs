using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiLoaiThe
    {
        public HmiLoaiThe()
        {
            HmiThe = new HashSet<HmiThe>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<HmiThe> HmiThe { get; set; }
    }
}
