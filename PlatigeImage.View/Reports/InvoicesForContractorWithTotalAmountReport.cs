using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.ViewModels.Reports;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Services;
using PlatigeImage.View.ViewModels.Invoice;

namespace PlatigeImage.View.Reports
{
    public class InvoicesForContractorWithTotalAmountReport : XtraReport, Interfaces.IReport
    {
        private readonly ReportCreator _reportCreator;
        private readonly int _customerId;
        public InvoicesForContractorWithTotalAmountReport(int customerId)
        {
            _reportCreator = new ReportCreator();
            LoadLayout();
            _customerId = customerId;
        }

        public void InitData()
        {
            this.DataSource = CreateObjectDataSource();
            CreateObjectDataSource();
        }

        private void LoadLayout()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "InvoicesForContractorWithTotalAmountReport.repx");
            if (File.Exists(filePath))
            {
                this.LoadLayout(filePath);
            }
        }

        private object CreateObjectDataSource()
        {
            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.DataSource = _reportCreator.CreateInvoicesForContractorWithTotalAmountReport(_customerId).InvoicesWithTotalAmount;
            this.DataSource = objectDataSource;
            return objectDataSource;
        }

    }
}
