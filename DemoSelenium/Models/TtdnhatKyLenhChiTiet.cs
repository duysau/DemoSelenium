using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class TtdnhatKyLenhChiTiet
    {
        public int Id { get; set; }
        public string MaDv { get; set; }
        public string Idlenhcon { get; set; }
        public string Idlenhcum { get; set; }
        public string IduserHoanthanh { get; set; }
        public DateTime? ThoidiemBdth { get; set; }
        public DateTime? ThoidiemHoanthanh { get; set; }
        public string Idkieulenh { get; set; }
        public decimal? GiatriSoHoanthanh { get; set; }
        public string GhichuHoanthanh { get; set; }
        public bool? Hoanthanhlenh { get; set; }
        public string Lydocapnhat { get; set; }
    }
}
