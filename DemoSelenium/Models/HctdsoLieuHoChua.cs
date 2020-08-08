using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HctdsoLieuHoChua
    {
        public int Id { get; set; }
        public int IdHoChua { get; set; }
        public DateTime GioDo { get; set; }
        public DateTime NgayDo { get; set; }
        public decimal MucNuocThuongLuu { get; set; }
        public decimal MucNuocHaLuu { get; set; }
        public decimal LuuLuongDenHo { get; set; }
        public decimal TongLuuLuongXa { get; set; }
        public decimal LuuLuongChayMay { get; set; }
        public decimal LuuLuongXaQuaTran { get; set; }
        public int? SoCuaXaSau { get; set; }
        public int? SoCuaXaMat { get; set; }
        public decimal? LuuLuongXaQuaTranLonNhatDuKien { get; set; }
    }
}
