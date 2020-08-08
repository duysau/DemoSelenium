using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiThietBi
    {
        public HmiThietBi()
        {
            HmiThe = new HashSet<HmiThe>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenHienThi { get; set; }
        public string FirstControllerTagName { get; set; }
        public string FirstControllerValue { get; set; }
        public string SecondControllerTagName { get; set; }
        public string SecondControllerValue { get; set; }
        public string ControllerValue { get; set; }
        public string ViTri { get; set; }
        public string DiaChi { get; set; }
        public string DiaChiIp { get; set; }
        public bool TrangThai { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int LoaiThietBiId { get; set; }

        public virtual HmiLoaiThietBi LoaiThietBi { get; set; }
        public virtual ICollection<HmiThe> HmiThe { get; set; }
    }
}
