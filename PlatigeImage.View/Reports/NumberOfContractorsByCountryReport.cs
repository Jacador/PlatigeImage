using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.ViewModels.Reports;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Services;

namespace PlatigeImage.View.Reports
{
    public class NumberOfContractorsByCountryReport : XtraReport, IReport
    {
        private readonly ReportCreator _reportCreator;
        public NumberOfContractorsByCountryReport()
        {
            _reportCreator = new ReportCreator();
            LoadLayout();
        }

        public void InitData()
        {
            this.DataSource = CreateObjectDataSource();
        }

        private void LoadLayout()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "NumberOfContractorsByCountryReport.repx");
            if (File.Exists(filePath))
            {
                this.LoadLayout(filePath);
            }
        }

        private object CreateObjectDataSource()
        {
            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.DataSource = _reportCreator.CreateNumberOfContractorsByCountryReport().ContractorsNumberByCountry;
            return objectDataSource;
        }

    }
}
