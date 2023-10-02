using PlatigeImage.View.ViewModels.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.Reports.Comparers
{
    public class InvoiceNetGrossComparer : IComparer<InvoiceNetGross>
    {
        public int Compare(InvoiceNetGross A, InvoiceNetGross B)
        {
            if (A.Year == B.Year)
            {
                if (A.Month == B.Month)
                {
                    return String.Compare(A.Currency, B.Currency, StringComparison.InvariantCulture);
                }
                else
                {
                    return A.Month.CompareTo(B.Month);
                }
            }
            else
            {
                return A.Year.CompareTo(B.Year);
            }
        }
    }
}
