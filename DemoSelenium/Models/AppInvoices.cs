using System;
using System.Collections.Generic;

namespace DemoSelenium.Models
{
    public partial class AppInvoices
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string TenantAddress { get; set; }
        public string TenantLegalName { get; set; }
        public string TenantTaxNo { get; set; }
    }
}
