using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongToMay
    {
        public HeThongToMay()
        {
            LienKetToMayBlockNgay = new HashSet<LienKetToMayBlockNgay>();
        }

        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public decimal CongSuatThietKeNhoNhat { get; set; }
        public decimal CongSuatThietKeLonNhat { get; set; }
        public string TenToMay { get; set; }
        public int IdToMay { get; set; }
        public string MaToMay { get; set; }
        public decimal? ThoiGianKhoiDongToMay { get; set; }
        public int? IdNhienLieu { get; set; }
        public string TagScada { get; set; }

        public virtual HeThongNhaMay IdNhaMayNavigation { get; set; }
        public virtual ICollection<LienKetToMayBlockNgay> LienKetToMayBlockNgay { get; set; }
    }
}
