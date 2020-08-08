using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiThe
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string TenOpc { get; set; }
        public string TenEsLink { get; set; }
        public decimal? TiLe { get; set; }
        public string TrangThai { get; set; }
        public decimal? GiaTriNhoNhat { get; set; }
        public decimal? GiaTriLonNhat { get; set; }
        public string TenTheDieuKhienTuXa { get; set; }
        public string TenTheCanhBao { get; set; }
        public bool? ChoPhepDieuKhienTuXa { get; set; }
        public string MoTa { get; set; }
        public int? LoaiTheId { get; set; }
        public int ThietBiId { get; set; }
        public int LoaiNhomTheId { get; set; }

        public virtual HmiLoaiThe LoaiThe { get; set; }
        public virtual HmiThietBi ThietBi { get; set; }
    }
}
