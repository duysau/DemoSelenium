using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LienKetDiemDoLoaiDiemDo
    {
        public int Id { get; set; }
        public int IdDiemDo { get; set; }
        public int IdLoaiDiemDo { get; set; }
        public DateTime? NgayApDung { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
