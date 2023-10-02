using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.Models;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Interfaces.Parameters;
using PlatigeImage.View.Services;
using PlatigeImage.View.Utils;
using PlatigeImage.View.ViewModels.Invoice;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlatigeImage.View.Generators
{
    public class InvoiceGenerator
    {
        private readonly ContractorService _contractorService = new();

        public List<InvoiceVM> Generate(int count)
        {
            int[] contractorsIds = _contractorService.GetIdsArray();

            List<InvoiceVM> invoices = new List<InvoiceVM>(count);

            Random rnd = RandomUtils.SeedRandom();

            for (int i = 0; i < count; i++)
            {
                var invoice = new InvoiceVM()
                {
                    Currency = rnd.GetRandomEnum<Currency>(),
                    CustomerId = rnd.GetRandomFromArray(contractorsIds),
                    IssueDate = DateTime.Now.AddDays(-rnd.Next(180)),
                    SaleDate = DateTime.Now.AddDays(-rnd.Next(180)),
                    Number = rnd.Next(1, 1000),
                    Description = rnd.GetRandomString(0,1000),
                    InvoicePositions = GenerateInvoicePositions(rnd.Next(100))
                };

                invoices.Add(invoice);
            }

            return invoices;
        }

        private List<InvoicePositionVM> GenerateInvoicePositions(int count)
        {
            List<InvoicePositionVM> invoicePositions = new List<InvoicePositionVM>(count);

            Random rnd = RandomUtils.SeedRandom();
            Dictionary<double, string> vatRates = CommonDictionary.VatRates();
            for (int i = 0; i < count; i++)
            {
                var invoice = new InvoicePositionVM()
                {
                    Name = rnd.GetRandomString(0, 50),
                    Quantity = rnd.Next(1, 20),
                    VatRate = rnd.GetRandomFromDictionaryKeys(vatRates),
                    UnitPrice = rnd.GetRandomDecimal(0.01, 1000)
                };
                invoicePositions.Add(invoice);
            }

            return invoicePositions;
        }
    }
}
