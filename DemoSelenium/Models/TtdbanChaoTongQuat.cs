using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdbanChaoTongQuat
    {
        public TtdbanChaoTongQuat()
        {
            TtdbanChaoLapLichChiTiet = new HashSet<TtdbanChaoLapLichChiTiet>();
        }

        public int Id { get; set; }
        public int SoChuKy { get; set; }
        public DateTime Ngay { get; set; }
        public int IdToMayBlockNgay { get; set; }
        public int? IdNguonBanChao { get; set; }

        public virtual LienKetToMayBlockNgay IdToMayBlockNgayNavigation { get; set; }
        public virtual ICollection<TtdbanChaoLapLichChiTiet> TtdbanChaoLapLichChiTiet { get; set; }
    }
}
