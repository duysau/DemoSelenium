using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LienKetDiemDoLoaiDuPhong
    {
        public int Id { get; set; }
        public int IdDiemDo { get; set; }
        public int IdLoaiDuPhong { get; set; }
        public DateTime NgayApDung { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
    }
}
