using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class OrganizationUnitServicePoint
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public long OrganizationUnit { get; set; }
        public long ServicePoint { get; set; }

        public virtual AbpOrganizationUnits OrganizationUnitNavigation { get; set; }
    }
}
