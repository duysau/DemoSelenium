using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class NkLenh
    {
        public string Idlenh { get; set; }
        public string Idtb { get; set; }
        public string IduserRalenh { get; set; }
        public string IduserNhanlenh { get; set; }
        public string IduserHoanthanh { get; set; }
        public DateTime? ThoidiemGuiLenh { get; set; }
        public DateTime? ThoidiemNhanlenh { get; set; }
        public DateTime? ThoidiemHoanthanh { get; set; }
        public DateTime? ThoidiemBdth { get; set; }
        public DateTime? ThoidiemCanKt { get; set; }
        public string Idkieulenh { get; set; }
        public string Idlydolenh { get; set; }
        public string MotaLyDoLenh { get; set; }
        public decimal? GiatriSoRaLenh { get; set; }
        public decimal? GiatriSoHoanThanh { get; set; }
        public string GhichuRalenh { get; set; }
        public string GhichuHoanThanh { get; set; }
        public byte? KieuCnrl { get; set; }
        public byte? Idmdl { get; set; }
        public byte? Xpyclenh { get; set; }
        public short? Trangthai { get; set; }
        public string TrangThaiNhienLieu { get; set; }
        public bool DungLenh { get; set; }
        public DateTime? ThoiDiemRldung { get; set; }
        public string LyDoDungLenh { get; set; }
        public byte? HoanThanhLenh { get; set; }
        public bool? LenhAgc { get; set; }
        public string IduserDunglenh { get; set; }
        public string IduserHuylenh { get; set; }
        public int? NguonLenh { get; set; }
        public int Id { get; set; }
    }
}
