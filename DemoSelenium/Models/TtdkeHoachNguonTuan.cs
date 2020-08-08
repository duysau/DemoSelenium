using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdkeHoachNguonTuan
    {
        public int Id { get; set; }
        public int IdNhaMay { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal SanLuongTrungBinh { get; set; }
        public decimal SanLuongThu2 { get; set; }
        public decimal SanLuongThu3 { get; set; }
        public decimal SanLuongThu4 { get; set; }
        public decimal SanLuongThu5 { get; set; }
        public decimal SanLuongThu6 { get; set; }
        public decimal SanLuongThu7 { get; set; }
        public decimal SanLuongChuNhat { get; set; }
    }
}
