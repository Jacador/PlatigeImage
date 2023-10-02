using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Core.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Interfaces.Invoice;
using PlatigeImage.View.Presenters.Contractor;
using PlatigeImage.View.Reports;
using PlatigeImage.View.WinForms.Extensions;
using PlatigeImage.View.WinForms.Reports;

namespace PlatigeImage.View.WinForms
{
    public partial class InvoiceListView : ListView, IInvoiceListView
    {
        private readonly InvoiceListPresenter _presenter;
        private Dictionary<Currency, string> _currencies;

        public InvoiceListView()
        {
            InitializeComponent();
            _presenter = new InvoiceListPresenter(this);
            AttachPresenter(_presenter);
        }

        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            GeneratingParametersView view = new GeneratingParametersView();
            view.FormClosing += GeneratingParametersViewOnFormClosing;
            view.ShowModalDialog(this);
        }

        private void GeneratingParametersViewOnFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (sender is GeneratingParametersView { DialogResult: DialogResult.OK } form)
            {
                _presenter.Generate(form.Count);
                RefreshData();
            }
        }

        private void ExportSimpleButton_Click(object sender, EventArgs e)
        {
            ExportParametersView view = new ExportParametersView();
            view.MdiParent = this.MdiParent;
            view.FormClosing += ExportParametersViewOnFormClosing;
            view.ShowModalDialog(this);
        }

        private void ExportParametersViewOnFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (sender is ExportParametersView { DialogResult: DialogResult.OK } form)
            {
                _presenter.Export(form.Path, form.OpenFile);
            }
        }

        private void GenerateReportSimpleButton_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            IReport report = new InvoicesNetGrossByMonthReport();
            reportViewer.PrintReport(report);
            reportViewer.ShowDialog();
        }
    }


}
