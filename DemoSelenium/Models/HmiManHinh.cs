using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiManHinh
    {
        public HmiManHinh()
        {
            HmiManHinhChiTiet = new HashSet<HmiManHinhChiTiet>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string TenManHinh { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int? IdDonVi { get; set; }
        public int? IdNhaMay { get; set; }

        public virtual ICollection<HmiManHinhChiTiet> HmiManHinhChiTiet { get; set; }
    }
}
