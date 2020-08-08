using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdthongTinHoChua
    {
        public int Id { get; set; }
        public string TenHo { get; set; }
        public decimal? MucNuocThuongLuu { get; set; }
        public decimal? MucNuocHaLuu { get; set; }
        public decimal? LuuLuongDenHo { get; set; }
        public decimal? TongLuuLuongXa { get; set; }
        public decimal? LuuLuongChayMay { get; set; }
        public decimal? LuuLuongXaQuaTran { get; set; }
        public int? SoCuaXaSau { get; set; }
        public int? SoCuaXaMat { get; set; }
        public DateTime? NgayGioDo { get; set; }
        public int? IdNhaMay { get; set; }
    }
}
