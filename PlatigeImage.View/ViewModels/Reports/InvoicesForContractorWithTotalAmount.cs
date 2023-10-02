using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.ViewModels.Reports
{
    public class InvoicesForContractorWithTotalAmount
    {
        public List<InvoiceWithTotalAmount> InvoicesWithTotalAmount { get; set; } = new();
    }

    public class InvoiceWithTotalAmount
    {
        public string FullNumber { get; set; }
        public double TotalAmount { get; set; }
        public string Currency { get; set; }
    }
}
