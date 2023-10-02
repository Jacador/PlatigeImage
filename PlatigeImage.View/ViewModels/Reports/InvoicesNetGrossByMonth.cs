using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.ViewModels.Reports
{
    public class InvoicesNetGrossByMonth
    {
        public List<InvoiceNetGross> InvoicesNetGrosss { get; set; } = new();
    }

    public class InvoiceNetGross
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string IssueDate => $"{Year}/{Month}";
        public double TotalNet { get; set; }
        public double TotalGross { get; set; }
        public string Currency { get; set; }
    }

}
