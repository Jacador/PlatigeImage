using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.ViewModels.Invoice;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.Interfaces.Invoice
{
    public interface IInvoiceView : IEditView
    {
        InvoiceVM? Invoice { get; set; }
    }
}
