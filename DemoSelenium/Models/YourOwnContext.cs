using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoSelenium.Models
{
    public partial class YourOwnContext : DbContext
    {
        public YourOwnContext()
        {
        }

        public YourOwnContext(DbContextOptions<YourOwnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbpAuditLogs> AbpAuditLogs { get; set; }
        public virtual DbSet<AbpBackgroundJobs> AbpBackgroundJobs { get; set; }
        public virtual DbSet<AbpEditions> AbpEditions { get; set; }
        public virtual DbSet<AbpEntityChangeSets> AbpEntityChangeSets { get; set; }
        public virtual DbSet<AbpEntityChanges> AbpEntityChanges { get; set; }
        public virtual DbSet<AbpEntityPropertyChanges> AbpEntityPropertyChanges { get; set; }
        public virtual DbSet<AbpFeatures> AbpFeatures { get; set; }
        public virtual DbSet<AbpLanguageTexts> AbpLanguageTexts { get; set; }
        public virtual DbSet<AbpLanguages> AbpLanguages { get; set; }
        public virtual DbSet<AbpNotificationSubscriptions> AbpNotificationSubscriptions { get; set; }
        public virtual DbSet<AbpNotifications> AbpNotifications { get; set; }
        public virtual DbSet<AbpOrganizationUnitRoles> AbpOrganizationUnitRoles { get; set; }
        public virtual DbSet<AbpOrganizationUnits> AbpOrganizationUnits { get; set; }
        public virtual DbSet<AbpPermissions> AbpPermissions { get; set; }
        public virtual DbSet<AbpPersistedGrants> AbpPersistedGrants { get; set; }
        public virtual DbSet<AbpRoleClaims> AbpRoleClaims { get; set; }
        public virtual DbSet<AbpRoles> AbpRoles { get; set; }
        public virtual DbSet<AbpSettings> AbpSettings { get; set; }
        public virtual DbSet<AbpTenantNotifications> AbpTenantNotifications { get; set; }
        public virtual DbSet<AbpTenants> AbpTenants { get; set; }
        public virtual DbSet<AbpUserAccounts> AbpUserAccounts { get; set; }
        public virtual DbSet<AbpUserClaims> AbpUserClaims { get; set; }
        public virtual DbSet<AbpUserLoginAttempts> AbpUserLoginAttempts { get; set; }
        public virtual DbSet<AbpUserLogins> AbpUserLogins { get; set; }
        public virtual DbSet<AbpUserNotifications> AbpUserNotifications { get; set; }
        public virtual DbSet<AbpUserOrganizationUnits> AbpUserOrganizationUnits { get; set; }
        public virtual DbSet<AbpUserRoles> AbpUserRoles { get; set; }
        public virtual DbSet<AbpUserTokens> AbpUserTokens { get; set; }
        public virtual DbSet<AbpUsers> AbpUsers { get; set; }
        public virtual DbSet<AppBinaryObjects> AppBinaryObjects { get; set; }
        public virtual DbSet<AppChatMessages> AppChatMessages { get; set; }
        public virtual DbSet<AppFriendships> AppFriendships { get; set; }
        public virtual DbSet<AppInvoices> AppInvoices { get; set; }
        public virtual DbSet<AppSubscriptionPayments> AppSubscriptionPayments { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<CauHinh> CauHinh { get; set; }
        public virtual DbSet<ChiPhiCoDinhKhongTheThuHoi> ChiPhiCoDinhKhongTheThuHoi { get; set; }
        public virtual DbSet<DoanhThuDuKien> DoanhThuDuKien { get; set; }
        public virtual DbSet<EsmSoLieuDoDem> EsmSoLieuDoDem { get; set; }
        public virtual DbSet<GcloaiSuKienToMay> GcloaiSuKienToMay { get; set; }
        public virtual DbSet<GctrangThaiVanHanhToMay> GctrangThaiVanHanhToMay { get; set; }
        public virtual DbSet<GiaTriNuocTuan> GiaTriNuocTuan { get; set; }
        public virtual DbSet<HctdsoLieuHoChua> HctdsoLieuHoChua { get; set; }
        public virtual DbSet<HeThongChiTieu> HeThongChiTieu { get; set; }
        public virtual DbSet<HeThongDiemDo> HeThongDiemDo { get; set; }
        public virtual DbSet<HeThongDiemDoDinhDanh> HeThongDiemDoDinhDanh { get; set; }
        public virtual DbSet<HeThongDonVi> HeThongDonVi { get; set; }
        public virtual DbSet<HeThongHeSoQuyDoi> HeThongHeSoQuyDoi { get; set; }
        public virtual DbSet<HeThongHoChua> HeThongHoChua { get; set; }
        public virtual DbSet<HeThongHoChuaDaMucTieu> HeThongHoChuaDaMucTieu { get; set; }
        public virtual DbSet<HeThongIdManHinhHmi> HeThongIdManHinhHmi { get; set; }
        public virtual DbSet<HeThongLoaiHinhNmd> HeThongLoaiHinhNmd { get; set; }
        public virtual DbSet<HeThongMauSac> HeThongMauSac { get; set; }
        public virtual DbSet<HeThongMucNuocHoChua> HeThongMucNuocHoChua { get; set; }
        public virtual DbSet<HeThongNhaMay> HeThongNhaMay { get; set; }
        public virtual DbSet<HeThongNhaMayDaMucTieu> HeThongNhaMayDaMucTieu { get; set; }
        public virtual DbSet<HeThongNhanHmi> HeThongNhanHmi { get; set; }
        public virtual DbSet<HeThongNhienLieu> HeThongNhienLieu { get; set; }
        public virtual DbSet<HeThongSanLuongChotThang> HeThongSanLuongChotThang { get; set; }
        public virtual DbSet<HeThongSoLieuNhanHmi> HeThongSoLieuNhanHmi { get; set; }
        public virtual DbSet<HeThongTaiChinh> HeThongTaiChinh { get; set; }
        public virtual DbSet<HeThongThoiGianKhoiDong> HeThongThoiGianKhoiDong { get; set; }
        public virtual DbSet<HeThongThongBao> HeThongThongBao { get; set; }
        public virtual DbSet<HeThongThongSoHoChua> HeThongThongSoHoChua { get; set; }
        public virtual DbSet<HeThongThongTinBanChao> HeThongThongTinBanChao { get; set; }
        public virtual DbSet<HeThongThongTinCoSoDuLieu> HeThongThongTinCoSoDuLieu { get; set; }
        public virtual DbSet<HeThongThongTinSuCo> HeThongThongTinSuCo { get; set; }
        public virtual DbSet<HeThongToMay> HeThongToMay { get; set; }
        public virtual DbSet<HeThongVungMien> HeThongVungMien { get; set; }
        public virtual DbSet<HmiCauHinh> HmiCauHinh { get; set; }
        public virtual DbSet<HmiLichSuDuLieu> HmiLichSuDuLieu { get; set; }
        public virtual DbSet<HmiLichSuSuKien> HmiLichSuSuKien { get; set; }
        public virtual DbSet<HmiLoaiThe> HmiLoaiThe { get; set; }
        public virtual DbSet<HmiLoaiThietBi> HmiLoaiThietBi { get; set; }
        public virtual DbSet<HmiManHinh> HmiManHinh { get; set; }
        public virtual DbSet<HmiManHinhChiTiet> HmiManHinhChiTiet { get; set; }
        public virtual DbSet<HmiNhatKy> HmiNhatKy { get; set; }
        public virtual DbSet<HmiNhatKyDongCat> HmiNhatKyDongCat { get; set; }
        public virtual DbSet<HmiNhomThe> HmiNhomThe { get; set; }
        public virtual DbSet<HmiScreenDetails> HmiScreenDetails { get; set; }
        public virtual DbSet<HmiScreens> HmiScreens { get; set; }
        public virtual DbSet<HmiSuKienCanhBao> HmiSuKienCanhBao { get; set; }
        public virtual DbSet<HmiThe> HmiThe { get; set; }
        public virtual DbSet<HmiThietBi> HmiThietBi { get; set; }
        public virtual DbSet<LienKetDiemDoLoaiDiemDo> LienKetDiemDoLoaiDiemDo { get; set; }
        public virtual DbSet<LienKetDiemDoLoaiDuPhong> LienKetDiemDoLoaiDuPhong { get; set; }
        public virtual DbSet<LienKetToMayBlockNgay> LienKetToMayBlockNgay { get; set; }
        public virtual DbSet<LienKetToMayDiemDo> LienKetToMayDiemDo { get; set; }
        public virtual DbSet<LienKetToMayNhienLieuNgay> LienKetToMayNhienLieuNgay { get; set; }
        public virtual DbSet<LoaiChiTieu> LoaiChiTieu { get; set; }
        public virtual DbSet<LoaiCongSuatDiemDo> LoaiCongSuatDiemDo { get; set; }
        public virtual DbSet<LoaiCongThuc> LoaiCongThuc { get; set; }
        public virtual DbSet<LoaiDiemDo> LoaiDiemDo { get; set; }
        public virtual DbSet<LoaiDonVi> LoaiDonVi { get; set; }
        public virtual DbSet<LoaiDuLieuNhap> LoaiDuLieuNhap { get; set; }
        public virtual DbSet<LoaiDuPhong> LoaiDuPhong { get; set; }
        public virtual DbSet<LoaiHeSoQuyDoi> LoaiHeSoQuyDoi { get; set; }
        public virtual DbSet<LoaiKenhDiemDo> LoaiKenhDiemDo { get; set; }
        public virtual DbSet<LoaiNguonBanChao> LoaiNguonBanChao { get; set; }
        public virtual DbSet<LoaiNguonSoLieuDoDem> LoaiNguonSoLieuDoDem { get; set; }
        public virtual DbSet<LoaiSanLuong> LoaiSanLuong { get; set; }
        public virtual DbSet<LoaiThoiGianNhapDuLieu> LoaiThoiGianNhapDuLieu { get; set; }
        public virtual DbSet<LuuLuongNuocVeTheoTanSuat> LuuLuongNuocVeTheoTanSuat { get; set; }
        public virtual DbSet<LuuLuongNuocVeThongKe> LuuLuongNuocVeThongKe { get; set; }
        public virtual DbSet<LuuTruTaiLieuThanhToan> LuuTruTaiLieuThanhToan { get; set; }
        public virtual DbSet<NhaMayCongThucSanLuongToMay> NhaMayCongThucSanLuongToMay { get; set; }
        public virtual DbSet<NhatKyDanhSachThietBi> NhatKyDanhSachThietBi { get; set; }
        public virtual DbSet<NhatKyGhiChuGiaoCa> NhatKyGhiChuGiaoCa { get; set; }
        public virtual DbSet<NhatKyGhiChuNhienLieu> NhatKyGhiChuNhienLieu { get; set; }
        public virtual DbSet<NhatKyMenhLenhCapTren> NhatKyMenhLenhCapTren { get; set; }
        public virtual DbSet<NhatKyNhanCa> NhatKyNhanCa { get; set; }
        public virtual DbSet<NhatKyThucHienCa> NhatKyThucHienCa { get; set; }
        public virtual DbSet<NhatKyTrangThaiThietBiKhiGiao> NhatKyTrangThaiThietBiKhiGiao { get; set; }
        public virtual DbSet<NhatKyTrangThaiToMayTheoCa> NhatKyTrangThaiToMayTheoCa { get; set; }
        public virtual DbSet<NkLenh> NkLenh { get; set; }
        public virtual DbSet<OrganizationUnitServicePoint> OrganizationUnitServicePoint { get; set; }
        public virtual DbSet<QlktbaoCaoSanLuongNgay> QlktbaoCaoSanLuongNgay { get; set; }
        public virtual DbSet<QlktbaoCaoThang> QlktbaoCaoThang { get; set; }
        public virtual DbSet<QlktcpvatLieu> QlktcpvatLieu { get; set; }
        public virtual DbSet<QlktgiaThanDau> QlktgiaThanDau { get; set; }
        public virtual DbSet<QlktkhoiLuongThanDau> QlktkhoiLuongThanDau { get; set; }
        public virtual DbSet<QlktsuatHao> QlktsuatHao { get; set; }
        public virtual DbSet<SanLuongKeHoachThuyVan> SanLuongKeHoachThuyVan { get; set; }
        public virtual DbSet<SanLuongThieuHut> SanLuongThieuHut { get; set; }
        public virtual DbSet<ScadaCongSuatToMay> ScadaCongSuatToMay { get; set; }
        public virtual DbSet<ScanFileLog> ScanFileLog { get; set; }
        public virtual DbSet<SkDanhMucSuKien> SkDanhMucSuKien { get; set; }
        public virtual DbSet<SkTmChayThiNghiem> SkTmChayThiNghiem { get; set; }
        public virtual DbSet<SkTmDuPhongDieuChinhTanSoSmo> SkTmDuPhongDieuChinhTanSoSmo { get; set; }
        public virtual DbSet<SkTmKhoiDongNgungMay> SkTmKhoiDongNgungMay { get; set; }
        public virtual DbSet<SkTmNoiLuoiNhanDienMuaNuocNgoai> SkTmNoiLuoiNhanDienMuaNuocNgoai { get; set; }
        public virtual DbSet<SkTmPhaiPhatKhiNgung> SkTmPhaiPhatKhiNgung { get; set; }
        public virtual DbSet<SkTmPhatCongSuatPhanKhang> SkTmPhatCongSuatPhanKhang { get; set; }
        public virtual DbSet<SkTmPhatSaiCongSuatCongBoNgayToiSmo> SkTmPhatSaiCongSuatCongBoNgayToiSmo { get; set; }
        public virtual DbSet<SkTmSuCoTren72Gio> SkTmSuCoTren72Gio { get; set; }
        public virtual DbSet<SkTmSuaChuaSaiKeHoach> SkTmSuaChuaSaiKeHoach { get; set; }
        public virtual DbSet<SkTmTachLuoiPhatDocLap> SkTmTachLuoiPhatDocLap { get; set; }
        public virtual DbSet<SkTmVanHanhKhiThieuNhienLieu> SkTmVanHanhKhiThieuNhienLieu { get; set; }
        public virtual DbSet<TongCongTyNhapChiTiet> TongCongTyNhapChiTiet { get; set; }
        public virtual DbSet<TongCongTyNhapTongQuat> TongCongTyNhapTongQuat { get; set; }
        public virtual DbSet<TrangThaiToMayChiTiet> TrangThaiToMayChiTiet { get; set; }
        public virtual DbSet<TrangThaiToMayTheoCa> TrangThaiToMayTheoCa { get; set; }
        public virtual DbSet<TrangThaiToMayTongQuat> TrangThaiToMayTongQuat { get; set; }
        public virtual DbSet<TtdbanChaoChuKyToiChiTiet> TtdbanChaoChuKyToiChiTiet { get; set; }
        public virtual DbSet<TtdbanChaoDuyet> TtdbanChaoDuyet { get; set; }
        public virtual DbSet<TtdbanChaoLapLichChiTiet> TtdbanChaoLapLichChiTiet { get; set; }
        public virtual DbSet<TtdbanChaoNgayToiChiTiet> TtdbanChaoNgayToiChiTiet { get; set; }
        public virtual DbSet<TtdbanChaoNgayToiChinhSua> TtdbanChaoNgayToiChinhSua { get; set; }
        public virtual DbSet<TtdbanChaoNguoiDungGhiChu> TtdbanChaoNguoiDungGhiChu { get; set; }
        public virtual DbSet<TtdbanChaoThongTinNguoiSuDung> TtdbanChaoThongTinNguoiSuDung { get; set; }
        public virtual DbSet<TtdbanChaoTongQuat> TtdbanChaoTongQuat { get; set; }
        public virtual DbSet<TtdcongSuatCongBoChuKyToiChiTiet> TtdcongSuatCongBoChuKyToiChiTiet { get; set; }
        public virtual DbSet<TtdcongSuatCongBoChuKyToiTongQuat> TtdcongSuatCongBoChuKyToiTongQuat { get; set; }
        public virtual DbSet<TtdcongSuatCongBoNgayToiChiTiet> TtdcongSuatCongBoNgayToiChiTiet { get; set; }
        public virtual DbSet<TtdcongSuatCongBoNgayToiTongQuat> TtdcongSuatCongBoNgayToiTongQuat { get; set; }
        public virtual DbSet<TtdcongSuatHuyDongChuKyToiChiTiet> TtdcongSuatHuyDongChuKyToiChiTiet { get; set; }
        public virtual DbSet<TtdcongSuatHuyDongChuKyToiTongQuat> TtdcongSuatHuyDongChuKyToiTongQuat { get; set; }
        public virtual DbSet<TtddinhDanhToMayNgay> TtddinhDanhToMayNgay { get; set; }
        public virtual DbSet<TtddinhDanhVungMienNgay> TtddinhDanhVungMienNgay { get; set; }
        public virtual DbSet<TtdgiaBienChuKyToi> TtdgiaBienChuKyToi { get; set; }
        public virtual DbSet<TtdgiaBienNgayToi> TtdgiaBienNgayToi { get; set; }
        public virtual DbSet<TtdgiaCan> TtdgiaCan { get; set; }
        public virtual DbSet<TtdgiaHopDong> TtdgiaHopDong { get; set; }
        public virtual DbSet<TtdgiaSmp> TtdgiaSmp { get; set; }
        public virtual DbSet<TtdgiaSmpTamTinh> TtdgiaSmpTamTinh { get; set; }
        public virtual DbSet<TtdgiaTongQuat> TtdgiaTongQuat { get; set; }
        public virtual DbSet<TtdgiaTranThiTruong> TtdgiaTranThiTruong { get; set; }
        public virtual DbSet<TtdgiaTriNuocNam> TtdgiaTriNuocNam { get; set; }
        public virtual DbSet<TtdkeHoachHuyDongToMayNgayToi> TtdkeHoachHuyDongToMayNgayToi { get; set; }
        public virtual DbSet<TtdkeHoachNguonTuan> TtdkeHoachNguonTuan { get; set; }
        public virtual DbSet<TtdkeHoachVanHanhGioToiChiTiet> TtdkeHoachVanHanhGioToiChiTiet { get; set; }
        public virtual DbSet<TtdkeHoachVanHanhGioToiTongQuat> TtdkeHoachVanHanhGioToiTongQuat { get; set; }
        public virtual DbSet<TtdkeHoachVanHanhNam> TtdkeHoachVanHanhNam { get; set; }
        public virtual DbSet<TtdkeHoachVanHanhTuan> TtdkeHoachVanHanhTuan { get; set; }
        public virtual DbSet<TtdnhaMayViPhamMucNuoc> TtdnhaMayViPhamMucNuoc { get; set; }
        public virtual DbSet<TtdnhatKyLenhChiTiet> TtdnhatKyLenhChiTiet { get; set; }
        public virtual DbSet<TtdnhatKyLenhDimThanhToan> TtdnhatKyLenhDimThanhToan { get; set; }
        public virtual DbSet<TtdphuTaiChuKyToi> TtdphuTaiChuKyToi { get; set; }
        public virtual DbSet<TtdphuTaiNgayToi> TtdphuTaiNgayToi { get; set; }
        public virtual DbSet<TtdphuTaiThangToi> TtdphuTaiThangToi { get; set; }
        public virtual DbSet<TtdphuTaiTuanToi> TtdphuTaiTuanToi { get; set; }
        public virtual DbSet<TtdsanLuongDoDemDiemDoThang> TtdsanLuongDoDemDiemDoThang { get; set; }
        public virtual DbSet<TtdsanLuongDoDemToMayThang> TtdsanLuongDoDemToMayThang { get; set; }
        public virtual DbSet<TtdsanLuongHopDongHieuChinh> TtdsanLuongHopDongHieuChinh { get; set; }
        public virtual DbSet<TtdsanLuongHopDongNam> TtdsanLuongHopDongNam { get; set; }
        public virtual DbSet<TtdsanLuongHopDongThang> TtdsanLuongHopDongThang { get; set; }
        public virtual DbSet<TtdsanLuongToMayNgay> TtdsanLuongToMayNgay { get; set; }
        public virtual DbSet<TtdsoLieuDoDemChiTiet> TtdsoLieuDoDemChiTiet { get; set; }
        public virtual DbSet<TtdsoLieuDoDemTongQuat> TtdsoLieuDoDemTongQuat { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayCongSuatThiTruong> TtdthanhToanBangKeNgayCongSuatThiTruong { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayGiaChao> TtdthanhToanBangKeNgayGiaChao { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayGiaThiTruong> TtdthanhToanBangKeNgayGiaThiTruong { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayNgoaiLenhDieuDo> TtdthanhToanBangKeNgayNgoaiLenhDieuDo { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayPhatTangThem> TtdthanhToanBangKeNgayPhatTangThem { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayTongHopNgay> TtdthanhToanBangKeNgayTongHopNgay { get; set; }
        public virtual DbSet<TtdthanhToanBangKeNgayTongQuat> TtdthanhToanBangKeNgayTongQuat { get; set; }
        public virtual DbSet<TtdthanhToanBangKeThangCongSuatThiTruong> TtdthanhToanBangKeThangCongSuatThiTruong { get; set; }
        public virtual DbSet<TtdthanhToanBangKeThangSanLuongNgoaiThiTruong> TtdthanhToanBangKeThangSanLuongNgoaiThiTruong { get; set; }
        public virtual DbSet<TtdthanhToanBangKeThangThiTruong> TtdthanhToanBangKeThangThiTruong { get; set; }
        public virtual DbSet<TtdthanhToanBangKeThangTongHopThang> TtdthanhToanBangKeThangTongHopThang { get; set; }
        public virtual DbSet<TtdthanhToanBangKeThangTongQuat> TtdthanhToanBangKeThangTongQuat { get; set; }
        public virtual DbSet<TtdthanhToanDoanhThuChiTietNgay> TtdthanhToanDoanhThuChiTietNgay { get; set; }
        public virtual DbSet<TtdthanhToanDoanhThuNhaMayNgay> TtdthanhToanDoanhThuNhaMayNgay { get; set; }
        public virtual DbSet<TtdthanhToanLenhDim> TtdthanhToanLenhDim { get; set; }
        public virtual DbSet<TtdthiTruongSauVanHanh> TtdthiTruongSauVanHanh { get; set; }
        public virtual DbSet<TtdthongSoThuyVanTuan> TtdthongSoThuyVanTuan { get; set; }
        public virtual DbSet<TtdthongTinDonViTongQuat> TtdthongTinDonViTongQuat { get; set; }
        public virtual DbSet<TtdthongTinHoChua> TtdthongTinHoChua { get; set; }
        public virtual DbSet<TtdthongTinPhuTaiTongQuat> TtdthongTinPhuTaiTongQuat { get; set; }
        public virtual DbSet<TtdthongTinThuyVanNam> TtdthongTinThuyVanNam { get; set; }
        public virtual DbSet<TtdthongTinThuyVanThang> TtdthongTinThuyVanThang { get; set; }
        public virtual DbSet<TtdthongTinTongQuat> TtdthongTinTongQuat { get; set; }
        public virtual DbSet<TtdtinhHinhThuThapSoLieu> TtdtinhHinhThuThapSoLieu { get; set; }
        public virtual DbSet<TtdtinhTrangThieuThan> TtdtinhTrangThieuThan { get; set; }
        public virtual DbSet<TtdtoMayBienChuKyToi> TtdtoMayBienChuKyToi { get; set; }
        public virtual DbSet<TtdtoMayTongQuat> TtdtoMayTongQuat { get; set; }
        public virtual DbSet<TtdtocDoTgtlapLichChiTiet> TtdtocDoTgtlapLichChiTiet { get; set; }
        public virtual DbSet<TtdtocDoTgtlapLichTongQuat> TtdtocDoTgtlapLichTongQuat { get; set; }
        public virtual DbSet<TtdtrangThaiGuiBanChaoChiTiet> TtdtrangThaiGuiBanChaoChiTiet { get; set; }
        public virtual DbSet<TtdtrangThaiGuiBanChaoTongQuat> TtdtrangThaiGuiBanChaoTongQuat { get; set; }
        public virtual DbSet<TtdtrangThaiToMayChiTiet> TtdtrangThaiToMayChiTiet { get; set; }
        public virtual DbSet<TtdtrangThaiToMayTongQuat> TtdtrangThaiToMayTongQuat { get; set; }
        public virtual DbSet<TtdtuanTongQuat> TtdtuanTongQuat { get; set; }
        public virtual DbSet<TtdxacNhanThongTinTvphucVuQc> TtdxacNhanThongTinTvphucVuQc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=192.168.68.223\\MSSQLETP2014;Database=ES_GiamSatVanHanh;user id=sonnt;password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbpAuditLogs>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.CustomData).HasMaxLength(2000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.MethodName).HasMaxLength(256);

                entity.Property(e => e.Parameters).HasMaxLength(1024);

                entity.Property(e => e.ServiceName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpBackgroundJobs>(entity =>
            {
                entity.Property(e => e.JobArgs).IsRequired();

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<AbpEditions>(entity =>
            {
                entity.Property(e => e.AnnualPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MonthlyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AbpEntityChangeSets>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.Reason).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpEntityChanges>(entity =>
            {
                entity.Property(e => e.EntityId).HasMaxLength(48);

                entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChangeSet)
                    .WithMany(p => p.AbpEntityChanges)
                    .HasForeignKey(d => d.EntityChangeSetId);
            });

            modelBuilder.Entity<AbpEntityPropertyChanges>(entity =>
            {
                entity.Property(e => e.NewValue).HasMaxLength(512);

                entity.Property(e => e.OriginalValue).HasMaxLength(512);

                entity.Property(e => e.PropertyName).HasMaxLength(96);

                entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

                entity.HasOne(d => d.EntityChange)
                    .WithMany(p => p.AbpEntityPropertyChanges)
                    .HasForeignKey(d => d.EntityChangeId);
            });

            modelBuilder.Entity<AbpFeatures>(entity =>
            {
                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpFeatures)
                    .HasForeignKey(d => d.EditionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpLanguageTexts>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AbpLanguages>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Icon).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<AbpNotificationSubscriptions>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName).HasMaxLength(96);
            });

            modelBuilder.Entity<AbpNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpOrganizationUnits>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(95);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<AbpPermissions>(entity =>
            {
                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AbpPersistedGrants>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AbpRoleClaims>(entity =>
            {
                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AbpRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AbpRoles>(entity =>
            {
                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NormalizedName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpRolesCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpRolesDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpRolesLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpSettings>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpSettings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpTenantNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataTypeName).HasMaxLength(512);

                entity.Property(e => e.EntityId).HasMaxLength(96);

                entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);

                entity.Property(e => e.EntityTypeName).HasMaxLength(250);

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<AbpTenants>(entity =>
            {
                entity.Property(e => e.ConnectionString).HasMaxLength(1024);

                entity.Property(e => e.LogoFileType).HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenancyName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.AbpTenantsCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.AbpTenantsDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AbpTenants)
                    .HasForeignKey(d => d.EditionId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.AbpTenantsLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AbpUserAccounts>(entity =>
            {
                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AbpUserClaims>(entity =>
            {
                entity.Property(e => e.ClaimType).HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserLoginAttempts>(entity =>
            {
                entity.Property(e => e.BrowserInfo).HasMaxLength(512);

                entity.Property(e => e.ClientIpAddress).HasMaxLength(64);

                entity.Property(e => e.ClientName).HasMaxLength(128);

                entity.Property(e => e.TenancyName).HasMaxLength(64);

                entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<AbpUserLogins>(entity =>
            {
                entity.Property(e => e.LoginProvider)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProviderKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AbpUserOrganizationUnits>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserOrganizationUnits)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserRoles>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUserTokens>(entity =>
            {
                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AbpUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AbpUsers>(entity =>
            {
                entity.Property(e => e.AuthenticationSource).HasMaxLength(64);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.NormalizedEmailAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(328);

                entity.Property(e => e.PhoneNumber).HasMaxLength(32);

                entity.Property(e => e.SecurityStamp).HasMaxLength(128);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatorUser)
                    .WithMany(p => p.InverseCreatorUser)
                    .HasForeignKey(d => d.CreatorUserId);

                entity.HasOne(d => d.DeleterUser)
                    .WithMany(p => p.InverseDeleterUser)
                    .HasForeignKey(d => d.DeleterUserId);

                entity.HasOne(d => d.LastModifierUser)
                    .WithMany(p => p.InverseLastModifierUser)
                    .HasForeignKey(d => d.LastModifierUserId);
            });

            modelBuilder.Entity<AppBinaryObjects>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bytes).IsRequired();
            });

            modelBuilder.Entity<AppChatMessages>(entity =>
            {
                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<AppFriendships>(entity =>
            {
                entity.Property(e => e.FriendUserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AppSubscriptionPayments>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExternalPaymentId).HasMaxLength(450);

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.AppSubscriptionPayments)
                    .HasForeignKey(d => d.EditionId);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CauHinh>(entity =>
            {
                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChiPhiCoDinhKhongTheThuHoi>(entity =>
            {
                entity.Property(e => e.ChiPhiBienDoiCoDinh).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChiPhiBienDoiThucTe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChiPhiCoDinhBiCatDoBiCatQc).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GiaBienDoiThucTe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LnthieuHutDoTmbiSuCo)
                    .HasColumnName("LNThieuHutDoTMBiSuCo")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LnthieuHutDoTmsuyGiamCs)
                    .HasColumnName("LNThieuHutDoTMSuyGiamCS")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoanhThuDuKien>(entity =>
            {
                entity.Property(e => e.DoanhThuHopDong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuPhatTangThem).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuThiTruong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GiaHopDong).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.GiaTtduKien)
                    .HasColumnName("GiaTTDuKien")
                    .HasColumnType("decimal(12, 3)");

                entity.Property(e => e.SanLuongDauCucKeHoach).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.SanLuongThuongPhamKeHoach).HasColumnType("decimal(12, 3)");
            });

            modelBuilder.Entity<EsmSoLieuDoDem>(entity =>
            {
                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<GcloaiSuKienToMay>(entity =>
            {
                entity.ToTable("GCLoaiSuKienToMay");

                entity.Property(e => e.MaSuKien)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenSuKien)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GctrangThaiVanHanhToMay>(entity =>
            {
                entity.ToTable("GCTrangThaiVanHanhToMay");

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiaTriNuocTuan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HctdsoLieuHoChua>(entity =>
            {
                entity.ToTable("HCTDSoLieuHoChua");

                entity.Property(e => e.GioDo).HasColumnType("datetime");

                entity.Property(e => e.LuuLuongChayMay).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongDenHo).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongXaQuaTran).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongXaQuaTranLonNhatDuKien).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocHaLuu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocThuongLuu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayDo).HasColumnType("datetime");

                entity.Property(e => e.TongLuuLuongXa).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<HeThongChiTieu>(entity =>
            {
                entity.Property(e => e.ChiTieuKhaDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DoanhThuKhac).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DonGiaCoDinh).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DthopDong)
                    .HasColumnName("DTHopDong")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DtthiTruong)
                    .HasColumnName("DTThiTruong")
                    .HasColumnType("decimal(20, 10)");

                entity.Property(e => e.GiaBanDienGiaoTangThem).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaCoDinh).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.GiaHopDong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaThiTruongDuKien).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.HeSoHuyDong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SldauCucKeHoach)
                    .HasColumnName("SLDauCucKeHoach")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.SlthuongPhamKehoach)
                    .HasColumnName("SLThuongPhamKehoach")
                    .HasColumnType("decimal(20, 10)");
            });

            modelBuilder.Entity<HeThongDiemDo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaDiemDo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaDiemDoEvn)
                    .IsRequired()
                    .HasColumnName("MaDiemDoEVN")
                    .HasMaxLength(50);

                entity.Property(e => e.MaDiemDoKdl)
                    .HasColumnName("MaDiemDoKDL")
                    .HasMaxLength(50);

                entity.Property(e => e.TenDiemDo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HeThongDiemDoDinhDanh>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongDonVi>(entity =>
            {
                entity.Property(e => e.CongSuatDat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TenDonVi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TenTatDonVi).HasMaxLength(100);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<HeThongHeSoQuyDoi>(entity =>
            {
                entity.HasKey(e => e.IdHeSoQuyDoi)
                    .HasName("PK_HeThongHeSoQuyDoi2");

                entity.Property(e => e.IdHeSoQuyDoi).ValueGeneratedNever();

                entity.Property(e => e.HeSoQuyDoi).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");

                entity.Property(e => e.NgaySua).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NguoiSua).HasMaxLength(150);

                entity.Property(e => e.NguoiTao).HasMaxLength(150);
            });

            modelBuilder.Entity<HeThongHoChua>(entity =>
            {
                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DungTichChet).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DungTichHuuIch).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.DungTichTong).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.LuuVucSong).HasMaxLength(100);

                entity.Property(e => e.Ma).HasMaxLength(100);

                entity.Property(e => e.MucNuocChet).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HeThongHoChuaDaMucTieu>(entity =>
            {
                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HeThongIdManHinhHmi>(entity =>
            {
                entity.ToTable("HeThongIdManHinhHMI");

                entity.Property(e => e.IdManHinhHmi).HasColumnName("IdManHinhHMI");

                entity.Property(e => e.MoTa).HasMaxLength(150);
            });

            modelBuilder.Entity<HeThongLoaiHinhNmd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HeThongLoaiHinhNMD");

                entity.Property(e => e.TenLoaiHinh).HasMaxLength(150);

                entity.Property(e => e.TenTat).HasMaxLength(150);
            });

            modelBuilder.Entity<HeThongMauSac>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(150);

                entity.Property(e => e.GiaTri).HasColumnType("ntext");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongMucNuocHoChua>(entity =>
            {
                entity.Property(e => e.DungTichHuuIch).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVe).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocBoCongThuong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocChet).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDangBinhThuong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDuKienVanHanh).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocGioiHanA0).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocHienTai).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocQuyTrinhLienHo).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocQuyTrinhLienHoDuoi).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocThucTeVanHanh).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongNhaMay>(entity =>
            {
                entity.HasIndex(e => e.IdNhaMay)
                    .HasName("UK_HeThongNhaMay_IdNhaMay")
                    .IsUnique();

                entity.Property(e => e.CongSuatThietKe).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HeSo).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.IsTddtduoi2Ngay).HasColumnName("IsTDDTDuoi2Ngay");

                entity.Property(e => e.MaNhaMay)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NgayVanHanh).HasColumnType("datetime");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TenDayDu).HasMaxLength(250);

                entity.Property(e => e.TenTatNm).HasColumnName("TenTatNM");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<HeThongNhaMayDaMucTieu>(entity =>
            {
                entity.Property(e => e.Ten).HasMaxLength(30);

                entity.Property(e => e.TenTatNm)
                    .HasColumnName("TenTatNM")
                    .HasMaxLength(30);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<HeThongNhanHmi>(entity =>
            {
                entity.ToTable("HeThongNhanHMI");

                entity.Property(e => e.LoaiDuLieu).HasMaxLength(150);

                entity.Property(e => e.LoaiNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<HeThongNhienLieu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaNhienLieu)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TenNhienLieu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TenTat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HeThongSanLuongChotThang>(entity =>
            {
                entity.Property(e => e.SanLuongDauCuc).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<HeThongSoLieuNhanHmi>(entity =>
            {
                entity.ToTable("HeThongSoLieuNhanHMI");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.IdNhanHmi).HasColumnName("IdNhanHMI");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongTaiChinh>(entity =>
            {
                entity.Property(e => e.ChiPhiBienDoiCoDinh).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChiPhiBienDoiThucTe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuKhac).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuTheoGiaHopDong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuTheoHopDong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuTheoThiTruongThucTe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DoanhThuTheoThiTruongTuDong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SanLuongDuTinh).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<HeThongThoiGianKhoiDong>(entity =>
            {
                entity.Property(e => e.ThoiGianHdbpmin)
                    .HasColumnName("ThoiGianHDBPMin")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ThoiGianKdhdb)
                    .HasColumnName("ThoiGianKDHDB")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<HeThongThongBao>(entity =>
            {
                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongThongSoHoChua>(entity =>
            {
                entity.Property(e => e.CotNuoc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CotNuocThuongLuu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DungTich).HasColumnType("decimal(10, 5)");

                entity.Property(e => e.MucNuoc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatTieuHaoNuoc).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<HeThongThongTinBanChao>(entity =>
            {
                entity.Property(e => e.ChiPhiBienDoiBinhQuan)
                    .HasColumnName("ChiPhiBIenDoiBinhQuan")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChiPhiVatLieuPhu).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChienLuocVanHanhNgayD1).HasMaxLength(500);

                entity.Property(e => e.CongSuatLonNhat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CongSuatNhoNhat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LuuLuongChayMayDuKien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LuuLuongNuocVeDuKien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MucNuocCuoiNgay).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SanLuongHopDongQuyDoiVeDauCuc).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SanLuongPhatDuCapNuocHaDu).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SanLuongPhatDuKien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SuatTieuHaoThan).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ThongTinKhac).HasMaxLength(500);

                entity.Property(e => e.ThongTinLuuYtrenHeThong).HasColumnName("ThongTinLuuYTrenHeThong");

                entity.Property(e => e.ThongTinPhuongThucTruyenTai).HasMaxLength(500);

                entity.Property(e => e.ThongTinVanHanhNgay).HasMaxLength(500);

                entity.Property(e => e.TyLeDienTuDung).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<HeThongThongTinCoSoDuLieu>(entity =>
            {
                entity.Property(e => e.Dbname)
                    .HasColumnName("DBName")
                    .HasMaxLength(500);

                entity.Property(e => e.IdnhaMay).HasColumnName("IDNhaMay");

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.Scada).HasMaxLength(500);

                entity.Property(e => e.SeverName).HasMaxLength(500);

                entity.Property(e => e.UserName).HasMaxLength(500);
            });

            modelBuilder.Entity<HeThongThongTinSuCo>(entity =>
            {
                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeThongToMay>(entity =>
            {
                entity.HasIndex(e => e.IdToMay)
                    .HasName("UK_HeThongToMay_IdToMay")
                    .IsUnique();

                entity.Property(e => e.CongSuatThietKeLonNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CongSuatThietKeNhoNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MaToMay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TagScada).HasMaxLength(50);

                entity.Property(e => e.TenToMay)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThoiGianKhoiDongToMay).HasColumnType("decimal(10, 3)");

                entity.HasOne(d => d.IdNhaMayNavigation)
                    .WithMany(p => p.HeThongToMay)
                    .HasPrincipalKey(p => p.IdNhaMay)
                    .HasForeignKey(d => d.IdNhaMay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeThongToMay_HeThongNhaMay");
            });

            modelBuilder.Entity<HeThongVungMien>(entity =>
            {
                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HmiCauHinh>(entity =>
            {
                entity.HasIndex(e => new { e.Khoa, e.TenantId, e.ThoiGian })
                    .HasName("IX_HmiCauHinh")
                    .IsUnique();

                entity.Property(e => e.Khoa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiLichSuDuLieu>(entity =>
            {
                entity.Property(e => e.GiaTri)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.TenOpc)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiLichSuSuKien>(entity =>
            {
                entity.Property(e => e.GiaTri).HasMaxLength(550);

                entity.Property(e => e.MoTa).HasColumnType("ntext");

                entity.Property(e => e.Operator).HasMaxLength(550);

                entity.Property(e => e.State).HasMaxLength(550);

                entity.Property(e => e.TenOpc)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiLoaiThe>(entity =>
            {
                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(550);
            });

            modelBuilder.Entity<HmiLoaiThietBi>(entity =>
            {
                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(550);
            });

            modelBuilder.Entity<HmiManHinh>(entity =>
            {
                entity.Property(e => e.TenManHinh).IsRequired();
            });

            modelBuilder.Entity<HmiManHinhChiTiet>(entity =>
            {
                entity.Property(e => e.DuLieu).IsRequired();

                entity.HasOne(d => d.IdHmiManHinhNavigation)
                    .WithMany(p => p.HmiManHinhChiTiet)
                    .HasForeignKey(d => d.IdHmiManHinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HmiManHinhChiTiet_HmiManHinh");
            });

            modelBuilder.Entity<HmiNhatKy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ChuongTrinh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasColumnType("ntext");

                entity.Property(e => e.TaiKhoan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiNhatKyDongCat>(entity =>
            {
                entity.Property(e => e.TaiKhoan).HasMaxLength(550);

                entity.Property(e => e.TenEsLink).HasMaxLength(550);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiNhomThe>(entity =>
            {
                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(550);
            });

            modelBuilder.Entity<HmiScreenDetails>(entity =>
            {
                entity.HasOne(d => d.HmiScreen)
                    .WithMany(p => p.HmiScreenDetails)
                    .HasForeignKey(d => d.HmiScreenId);
            });

            modelBuilder.Entity<HmiScreens>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.HmiScreens)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_HmiScreens_AbpTenants");
            });

            modelBuilder.Entity<HmiSuKienCanhBao>(entity =>
            {
                entity.Property(e => e.GiaTri)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.MoTa).HasMaxLength(1550);

                entity.Property(e => e.TenOpc)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<HmiThe>(entity =>
            {
                entity.Property(e => e.GiaTriLonNhat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GiaTriNhoNhat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TenEsLink).HasMaxLength(550);

                entity.Property(e => e.TenOpc)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.TiLe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrangThai).HasMaxLength(550);

                entity.HasOne(d => d.LoaiThe)
                    .WithMany(p => p.HmiThe)
                    .HasForeignKey(d => d.LoaiTheId)
                    .HasConstraintName("FK_HmiThe_HmiLoaiThe");

                entity.HasOne(d => d.ThietBi)
                    .WithMany(p => p.HmiThe)
                    .HasForeignKey(d => d.ThietBiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HmiThe_HmiThietBi");
            });

            modelBuilder.Entity<HmiThietBi>(entity =>
            {
                entity.Property(e => e.ControllerValue).HasMaxLength(550);

                entity.Property(e => e.DiaChi).HasMaxLength(550);

                entity.Property(e => e.DiaChiIp).HasMaxLength(150);

                entity.Property(e => e.FirstControllerTagName).HasMaxLength(550);

                entity.Property(e => e.FirstControllerValue).HasMaxLength(550);

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.SecondControllerTagName).HasMaxLength(550);

                entity.Property(e => e.SecondControllerValue).HasMaxLength(550);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.TenHienThi).HasMaxLength(550);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.ViTri).HasMaxLength(550);

                entity.HasOne(d => d.LoaiThietBi)
                    .WithMany(p => p.HmiThietBi)
                    .HasForeignKey(d => d.LoaiThietBiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HmiThietBi_HmiLoaiThietBi");
            });

            modelBuilder.Entity<LienKetDiemDoLoaiDiemDo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<LienKetDiemDoLoaiDuPhong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<LienKetToMayBlockNgay>(entity =>
            {
                entity.HasIndex(e => new { e.IdToMay, e.Ngay, e.Block })
                    .HasName("IX_LienKetToMayBlockNgay")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.HasOne(d => d.IdToMayNavigation)
                    .WithMany(p => p.LienKetToMayBlockNgay)
                    .HasPrincipalKey(p => p.IdToMay)
                    .HasForeignKey(d => d.IdToMay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LienKetToMayBlockNgay_HeThongToMay");
            });

            modelBuilder.Entity<LienKetToMayDiemDo>(entity =>
            {
                entity.Property(e => e.NgayApDung).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<LienKetToMayNhienLieuNgay>(entity =>
            {
                entity.HasIndex(e => new { e.IdToMay, e.IdNhienLieu, e.Ngay })
                    .HasName("IX_LienKetToMayNhienLieuNgay")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoaiChiTieu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ChiTieu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoaiCongSuatDiemDo>(entity =>
            {
                entity.Property(e => e.LoaiCongSuat)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiCongThuc>(entity =>
            {
                entity.Property(e => e.CongThuc).HasMaxLength(250);
            });

            modelBuilder.Entity<LoaiDiemDo>(entity =>
            {
                entity.HasKey(e => e.IdLoaiDiemDo);

                entity.Property(e => e.IdLoaiDiemDo).ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenLoaiDiemDo)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LoaiDonVi>(entity =>
            {
                entity.Property(e => e.LoaiDonVi1)
                    .HasColumnName("LoaiDonVi")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LoaiDuLieuNhap>(entity =>
            {
                entity.Property(e => e.LoaiDlnhap)
                    .IsRequired()
                    .HasColumnName("LoaiDLNhap")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LoaiDuPhong>(entity =>
            {
                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiHeSoQuyDoi>(entity =>
            {
                entity.Property(e => e.TenHeSoQuyDoi).HasMaxLength(150);

                entity.Property(e => e.TenHienThiCthuc)
                    .HasColumnName("TenHienThiCThuc")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiKenhDiemDo>(entity =>
            {
                entity.Property(e => e.KenhDiemDo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiNguonBanChao>(entity =>
            {
                entity.Property(e => e.NguonBanChao)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiNguonSoLieuDoDem>(entity =>
            {
                entity.Property(e => e.NguonDoDem)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiSanLuong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoaiSanLuong).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiThoiGianNhapDuLieu>(entity =>
            {
                entity.Property(e => e.ThoiGianNhapDuLieu).HasMaxLength(50);
            });

            modelBuilder.Entity<LuuLuongNuocVeTheoTanSuat>(entity =>
            {
                entity.Property(e => e.LuuLuong).HasColumnType("decimal(10, 1)");
            });

            modelBuilder.Entity<LuuLuongNuocVeThongKe>(entity =>
            {
                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<LuuTruTaiLieuThanhToan>(entity =>
            {
                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.TenFile).HasMaxLength(500);
            });

            modelBuilder.Entity<NhaMayCongThucSanLuongToMay>(entity =>
            {
                entity.Property(e => e.CongThuc).IsRequired();

                entity.Property(e => e.NgaySua).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NguoiSua).HasMaxLength(150);

                entity.Property(e => e.NguoiTao).HasMaxLength(150);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<NhatKyDanhSachThietBi>(entity =>
            {
                entity.Property(e => e.CoGiaTri).HasComment("Có đi kèm giá trị nhập");

                entity.Property(e => e.LoaiHinhThietBi).HasComment("1 thủy điện, 2 nhiệt điện");

                entity.Property(e => e.Stt).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.TenThietBi).HasMaxLength(400);
            });

            modelBuilder.Entity<NhatKyGhiChuGiaoCa>(entity =>
            {
                entity.Property(e => e.IdNhatKyNhanCa).HasColumnName("Id_NhatKyNhanCa");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(400);
            });

            modelBuilder.Entity<NhatKyGhiChuNhienLieu>(entity =>
            {
                entity.Property(e => e.DauDotLo).HasMaxLength(400);

                entity.Property(e => e.DauTon).HasMaxLength(400);

                entity.Property(e => e.GiaoCa).HasMaxLength(400);

                entity.Property(e => e.IdNhatKyNhanCa).HasColumnName("ID_NhatKyNhanCa");

                entity.Property(e => e.NhanCa).HasMaxLength(400);

                entity.Property(e => e.ThanTon).HasMaxLength(400);
            });

            modelBuilder.Entity<NhatKyMenhLenhCapTren>(entity =>
            {
                entity.Property(e => e.IdUserRaLenh).HasColumnName("Id_User_RaLenh");

                entity.Property(e => e.NoiDung).HasMaxLength(400);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<NhatKyNhanCa>(entity =>
            {
                entity.Property(e => e.CI)
                    .HasColumnName("C_I")
                    .HasMaxLength(100);

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.NgayThuchien)
                    .HasColumnName("Ngay_Thuchien")
                    .HasColumnType("datetime")
                    .HasComment("Ca của ngày");

                entity.Property(e => e.ThoiDiemGiaoCa)
                    .HasColumnName("ThoiDiem_GiaoCa")
                    .HasColumnType("datetime")
                    .HasComment("Thời điểm giao ca cho trưởng ca khác");

                entity.Property(e => e.ThoiDiemNhanCa)
                    .HasColumnName("ThoiDiem_NhanCa")
                    .HasColumnType("datetime")
                    .HasComment("Thời điểm nhận ca");

                entity.Property(e => e.TkDien)
                    .HasColumnName("TK_Dien")
                    .HasMaxLength(100);

                entity.Property(e => e.TkHoa)
                    .HasColumnName("TK_Hoa")
                    .HasMaxLength(100);

                entity.Property(e => e.TkLoMay)
                    .HasColumnName("TK_LoMay")
                    .HasMaxLength(100);

                entity.Property(e => e.TkNhienLieu)
                    .HasColumnName("TK_NhienLieu")
                    .HasMaxLength(100);

                entity.Property(e => e.UserA0)
                    .HasColumnName("User_A0")
                    .HasMaxLength(100);

                entity.Property(e => e.UserA1)
                    .HasColumnName("User_A1")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NhatKyThucHienCa>(entity =>
            {
                entity.Property(e => e.IdNhatKyNhanCa).HasColumnName("Id_NhatKyNhanCa");

                entity.Property(e => e.NoiDung).HasMaxLength(400);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasComment("0: tạo mới, 1: đã sửa");
            });

            modelBuilder.Entity<NhatKyTrangThaiThietBiKhiGiao>(entity =>
            {
                entity.Property(e => e.GiaTri).HasMaxLength(50);

                entity.Property(e => e.IdNhatKyNhanCa).HasColumnName("Id_NhatKyNhanCa");

                entity.Property(e => e.IdThietBi).HasColumnName("Id_ThietBi");

                entity.Property(e => e.TrangThai).HasComment("1: Vận hành, 2: dự phòng, 3: sữa chữa");
            });

            modelBuilder.Entity<NhatKyTrangThaiToMayTheoCa>(entity =>
            {
                entity.Property(e => e.MaTm)
                    .HasColumnName("MaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.TrangThai).HasComment("1: hoat dong, 2 ngung, 3 suco");
            });

            modelBuilder.Entity<NkLenh>(entity =>
            {
                entity.HasKey(e => e.Idlenh);

                entity.ToTable("NK_Lenh");

                entity.HasIndex(e => e.Idlenh)
                    .HasName("uniqueIDLenh")
                    .IsUnique();

                entity.Property(e => e.Idlenh)
                    .HasColumnName("IDLenh")
                    .HasMaxLength(100);

                entity.Property(e => e.GhichuHoanThanh)
                    .HasColumnName("Ghichu_HoanThanh")
                    .HasMaxLength(255);

                entity.Property(e => e.GhichuRalenh)
                    .HasColumnName("Ghichu_Ralenh")
                    .HasMaxLength(255);

                entity.Property(e => e.GiatriSoHoanThanh)
                    .HasColumnName("Giatri_So_HoanThanh")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GiatriSoRaLenh)
                    .HasColumnName("Giatri_So_RaLenh")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idkieulenh)
                    .HasColumnName("IDKieulenh")
                    .HasMaxLength(15);

                entity.Property(e => e.Idlydolenh)
                    .HasColumnName("IDLydolenh")
                    .HasMaxLength(15);

                entity.Property(e => e.Idmdl).HasColumnName("IDMDL");

                entity.Property(e => e.Idtb)
                    .IsRequired()
                    .HasColumnName("IDTB")
                    .HasMaxLength(14);

                entity.Property(e => e.IduserDunglenh)
                    .HasColumnName("IDUser_Dunglenh")
                    .HasMaxLength(50);

                entity.Property(e => e.IduserHoanthanh)
                    .HasColumnName("IDUser_Hoanthanh")
                    .HasMaxLength(25);

                entity.Property(e => e.IduserHuylenh)
                    .HasColumnName("IDUser_Huylenh")
                    .HasMaxLength(50);

                entity.Property(e => e.IduserNhanlenh)
                    .HasColumnName("IDUser_Nhanlenh")
                    .HasMaxLength(25);

                entity.Property(e => e.IduserRalenh)
                    .HasColumnName("IDUser_Ralenh")
                    .HasMaxLength(25);

                entity.Property(e => e.KieuCnrl).HasColumnName("KieuCNRL");

                entity.Property(e => e.LenhAgc)
                    .HasColumnName("LenhAGC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LyDoDungLenh).HasMaxLength(1000);

                entity.Property(e => e.MotaLyDoLenh).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemRldung)
                    .HasColumnName("ThoiDiem_RLDung")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemBdth)
                    .HasColumnName("Thoidiem_BDTH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemCanKt)
                    .HasColumnName("Thoidiem_CanKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemGuiLenh)
                    .HasColumnName("Thoidiem_GuiLenh")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemHoanthanh)
                    .HasColumnName("Thoidiem_Hoanthanh")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemNhanlenh)
                    .HasColumnName("Thoidiem_Nhanlenh")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrangThaiNhienLieu).HasMaxLength(10);

                entity.Property(e => e.Xpyclenh)
                    .HasColumnName("XPYCLenh")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrganizationUnitServicePoint>(entity =>
            {
                entity.HasOne(d => d.OrganizationUnitNavigation)
                    .WithMany(p => p.OrganizationUnitServicePoint)
                    .HasForeignKey(d => d.OrganizationUnit);
            });

            modelBuilder.Entity<QlktbaoCaoSanLuongNgay>(entity =>
            {
                entity.ToTable("QLKTBaoCaoSanLuongNgay");

                entity.Property(e => e.CongSuatLonNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CongSuatNhoNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.HeSoKhaDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.HeSoSuDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SanLuongNam).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongNamKeHoach).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongNgay).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThang).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThangKeHoach).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThangPhuongThuc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongTuanPhuongThuc).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<QlktbaoCaoThang>(entity =>
            {
                entity.ToTable("QLKTBaoCaoThang");

                entity.Property(e => e.CongSuatPhatBinhQuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.NhienLieuDauFotrungBinh)
                    .HasColumnName("NhienLieuDauFOTrungBinh")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NhienLieuThanTieuThu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PhanTramTuDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongDauCuc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThuongPham).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongTuDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SoGioVanHanh).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoDauFo)
                    .HasColumnName("SuatHaoDauFO")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoThan).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<QlktcpvatLieu>(entity =>
            {
                entity.ToTable("QLKTCPVatLieu");

                entity.Property(e => e.ChiPhiVatLieu).HasColumnType("decimal(20, 11)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<QlktgiaThanDau>(entity =>
            {
                entity.ToTable("QLKTGiaThanDau");

                entity.Property(e => e.GiaDau).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.GiaThan).HasColumnType("decimal(20, 10)");

                entity.Property(e => e.GiaThanNhiet)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<QlktkhoiLuongThanDau>(entity =>
            {
                entity.ToTable("QLKTKhoiLuongThanDau");

                entity.Property(e => e.KhoiLuongDau).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KhoiLuongThan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");
            });

            modelBuilder.Entity<QlktsuatHao>(entity =>
            {
                entity.ToTable("QLKTSuatHao");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SuatHaoDau).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoNhiet).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoThan).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<SanLuongKeHoachThuyVan>(entity =>
            {
                entity.Property(e => e.LuuLuongChayMay).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVeKh)
                    .HasColumnName("LuuLuongNuocVeKH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVeTh)
                    .HasColumnName("LuuLuongNuocVeTH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDauThangQtlh)
                    .HasColumnName("MucNuocDauThangQTLH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocKh)
                    .HasColumnName("MucNuocKH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocTh)
                    .HasColumnName("MucNuocTH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.SanLuongDauCuc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongHopDong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThucHien).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoNuocKh)
                    .HasColumnName("SuatHaoNuocKH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SuatHaoNuocTh)
                    .HasColumnName("SuatHaoNuocTH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TanSuatKh)
                    .HasColumnName("TanSuatKH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TanSuatTh)
                    .HasColumnName("TanSuatTH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.YeuCauCapNuocHaDu).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<SanLuongThieuHut>(entity =>
            {
                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SlhopDongQcBiCat)
                    .HasColumnName("SLHopDongQcBiCat")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SlthieuHutDoSuCoTm)
                    .HasColumnName("SLThieuHutDoSuCoTM")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SlthieuHutDoSuyGiamCs)
                    .HasColumnName("SLThieuHutDoSuyGiamCS")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SlthieuHutKhachQuan)
                    .HasColumnName("SLThieuHutKhachQuan")
                    .HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<ScadaCongSuatToMay>(entity =>
            {
                entity.Property(e => e.CongSuat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Idtb)
                    .HasColumnName("IDTB")
                    .HasMaxLength(500);

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<ScanFileLog>(entity =>
            {
                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeModifided).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkDanhMucSuKien>(entity =>
            {
                entity.HasKey(e => e.IdSuKien);

                entity.ToTable("SK_DanhMucSuKien");

                entity.Property(e => e.IdSuKien).ValueGeneratedNever();

                entity.Property(e => e.BangLuuTru).HasMaxLength(100);

                entity.Property(e => e.MaSuKien).HasMaxLength(100);

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenSuKien)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SkTmChayThiNghiem>(entity =>
            {
                entity.ToTable("SK_TM_ChayThiNghiem");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmDuPhongDieuChinhTanSoSmo>(entity =>
            {
                entity.ToTable("SK_TM_DuPhongDieuChinhTanSo_SMO");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmKhoiDongNgungMay>(entity =>
            {
                entity.ToTable("SK_TM_KhoiDongNgungMay");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmNoiLuoiNhanDienMuaNuocNgoai>(entity =>
            {
                entity.ToTable("SK_TM_NoiLuoiNhanDienMuaNuocNgoai");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("date");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("date");
            });

            modelBuilder.Entity<SkTmPhaiPhatKhiNgung>(entity =>
            {
                entity.ToTable("SK_TM_PhaiPhatKhiNgung");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmPhatCongSuatPhanKhang>(entity =>
            {
                entity.ToTable("SK_TM_PhatCongSuatPhanKhang");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmPhatSaiCongSuatCongBoNgayToiSmo>(entity =>
            {
                entity.ToTable("SK_TM_PhatSaiCongSuatCongBoNgayToi_SMO");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmSuCoTren72Gio>(entity =>
            {
                entity.ToTable("SK_TM_SuCoTren72Gio");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmSuaChuaSaiKeHoach>(entity =>
            {
                entity.ToTable("SK_TM_SuaChuaSaiKeHoach");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDauKeHoach)
                    .HasColumnName("ThoiDiemBatDau_KeHoach")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemBatDauThucTe)
                    .HasColumnName("ThoiDiemBatDau_ThucTe")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThucKeHoach)
                    .HasColumnName("ThoiDiemKetThuc_KeHoach")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThucThucTe)
                    .HasColumnName("ThoiDiemKetThuc_ThucTe")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmTachLuoiPhatDocLap>(entity =>
            {
                entity.ToTable("SK_TM_TachLuoiPhatDocLap");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkTmVanHanhKhiThieuNhienLieu>(entity =>
            {
                entity.ToTable("SK_TM_VanHanhKhiThieuNhienLieu");

                entity.Property(e => e.DuongDanFile).HasMaxLength(200);

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TongCongTyNhapChiTiet>(entity =>
            {
                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TongCongTyNhapTongQuat>(entity =>
            {
                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrangThaiToMayChiTiet>(entity =>
            {
                entity.Property(e => e.GiaTri)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrangThaiToMayTheoCa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdNhanCa).HasColumnName("Id_NhanCa");

                entity.Property(e => e.MaTm)
                    .HasColumnName("MaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.TrangThai).HasComment("1: Hđ bình thường, 2: ngừng, 3: sự cố");
            });

            modelBuilder.Entity<TrangThaiToMayTongQuat>(entity =>
            {
                entity.Property(e => e.HeSoKhaDung).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdbanChaoChuKyToiChiTiet>(entity =>
            {
                entity.ToTable("TTDBanChaoChuKyToiChiTiet");

                entity.HasIndex(e => new { e.IdBanChaoTongQuat, e.ChuKy })
                    .HasName("IX_TTDBanChaoChuKyToiChiTiet")
                    .IsUnique();

                entity.Property(e => e.CongSuat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaChao).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdbanChaoDuyet>(entity =>
            {
                entity.ToTable("TTDBanChaoDuyet");

                entity.Property(e => e.Duyet).HasComment("1 là đã duyệt");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdbanChaoLapLichChiTiet>(entity =>
            {
                entity.ToTable("TTDBanChaoLapLichChiTiet");

                entity.Property(e => e.CongSuat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaChao).HasColumnType("decimal(10, 3)");

                entity.HasOne(d => d.IdBanChaoTongQuatNavigation)
                    .WithMany(p => p.TtdbanChaoLapLichChiTiet)
                    .HasForeignKey(d => d.IdBanChaoTongQuat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTDBanChaoLapLichChiTiet_TTDBanChaoTongQuat");
            });

            modelBuilder.Entity<TtdbanChaoNgayToiChiTiet>(entity =>
            {
                entity.ToTable("TTDBanChaoNgayToiChiTiet");

                entity.HasIndex(e => new { e.IdBanChaoTongQuat, e.ChuKy })
                    .HasName("IX_TTDBanChaoNgayToiChiTiet")
                    .IsUnique();

                entity.Property(e => e.CongSuat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaChao).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdbanChaoNgayToiChinhSua>(entity =>
            {
                entity.ToTable("TTDBanChaoNgayToiChinhSua");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdbanChaoNguoiDungGhiChu>(entity =>
            {
                entity.ToTable("TTDBanChaoNguoiDungGhiChu");

                entity.Property(e => e.NgayBanChao).HasColumnType("datetime");

                entity.Property(e => e.NgayGhiChu).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdbanChaoThongTinNguoiSuDung>(entity =>
            {
                entity.ToTable("TTDBanChaoThongTinNguoiSuDung");

                entity.Property(e => e.NgayBanChao).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdbanChaoTongQuat>(entity =>
            {
                entity.ToTable("TTDBanChaoTongQuat");

                entity.HasIndex(e => new { e.IdToMayBlockNgay, e.IdNguonBanChao, e.SoChuKy })
                    .HasName("IX_TTDBanChaoTongQuat")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.HasOne(d => d.IdToMayBlockNgayNavigation)
                    .WithMany(p => p.TtdbanChaoTongQuat)
                    .HasForeignKey(d => d.IdToMayBlockNgay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTDBanChaoTongQuat_LienKetToMayBlockNgay");
            });

            modelBuilder.Entity<TtdcongSuatCongBoChuKyToiChiTiet>(entity =>
            {
                entity.ToTable("TTDCongSuatCongBoChuKyToiChiTiet");

                entity.HasIndex(e => new { e.ChuKy, e.IdCongSuatCongBoTongQuat })
                    .HasName("UC_CSCBCT")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Pmax).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Pmin).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<TtdcongSuatCongBoChuKyToiTongQuat>(entity =>
            {
                entity.ToTable("TTDCongSuatCongBoChuKyToiTongQuat");

                entity.HasIndex(e => e.IdToMayNhienLieuNgay)
                    .HasName("UC_CSCBTQ")
                    .IsUnique();

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdcongSuatCongBoNgayToiChiTiet>(entity =>
            {
                entity.ToTable("TTDCongSuatCongBoNgayToiChiTiet");

                entity.HasIndex(e => new { e.IdCongSuatCongBoTongQuat, e.ChuKy })
                    .HasName("IX_TTDCongSuatCongBoNgayToiChiTiet")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Pmax).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Pmin).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<TtdcongSuatCongBoNgayToiTongQuat>(entity =>
            {
                entity.ToTable("TTDCongSuatCongBoNgayToiTongQuat");

                entity.HasIndex(e => new { e.IdToMayNhienLieuNgay, e.SoLuongChuKy, e.IdNguonBanChao })
                    .HasName("IX_TTDCongSuatCongBoNgayToiTongQuat")
                    .IsUnique();

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdcongSuatHuyDongChuKyToiChiTiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTDCongSuatHuyDongChuKyToiChiTiet");

                entity.HasIndex(e => new { e.ChuKy, e.IdCongSuatHuyDongChuKyToiTongQuat })
                    .HasName("UC_CSHDCKTCT")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdcongSuatHuyDongChuKyToiTongQuat>(entity =>
            {
                entity.ToTable("TTDCongSuatHuyDongChuKyToiTongQuat");

                entity.HasIndex(e => e.IdToMayTongQuat)
                    .HasName("UC_CSHDCKTTQ")
                    .IsUnique();

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtddinhDanhToMayNgay>(entity =>
            {
                entity.ToTable("TTDDinhDanhToMayNgay");

                entity.HasIndex(e => new { e.Ngay, e.IdToMay })
                    .HasName("unique_ngay_tomay")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtddinhDanhVungMienNgay>(entity =>
            {
                entity.ToTable("TTDDinhDanhVungMienNgay");

                entity.HasIndex(e => new { e.Ngay, e.IdVungMien })
                    .HasName("unique_ngay_vungmien")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdgiaBienChuKyToi>(entity =>
            {
                entity.ToTable("TTDGiaBienChuKyToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhVungMienNgay })
                    .HasName("uniqueGiaBienNgayT_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdgiaBienNgayToi>(entity =>
            {
                entity.ToTable("TTDGiaBienNgayToi");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdgiaCan>(entity =>
            {
                entity.ToTable("TTDGiaCan");

                entity.HasIndex(e => new { e.ChuKy, e.IdThongTinTongQuat })
                    .HasName("uniqueGiaCan_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdgiaHopDong>(entity =>
            {
                entity.ToTable("TTDGiaHopDong");

                entity.Property(e => e.GiaHopDong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdgiaSmp>(entity =>
            {
                entity.ToTable("TTDGiaSmp");

                entity.HasIndex(e => new { e.ChuKy, e.IdThongTinTongQuat })
                    .HasName("uniqueGiaSmp_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdgiaSmpTamTinh>(entity =>
            {
                entity.ToTable("TTDGiaSmpTamTinh");

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdgiaTongQuat>(entity =>
            {
                entity.ToTable("TTDGiaTongQuat");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdgiaTranThiTruong>(entity =>
            {
                entity.ToTable("TTDGiaTranThiTruong");

                entity.Property(e => e.GiaTran).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayApDung).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdgiaTriNuocNam>(entity =>
            {
                entity.ToTable("TTDGiaTriNuocNam");

                entity.Property(e => e.GiaTriNuoc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdkeHoachHuyDongToMayNgayToi>(entity =>
            {
                entity.ToTable("TTDKeHoachHuyDongToMayNgayToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhToMayNgay })
                    .HasName("unique_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdkeHoachNguonTuan>(entity =>
            {
                entity.ToTable("TTDKeHoachNguonTuan");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.SanLuongChuNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu2).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu3).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu4).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu5).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu6).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThu7).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongTrungBinh).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdkeHoachVanHanhGioToiChiTiet>(entity =>
            {
                entity.ToTable("TTDKeHoachVanHanhGioToiChiTiet");

                entity.HasIndex(e => new { e.ChuKy, e.IdKeHoachVanHanhGioToiTongQuat })
                    .HasName("uniqueKHVHGTCT_chuky_tongquat")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdkeHoachVanHanhGioToiTongQuat>(entity =>
            {
                entity.ToTable("TTDKeHoachVanHanhGioToiTongQuat");

                entity.HasIndex(e => new { e.IdToMay, e.Ngay })
                    .HasName("uniqueKHVH_tomay_ngay")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdkeHoachVanHanhNam>(entity =>
            {
                entity.ToTable("TTDKeHoachVanHanhNam");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdkeHoachVanHanhTuan>(entity =>
            {
                entity.ToTable("TTDKeHoachVanHanhTuan");

                entity.Property(e => e.GiaTriChuNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu2).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu3).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu4).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu5).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu6).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriThu7).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriTrungBinh).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdnhaMayViPhamMucNuoc>(entity =>
            {
                entity.ToTable("TTDNhaMayViPhamMucNuoc");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.MucNuoc0hChuNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocGioiHan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdnhatKyLenhChiTiet>(entity =>
            {
                entity.ToTable("TTDNhatKyLenhChiTiet");

                entity.Property(e => e.GhichuHoanthanh).HasColumnName("GHICHU_HOANTHANH");

                entity.Property(e => e.GiatriSoHoanthanh)
                    .HasColumnName("GIATRI_SO_HOANTHANH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Hoanthanhlenh).HasColumnName("HOANTHANHLENH");

                entity.Property(e => e.Idkieulenh)
                    .HasColumnName("IDKIEULENH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idlenhcon)
                    .HasColumnName("IDLENHCON")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idlenhcum)
                    .HasColumnName("IDLENHCUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IduserHoanthanh)
                    .HasColumnName("IDUSER_HOANTHANH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lydocapnhat).HasColumnName("LYDOCAPNHAT");

                entity.Property(e => e.MaDv)
                    .HasColumnName("MA_DV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThoidiemBdth)
                    .HasColumnName("THOIDIEM_BDTH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemHoanthanh)
                    .HasColumnName("THOIDIEM_HOANTHANH")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdnhatKyLenhDimThanhToan>(entity =>
            {
                entity.ToTable("TTDNhatKyLenhDimThanhToan");

                entity.Property(e => e.Chukyhieuluc).HasColumnName("CHUKYHIEULUC");

                entity.Property(e => e.Dunglenh).HasColumnName("DUNGLENH");

                entity.Property(e => e.GhichuHoanthanh).HasColumnName("GHICHU_HOANTHANH");

                entity.Property(e => e.GhichuRalenh).HasColumnName("GHICHU_RALENH");

                entity.Property(e => e.GiatriSoHoanthanh)
                    .HasColumnName("GIATRI_SO_HOANTHANH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiatriSoRalenh)
                    .HasColumnName("GIATRI_SO_RALENH")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Hoanthanhlenh).HasColumnName("HOANTHANHLENH");

                entity.Property(e => e.IdLenh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMucdolenh).HasColumnName("ID_MUCDOLENH");

                entity.Property(e => e.IdTm).HasColumnName("ID_TM");

                entity.Property(e => e.Idkieulenh)
                    .HasColumnName("IDKIEULENH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idlydolenh)
                    .HasColumnName("IDLYDOLENH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idtb)
                    .HasColumnName("IDTB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IduserHoanthanh)
                    .HasColumnName("IDUSER_HOANTHANH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IduserNhanlenh)
                    .HasColumnName("IDUSER_NHANLENH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IduserRalenh)
                    .HasColumnName("IDUSER_RALENH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KieuRalenh).HasColumnName("KIEU_RALENH");

                entity.Property(e => e.Lenhagc).HasColumnName("LENHAGC");

                entity.Property(e => e.Lenhauto)
                    .HasColumnName("LENHAUTO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Lydocapnhat).HasColumnName("LYDOCAPNHAT");

                entity.Property(e => e.Lydodunglenh).HasColumnName("LYDODUNGLENH");

                entity.Property(e => e.MaDv)
                    .HasColumnName("MA_DV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Motalydolenh).HasColumnName("MOTALYDOLENH");

                entity.Property(e => e.Ngayhieuluc)
                    .HasColumnName("NGAYHIEULUC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysua)
                    .HasColumnName("NGAYSUA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaytao)
                    .HasColumnName("NGAYTAO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoisua)
                    .HasColumnName("NGUOISUA")
                    .HasMaxLength(50);

                entity.Property(e => e.Nguoitao)
                    .HasColumnName("NGUOITAO")
                    .HasMaxLength(50);

                entity.Property(e => e.Nguonlenh).HasColumnName("NGUONLENH");

                entity.Property(e => e.Nhaptay)
                    .HasColumnName("NHAPTAY")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThoidiemBdth)
                    .HasColumnName("THOIDIEM_BDTH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemBdthAgc)
                    .HasColumnName("THOIDIEM_BDTH_AGC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemCankt)
                    .HasColumnName("THOIDIEM_CANKT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemDunglenh)
                    .HasColumnName("THOIDIEM_DUNGLENH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemGuiagc)
                    .HasColumnName("THOIDIEM_GUIAGC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemGuilenh)
                    .HasColumnName("THOIDIEM_GUILENH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemHoanthanh)
                    .HasColumnName("THOIDIEM_HOANTHANH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemHtAgc)
                    .HasColumnName("THOIDIEM_HT_AGC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemNhanlenh)
                    .HasColumnName("THOIDIEM_NHANLENH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ThoidiemTaolenh)
                    .HasColumnName("THOIDIEM_TAOLENH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.Property(e => e.Trangthainhienlieu)
                    .HasColumnName("TRANGTHAINHIENLIEU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("UPDATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.XuatphatLenh).HasColumnName("XUATPHAT_LENH");
            });

            modelBuilder.Entity<TtdphuTaiChuKyToi>(entity =>
            {
                entity.ToTable("TTDPhuTaiChuKyToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhVungMienNgay })
                    .HasName("uniquePhuTaiCKT_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<TtdphuTaiNgayToi>(entity =>
            {
                entity.ToTable("TTDPhuTaiNgayToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhVungMienNgay })
                    .HasName("uniquePhuTaiNgayT_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<TtdphuTaiThangToi>(entity =>
            {
                entity.ToTable("TTDPhuTaiThangToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhVungMienNgay })
                    .HasName("uniquePhuTaiThangT_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<TtdphuTaiTuanToi>(entity =>
            {
                entity.ToTable("TTDPhuTaiTuanToi");

                entity.HasIndex(e => new { e.ChuKy, e.IdDinhDanhVungMienNgay })
                    .HasName("uniquePhuTaiTuanT_chuky_dinhdanh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<TtdsanLuongDoDemDiemDoThang>(entity =>
            {
                entity.ToTable("TTDSanLuongDoDemDiemDoThang");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdsanLuongDoDemToMayThang>(entity =>
            {
                entity.ToTable("TTDSanLuongDoDemToMayThang");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdsanLuongHopDongHieuChinh>(entity =>
            {
                entity.ToTable("TTDSanLuongHopDongHieuChinh");

                entity.HasIndex(e => new { e.IdThongTinTongQuat, e.ChuKy })
                    .HasName("uniqueSLHDHieuChinh")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdsanLuongHopDongNam>(entity =>
            {
                entity.ToTable("TTDSanLuongHopDongNam");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdsanLuongHopDongThang>(entity =>
            {
                entity.ToTable("TTDSanLuongHopDongThang");

                entity.HasIndex(e => new { e.IdThongTinTongQuat, e.ChuKy })
                    .HasName("uniqueSLHD")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdsanLuongToMayNgay>(entity =>
            {
                entity.ToTable("TTDSanLuongToMayNgay");

                entity.HasIndex(e => new { e.IdToMay, e.ChuKy, e.IdLoaiSanLuong, e.ThoiGian })
                    .HasName("uniqueSLTMNgay")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdsoLieuDoDemChiTiet>(entity =>
            {
                entity.ToTable("TTDSoLieuDoDemChiTiet");

                entity.HasIndex(e => new { e.IdTtdsoLieuDoDemTongQuat, e.ChuKy, e.IdLoaiNguonSoLieuDoDem })
                    .HasName("uniqueSLDDChiTiet")
                    .IsUnique();

                entity.Property(e => e.GiaTri).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.IdTtdsoLieuDoDemTongQuat).HasColumnName("IdTTDSoLieuDoDemTongQuat");
            });

            modelBuilder.Entity<TtdsoLieuDoDemTongQuat>(entity =>
            {
                entity.ToTable("TTDSoLieuDoDemTongQuat");

                entity.HasIndex(e => e.ThoiGian)
                    .HasName("ThoiGian");

                entity.HasIndex(e => new { e.IdNhaMay, e.IdDiemDo, e.IdLoaiKenhDiemDo, e.ThoiGian })
                    .HasName("uniqueSLDDTongQuat")
                    .IsUnique();

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayCongSuatThiTruong>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayCongSuatThiTruong");

                entity.Property(e => e.CongSuatThanhToan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.IdTtdthanhToanBangKeNgayTongQuat).HasColumnName("IdTTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayGiaChao>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayGiaChao");

                entity.Property(e => e.CongSuat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaChao).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.IdTtdthanhToanBangKeNgayTongQuat).HasColumnName("IdTTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayGiaThiTruong>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayGiaThiTruong");

                entity.Property(e => e.GiaDienNangThiTruong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.IdTtdthanhToanBangKeNgayTongQuat).HasColumnName("IdTTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.SanLuong).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayNgoaiLenhDieuDo>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayNgoaiLenhDieuDo");

                entity.Property(e => e.Gia).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.IdTtdthanhToanBangKeNgayTongQuat).HasColumnName("IdTTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.SanLuong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayPhatTangThem>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayPhatTangThem");

                entity.Property(e => e.GiaThanhToan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.IdTtdthanhToanBangKeNgayTongQuat).HasColumnName("IdTTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.SanLuong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayTongHopNgay>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayTongHopNgay");

                entity.Property(e => e.ThanhToanCongSuatThiTruong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanKhac).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongDieuChinhTanSo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongPhatTangThem).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongSaiKhac).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanTheoGiaChao).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanTheoGiaDienNang).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeNgayTongQuat>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeNgayTongQuat");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthanhToanBangKeThangCongSuatThiTruong>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeThangCongSuatThiTruong");

                entity.Property(e => e.IdTtdthanhToanBangKeThangTongQuat).HasColumnName("IdTTDThanhToanBangKeThangTongQuat");

                entity.Property(e => e.ThanhToanCongSuatThiTruong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthanhToanBangKeThangSanLuongNgoaiThiTruong>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeThangSanLuongNgoaiThiTruong");

                entity.Property(e => e.IdTtdthanhToanBangKeThangTongQuat).HasColumnName("IdTTDThanhToanBangKeThangTongQuat");

                entity.Property(e => e.SanLuong).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthanhToanBangKeThangThiTruong>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeThangThiTruong");

                entity.Property(e => e.IdTtdthanhToanBangKeThangTongQuat).HasColumnName("IdTTDThanhToanBangKeThangTongQuat");

                entity.Property(e => e.ThanhToanDienNangPhatTangThem).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanGiaChao).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanGiaSmp).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongPhatTangThem).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.Tong).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeThangTongHopThang>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeThangTongHopThang");

                entity.Property(e => e.IdTtdthanhToanBangKeThangTongQuat).HasColumnName("IdTTDThanhToanBangKeThangTongQuat");

                entity.Property(e => e.ThanhToanCongSuatThiTruong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanGiaChao).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanGiaDienNangThiTruong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanKhac).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongDieuChinhTanSo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongPhatTangThem).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThanhToanSanLuongSaiKhac).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TtdthanhToanBangKeThangTongQuat>(entity =>
            {
                entity.ToTable("TTDThanhToanBangKeThangTongQuat");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthanhToanDoanhThuChiTietNgay>(entity =>
            {
                entity.ToTable("TTDThanhToanDoanhThuChiTietNgay");

                entity.Property(e => e.DoanhThuTtd)
                    .HasColumnName("DoanhThuTTD")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Qbp).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qcan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qcon).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdd).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.QddV)
                    .HasColumnName("Qdd_V")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdt).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qlltt).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qmq).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qsmp).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Rbp).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rc).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rcan).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rcon).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rdt).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rdu).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rsmp).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Tong).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<TtdthanhToanDoanhThuNhaMayNgay>(entity =>
            {
                entity.ToTable("TTDThanhToanDoanhThuNhaMayNgay");

                entity.Property(e => e.DoanhThuTtd)
                    .HasColumnName("DoanhThuTTD")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Qbp).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.QcKh)
                    .HasColumnName("Qc_kh")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Qcan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qcon).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdd).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.QddV)
                    .HasColumnName("Qdd_V")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdt).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qdu).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qmq).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qsmp).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Rbp).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rc).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.RcKh)
                    .HasColumnName("Rc_kh")
                    .HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rcan).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rcon).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rdt).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rdu).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Rsmp).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.Tong).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<TtdthanhToanLenhDim>(entity =>
            {
                entity.ToTable("TTDThanhToanLenhDim");

                entity.Property(e => e.CongSuatRaLenh).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CongSuatThucHien).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GhiChu).HasMaxLength(150);

                entity.Property(e => e.IdLenh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KieuLenh)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NguoiRaLenh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NguoiThucHien)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemGuiLenh).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemHoanThanh).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemNhanLenh).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthiTruongSauVanHanh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTDThiTruongSauVanHanh");

                entity.Property(e => e.GiaChaoLapLichLonNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaChaoLapLichNhoNhat).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SanLuongLapLichTinhToan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SanLuongThuongPham).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdthongSoThuyVanTuan>(entity =>
            {
                entity.ToTable("TTDThongSoThuyVanTuan");

                entity.Property(e => e.ChenhLech).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GiaTriNuoc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuongNuocXa).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVeTrungBinhTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocCuoiTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDauTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocGioiHan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthongTinDonViTongQuat>(entity =>
            {
                entity.ToTable("TTDThongTinDonViTongQuat");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthongTinHoChua>(entity =>
            {
                entity.ToTable("TTDThongTinHoChua");

                entity.Property(e => e.LuuLuongChayMay).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LuuLuongDenHo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LuuLuongXaQuaTran).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MucNuocHaLuu).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MucNuocThuongLuu).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NgayGioDo).HasColumnType("datetime");

                entity.Property(e => e.TenHo).HasMaxLength(500);

                entity.Property(e => e.TongLuuLuongXa).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<TtdthongTinPhuTaiTongQuat>(entity =>
            {
                entity.ToTable("TTDThongTinPhuTaiTongQuat");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthongTinThuyVanNam>(entity =>
            {
                entity.ToTable("TTDThongTinThuyVanNam");

                entity.Property(e => e.ChenhLech).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.LuongNuocXa).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVeTrungBinhTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocCuoiThang).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDauThang).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<TtdthongTinThuyVanThang>(entity =>
            {
                entity.ToTable("TTDThongTinThuyVanThang");

                entity.Property(e => e.ChenhLech).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.GiaTriNuoc).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuongNuocXa).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LuuLuongNuocVeTrungBinhTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocCuoiTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocDauTuan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MucNuocGioiHan).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdthongTinTongQuat>(entity =>
            {
                entity.ToTable("TTDThongTinTongQuat");

                entity.HasIndex(e => new { e.IdNhaMay, e.Ngay })
                    .HasName("uniqueTTTQ")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtinhHinhThuThapSoLieu>(entity =>
            {
                entity.ToTable("TTDTinhHinhThuThapSoLieu");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtinhTrangThieuThan>(entity =>
            {
                entity.ToTable("TTDTinhTrangThieuThan");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtoMayBienChuKyToi>(entity =>
            {
                entity.ToTable("TTDToMayBienChuKyToi");

                entity.Property(e => e.ToMay).HasMaxLength(1000);
            });

            modelBuilder.Entity<TtdtoMayTongQuat>(entity =>
            {
                entity.ToTable("TTDToMayTongQuat");

                entity.HasIndex(e => new { e.IdToMay, e.Ngay })
                    .HasName("uniqueTMTQ")
                    .IsUnique();

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtocDoTgtlapLichChiTiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTDTocDoTGTLapLichChiTiet");

                entity.HasIndex(e => new { e.ChuKy, e.IdTocDoTgtlapLichTongQuat })
                    .HasName("UC_TDTGTLLCT")
                    .IsUnique();

                entity.Property(e => e.GiamTai).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdTocDoTgtlapLichTongQuat).HasColumnName("IdTocDoTGTLapLichTongQuat");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.TangTai).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<TtdtocDoTgtlapLichTongQuat>(entity =>
            {
                entity.ToTable("TTDTocDoTGTLapLichTongQuat");

                entity.HasIndex(e => e.IdToMayTongQuat)
                    .HasName("UC_TDTGTLLTQ")
                    .IsUnique();

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtrangThaiGuiBanChaoChiTiet>(entity =>
            {
                entity.ToTable("TTDTrangThaiGuiBanChaoChiTiet");
            });

            modelBuilder.Entity<TtdtrangThaiGuiBanChaoTongQuat>(entity =>
            {
                entity.ToTable("TTDTrangThaiGuiBanChaoTongQuat");

                entity.Property(e => e.Ngay).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtrangThaiToMayChiTiet>(entity =>
            {
                entity.ToTable("TTDTrangThaiToMayChiTiet");

                entity.Property(e => e.IsChuKyThamGiaAgc).HasColumnName("IsChuKyThamGiaAGC");
            });

            modelBuilder.Entity<TtdtrangThaiToMayTongQuat>(entity =>
            {
                entity.ToTable("TTDTrangThaiToMayTongQuat");

                entity.HasIndex(e => e.IdToMayTongQuat)
                    .HasName("UC_TTTMTQ")
                    .IsUnique();

                entity.Property(e => e.ThoiDiemBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiDiemKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdtuanTongQuat>(entity =>
            {
                entity.ToTable("TTDTuanTongQuat");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtdxacNhanThongTinTvphucVuQc>(entity =>
            {
                entity.ToTable("TTDXacNhanThongTinTVPhucVuQC");

                entity.Property(e => e.Hhl).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Htl).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KlNuocMay).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Qmay).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qve).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Qxa).HasColumnType("decimal(10, 3)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
