using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Utils;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Helpers;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using PlatigeImage.View.Interfaces.Invoice;
using PlatigeImage.View.Presenters.Common;
using PlatigeImage.View.Services;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.ViewModels.Invoice;

namespace PlatigeImage.View.Presenters.Invoice
{
    public class InvoicePresenter : EditPresenter<IInvoiceView>
    {
        private readonly InvoiceService _invoiceService;
        private readonly ContractorService _contractorService;
        private InvoiceVM? _invoice;

        public InvoicePresenter(IInvoiceView view) : base(view)
        {
            _invoiceService = new InvoiceService();
            _contractorService = new ContractorService();
        }

        public override void LoadItem()
        {
            View.Invoice = _invoice = _invoiceService.Get(View.EditItemId);
        }

        public override void SaveItem()
        {
            if (_invoice != null)
            {
                if (_invoice.Number == 0)
                {
                    _invoice.Number = _invoiceService.GetMaxNumber(_invoice.IssueDate.Year);
                }
                _invoiceService.Save(_invoice);
            }
        }

        public Dictionary<PaymentMethod, string> PaymentMethods2()
        {
            return CommonDictionary.PaymentMethods();
        }

        public List<string> Currencies2()
        {
            return Enum.GetNames(typeof(Currency)).ToList();
        }

        public List<Currency> Currencies()
        {
            return Enum.GetValues<Currency>().ToList();
        }

        public List<PaymentMethod> PaymentMethods()
        {
            return Enum.GetValues<PaymentMethod>().ToList();
        }

        public List<CustomerVM> Customers()
        {
            return _contractorService.GetList(c => c.Active, InvoiceVMMapper.ContractorToCustomerVM);
        }

        public Dictionary<double, string> VatRates()
        {
            return CommonDictionary.VatRates();
        }
    }

}
