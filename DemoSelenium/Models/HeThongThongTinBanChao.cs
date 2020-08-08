using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HeThongThongTinBanChao
    {
        public int Id { get; set; }
        public int IdToMay { get; set; }
        public DateTime Ngay { get; set; }
        public string TinhHinhVanHanh { get; set; }
        public string KeHoachCongTac { get; set; }
        public decimal? CongSuatNhoNhat { get; set; }
        public decimal? CongSuatLonNhat { get; set; }
        public decimal? SuatTieuHaoThan { get; set; }
        public decimal? ChiPhiVatLieuPhu { get; set; }
        public decimal? TyLeDienTuDung { get; set; }
        public decimal? ChiPhiBienDoiBinhQuan { get; set; }
        public string ThongTinKhac { get; set; }
        public string ThongTinPhuongThucTruyenTai { get; set; }
        public string ThongTinVanHanhNgay { get; set; }
        public string ChienLuocVanHanhNgayD1 { get; set; }
        public decimal? SanLuongHopDongQuyDoiVeDauCuc { get; set; }
        public decimal? SanLuongPhatDuKien { get; set; }
        public string GhiChu { get; set; }
        public string ThongTinLuuYtrenHeThong { get; set; }
        public string YeuCauCapNuocHaDu { get; set; }
        public decimal? SanLuongPhatDuCapNuocHaDu { get; set; }
        public decimal? LuuLuongNuocVeDuKien { get; set; }
        public decimal? LuuLuongChayMayDuKien { get; set; }
        public decimal? MucNuocCuoiNgay { get; set; }
    }
}
