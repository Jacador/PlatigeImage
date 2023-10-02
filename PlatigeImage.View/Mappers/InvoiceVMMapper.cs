using PlatigeImage.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.View.ViewModels.Invoice;

namespace PlatigeImage.View.Mappers
{
    [Mapper]
    public static partial class InvoiceVMMapper
    {
        [MapperIgnoreTarget("CustomerName")]
        public static partial InvoiceVM InvoiceToInvoiceVM(Invoice invoice);
        public static partial Invoice InvoiceVMToInvoice(InvoiceVM invoiceVm);

        public static partial InvoicePosition InvoicePositionVMToInvoicePosition(InvoicePositionVM invoicePositionVm);

        [MapperIgnoreTarget(nameof(Invoice.InvoicePositions))]
        public static partial void InvoiceVMToInvoice(InvoiceVM invoiceVm, Invoice invoice);
        public static partial CustomerVM ContractorToCustomerVM(Contractor contractor);
    }
}