using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class LienKetToMayBlockNgay
    {
        public LienKetToMayBlockNgay()
        {
            TtdbanChaoTongQuat = new HashSet<TtdbanChaoTongQuat>();
        }

        public int Id { get; set; }
        public int IdToMay { get; set; }
        public int Block { get; set; }
        public DateTime Ngay { get; set; }

        public virtual HeThongToMay IdToMayNavigation { get; set; }
        public virtual ICollection<TtdbanChaoTongQuat> TtdbanChaoTongQuat { get; set; }
    }
}
