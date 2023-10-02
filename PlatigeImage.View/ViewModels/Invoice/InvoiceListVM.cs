using PlatigeImage.Models.Enums;
using PlatigeImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.ViewModels.Invoice
{
    public class InvoiceListVM
    {
        public int Id { get; set; }
        public string FullNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public double Gross { get; set; }
        public string Currency { get; set; }

    }
}
