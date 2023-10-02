using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using PlatigeImage.View.Interfaces;

namespace PlatigeImage.View.WinForms.Reports
{
    public partial class ReportViewer : XtraForm
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void PrintReport(IReport report)
        {
            report.InitData();
            DocumentViewer.DocumentSource = report;
            if (report is XtraReport r)
            {
                r.CreateDocument();
            }
        }
    }
}
