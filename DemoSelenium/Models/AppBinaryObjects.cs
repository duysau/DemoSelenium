using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class AppBinaryObjects
    {
        public Guid Id { get; set; }
        public byte[] Bytes { get; set; }
        public int? TenantId { get; set; }
    }
}
