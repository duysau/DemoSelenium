using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class HmiScreens
    {
        public HmiScreens()
        {
            HmiScreenDetails = new HashSet<HmiScreenDetails>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual AbpTenants Tenant { get; set; }
        public virtual ICollection<HmiScreenDetails> HmiScreenDetails { get; set; }
    }
}
