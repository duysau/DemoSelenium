using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class ScanFileLog
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime? TimeModifided { get; set; }
        public string Path { get; set; }
        public bool? Success { get; set; }
    }
}
