﻿using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdcongSuatCongBoNgayToiTongQuat
    {
        public int Id { get; set; }
        public DateTime? ThoiDiemBatDau { get; set; }
        public DateTime? ThoiDiemKetThuc { get; set; }
        public int? SoLuongChuKy { get; set; }
        public int? IdToMayNhienLieuNgay { get; set; }
        public int? IdNguonBanChao { get; set; }
    }
}
