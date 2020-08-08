using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiScreenDetails
    {
        public int Id { get; set; }
        public DateTime Timeline { get; set; }
        public string Data { get; set; }
        public int HmiScreenId { get; set; }

        public virtual HmiScreens HmiScreen { get; set; }
    }
}
