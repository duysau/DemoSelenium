using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiLoaiThietBi
    {
        public HmiLoaiThietBi()
        {
            HmiThietBi = new HashSet<HmiThietBi>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string HinhAnh { get; set; }
        public bool ChoPhepDieuKhien { get; set; }
        public string BoDieuKhienThuNhat { get; set; }
        public string BoDieuKhienThuHai { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<HmiThietBi> HmiThietBi { get; set; }
    }
}
