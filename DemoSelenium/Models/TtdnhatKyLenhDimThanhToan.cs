using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdnhatKyLenhDimThanhToan
    {
        public int Id { get; set; }
        public string IdLenh { get; set; }
        public string Idtb { get; set; }
        public string IduserRalenh { get; set; }
        public string IduserNhanlenh { get; set; }
        public string IduserHoanthanh { get; set; }
        public DateTime? ThoidiemTaolenh { get; set; }
        public DateTime? ThoidiemGuilenh { get; set; }
        public DateTime? ThoidiemNhanlenh { get; set; }
        public DateTime? ThoidiemHoanthanh { get; set; }
        public DateTime? ThoidiemBdth { get; set; }
        public DateTime? ThoidiemCankt { get; set; }
        public DateTime? ThoidiemBdthAgc { get; set; }
        public DateTime? ThoidiemHtAgc { get; set; }
        public string Idkieulenh { get; set; }
        public string Idlydolenh { get; set; }
        public string Motalydolenh { get; set; }
        public decimal? GiatriSoRalenh { get; set; }
        public decimal? GiatriSoHoanthanh { get; set; }
        public string GhichuRalenh { get; set; }
        public int? KieuRalenh { get; set; }
        public int? IdMucdolenh { get; set; }
        public int? XuatphatLenh { get; set; }
        public int? Trangthai { get; set; }
        public int? Nguonlenh { get; set; }
        public int? Chukyhieuluc { get; set; }
        public bool? Dunglenh { get; set; }
        public DateTime? ThoidiemDunglenh { get; set; }
        public string GhichuHoanthanh { get; set; }
        public bool? Hoanthanhlenh { get; set; }
        public string Lydodunglenh { get; set; }
        public DateTime? Ngayhieuluc { get; set; }
        public string Trangthainhienlieu { get; set; }
        public int? Lenhagc { get; set; }
        public DateTime? ThoidiemGuiagc { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Lenhauto { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Lydocapnhat { get; set; }
        public int? IdTm { get; set; }
        public decimal? Nhaptay { get; set; }
        public string MaDv { get; set; }
    }
}
