using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class QlktbaoCaoThang
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public DateTime Ngay { get; set; }
        public decimal SanLuongDauCuc { get; set; }
        public decimal SanLuongThuongPham { get; set; }
        public decimal SanLuongTuDung { get; set; }
        public decimal PhanTramTuDung { get; set; }
        public decimal SoGioVanHanh { get; set; }
        public decimal CongSuatPhatBinhQuan { get; set; }
        public decimal NhienLieuThanTieuThu { get; set; }
        public decimal SuatHaoThan { get; set; }
        public decimal NhienLieuDauFotrungBinh { get; set; }
        public decimal SuatHaoDauFo { get; set; }
    }
}
