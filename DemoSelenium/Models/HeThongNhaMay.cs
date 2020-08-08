using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongNhaMay
    {
        public HeThongNhaMay()
        {
            HeThongToMay = new HashSet<HeThongToMay>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public decimal CongSuatThietKe { get; set; }
        public DateTime NgayVanHanh { get; set; }
        public int IdVungMien { get; set; }
        public int IdLoaiNhaMay { get; set; }
        public int IdDonVi { get; set; }
        public int IdNhaMay { get; set; }
        public string MaNhaMay { get; set; }
        public string TenDayDu { get; set; }
        public int? UnitId { get; set; }
        public decimal? HeSo { get; set; }
        public int? IdNhomBaoCao { get; set; }
        public int? IdNhomBanChao { get; set; }
        public int? UnitIdDonVi { get; set; }
        public int? IdNhomThuyVan { get; set; }
        public int? IdNhomDoanhThu { get; set; }
        public bool? IsTddtduoi2Ngay { get; set; }
        public string TenTatNm { get; set; }
        public string ImageScadaSrc { get; set; }

        public virtual ICollection<HeThongToMay> HeThongToMay { get; set; }
    }
}
