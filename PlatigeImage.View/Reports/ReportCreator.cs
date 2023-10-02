using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.ViewModels.Reports;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Services;

namespace PlatigeImage.View.Reports
{
    public class ReportCreator
    {
        private ContractorService _contractorService = new();
        private InvoiceService _invoiceService = new();

        public InvoicesForContractorWithTotalAmount CreateInvoicesForContractorWithTotalAmountReport (int customerId)
        {
            InvoicesForContractorWithTotalAmount invoicesForContractorWithTotalAmount = new InvoicesForContractorWithTotalAmount();

            invoicesForContractorWithTotalAmount.InvoicesWithTotalAmount = _invoiceService.GetInvoicesByCustomerId(customerId);

            return invoicesForContractorWithTotalAmount;
        }

        public InvoicesNetGrossByMonth CreateInvoicesNetGrossByMonthReport()
        {
            InvoicesNetGrossByMonth invoicesNetGrossByMonth = new InvoicesNetGrossByMonth();

            invoicesNetGrossByMonth.InvoicesNetGrosss = _invoiceService.GetInvoicesNetGrossByMonth();

            return invoicesNetGrossByMonth;
        }

        public NumberOfContractorsByCountry CreateNumberOfContractorsByCountryReport()
        {
            NumberOfContractorsByCountry report = new NumberOfContractorsByCountry();

            report.ContractorsNumberByCountry = _contractorService.GetContractorsNumbersByCountry();

            return report;
        }
    }
}
