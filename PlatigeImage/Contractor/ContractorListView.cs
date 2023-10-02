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
using DevExpress.XtraReports.UI;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Presenters.Contractor;
using PlatigeImage.View.Reports;
using PlatigeImage.View.ViewModels.Reports;
using PlatigeImage.View.WinForms.Extensions;
using PlatigeImage.View.WinForms.Reports;

namespace PlatigeImage.View.WinForms
{
    public partial class ContractorListView : ListView, IContractorListView
    {
        private readonly ContractorListPresenter _presenter;
        private Dictionary<ContractorKind, string> _customerKinds;
        private Dictionary<ContractorStatus, string> _customerStatuses;
        public ContractorListView()
        {
            InitializeComponent();
            _presenter = new ContractorListPresenter(this);
            AttachPresenter(_presenter);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _customerKinds = _presenter.ContractorKinds();
            _customerStatuses = _presenter.ContractorStatuses();
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

        private void ContractorsGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == KindGridColumn)
            {
                if (_customerKinds.ContainsKey((ContractorKind)e.Value))
                    e.DisplayText = _customerKinds[(ContractorKind)e.Value];
            }
            else if (e.Column == StatusGridColumn)
            {
                if (_customerStatuses.ContainsKey((ContractorStatus)e.Value))
                    e.DisplayText = _customerStatuses[(ContractorStatus)e.Value];
            }
        }

        private void GenerateReportSimpleButton_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            IReport report = new NumberOfContractorsByCountryReport();
            reportViewer.PrintReport(report);
            reportViewer.ShowDialog();
        }
    }


}
