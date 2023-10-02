using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess;
using PlatigeImage.Models;
using PlatigeImage.View.ViewModels.Invoice;
using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Reports.Comparers;
using PlatigeImage.View.ViewModels.Reports;

namespace PlatigeImage.View.Services
{
    public class InvoiceService : BaseService<Invoice>
    {
        public InvoiceService() : base(new InvoiceRepository())
        {

        }

        public List<InvoiceListVM> GetList()
        {
            if (Repository == null) 
                return new List<InvoiceListVM>();
            return Repository.GetAll().Select(i => new InvoiceListVM()
            {
                Id = i.Id, 
                FullNumber = $"FS/{i.Number}/{i.IssueDate.Year}",
                CustomerName = i.Customer != null ? i.Customer.Name : string.Empty,
                SaleDate = i.SaleDate,
                Gross = i.InvoicePositions.Sum(ip => ip.Gross),
                Currency = Enum.GetName(i.Currency) ?? string.Empty,
                
            }).ToList();
        }

        public InvoiceVM? Get(int id)
        {
            if (Repository == null) return null;

            InvoiceVM invoiceVm = new InvoiceVM();
            if (id > 0)
            {
                Invoice? invoice = Repository.FindByCondition(c => c.Id == id)
                                             .Include(c => c.InvoicePositions)
                                             .Include(c => c.Customer)
                                             .FirstOrDefault();
                if (invoice != null)
                    invoiceVm = InvoiceVMMapper.InvoiceToInvoiceVM(invoice);
            }
            return invoiceVm;
        }

        public int GetMaxNumber(int year)
        {
            if (Repository == null)
            {
                return 0;
            }
            return Repository.FindByCondition(i => i.IssueDate.Year == year).Select(i => i.Number).AsEnumerable().DefaultIfEmpty(0).Max() + 1;
        }

        public void Save(InvoiceVM invoiceVm)
        {
            if (Repository == null)
            {
                return;
            }

            Invoice? existingInvoice = Repository.FindByConditionWithTracking(c => c.Id == invoiceVm.Id)
                .Include(c => c.InvoicePositions)
                .FirstOrDefault();

            if (existingInvoice != null)
            {
                InvoiceVMMapper.InvoiceVMToInvoice(invoiceVm, existingInvoice);
                existingInvoice.InvoicePositions.Clear();
                existingInvoice.InvoicePositions.AddRange(invoiceVm.InvoicePositions.Select(InvoiceVMMapper.InvoicePositionVMToInvoicePosition));
                Repository.Update(existingInvoice);
            }
            else
            {
                Invoice invoice = InvoiceVMMapper.InvoiceVMToInvoice(invoiceVm);
                Repository.Add(invoice);
            }
            Repository.SaveChanges();
        }

        public List<InvoiceWithTotalAmount> GetInvoicesByCustomerId(int customerId)
        {
            if (Repository == null)
                return new List<InvoiceWithTotalAmount>();
            return Repository.GetAll()
                .Where(i => i.CustomerId == customerId)
                .Select(i => new InvoiceWithTotalAmount()
                {
                    FullNumber = $"FS/{i.Number}/{i.IssueDate.Year}",
                    TotalAmount = i.InvoicePositions.Sum(ip => ip.Gross),
                    Currency = i.Currency.GetDescription()
                }).ToList();
        }

        public List<InvoiceNetGross> GetInvoicesNetGrossByMonth()
        {
            if (Repository == null) 
                return new List<InvoiceNetGross>();

                return Repository.GetAll()
                    .Include(i => i.InvoicePositions)
                    .AsEnumerable()
                    .GroupBy(i => new {i.IssueDate.Year, i.IssueDate.Month, i.Currency})
                    .Select( g => new InvoiceNetGross
                    {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        TotalNet = g.Sum(i => i.InvoicePositions.Sum(ip => ip.Net)),
                        TotalGross = g.Sum(i => i.InvoicePositions.Sum(ip => ip.Gross)),
                        Currency = g.Key.Currency.GetDescription()
                    })
                    .OrderBy(i => i, new InvoiceNetGrossComparer())
                    .ToList();
        }
    }


}
