using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Utils;

using PlatigeImage.View.Database;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Index.HPRtree;
using PlatigeImage.DataAccess.Helpers;
using PlatigeImage.View.Generators;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Presenters.Common;
using PlatigeImage.Models;
using PlatigeImage.View.Services;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.ViewModels.Invoice;
using PlatigeImage.View.Exporters;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Interfaces.Invoice;

namespace PlatigeImage.View.Presenters.Contractor
{
    public class InvoiceListPresenter : ListPresenter<IInvoiceListView>
    {
        private readonly InvoiceService _invoiceService;
        private List<InvoiceListVM> _invoiceListVM;
        public InvoiceListPresenter(IInvoiceListView view) : base(view)
        {
            _invoiceService = new InvoiceService();
            _invoiceListVM = new List<InvoiceListVM>();
        }

        public override object LoadDataSource()
        {
            _invoiceListVM = _invoiceService.GetList();
            return new BindingList<InvoiceListVM>(_invoiceListVM);
        }

        public override void Delete(object? item)
        {
            if (item is InvoiceListVM invoiceListVM)
            {
                _invoiceService.Delete(invoiceListVM.Id);
                _invoiceListVM.Remove(invoiceListVM);
            }
        }

        public void Generate(int count)
        {
            var invoicesList = new InvoiceGenerator().Generate(count);
            _invoiceService.AddList(invoicesList, InvoiceVMMapper.InvoiceVMToInvoice);
        }

        public void Export(string path, bool openFile)
        {
            List<InvoiceListVM> invoices = _invoiceService.GetList();
            IExporter<InvoiceListVM>? exporter = ExporterFactory.CreateExporter<InvoiceListVM>(path);
            exporter?.Export(invoices, openFile);
        }

    }

}
