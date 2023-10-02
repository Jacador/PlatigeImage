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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSpreadsheet.Import.Xls;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Presenters.Contractor;
using PlatigeImage.View.Reports;
using PlatigeImage.View.Validators;
using PlatigeImage.View.WinForms.Reports;
using ComboBox = System.Windows.Forms.ComboBox;

namespace PlatigeImage.View.WinForms
{
    public partial class ContractorView : EditView, IContractorView
    {
        private readonly ContractorPresenter _presenter;

        public ContractorView()
        {
            InitializeComponent();
            _presenter = new ContractorPresenter(this);
            AttachPresenter(_presenter);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ContractorBindingSource.DataSource = Contractor;

            TinPrefixComboBoxEdit.Properties.Items.AddRange(Enum.GetValues<CountryCode>());
            CountryComboBoxEdit.Properties.Items.AddRange(Enum.GetValues<CountryCode>().GetDescription());

            KindLookUpEdit.Properties.DataSource = _presenter.ContractorKinds();
            StatusLookUpEdit.Properties.DataSource = _presenter.ContractorStatuses();

            if (Contractor is { Id: 0 })
                GenerateReportSimpleButton.Visible = false;

            if (Contractor is {Id: 1})
                DisableIndefiniteButtons();
                

            CodeTextEdit.Select();
        }

        public ContractorVM? Contractor { get; set; }

        private void CodeTextEdit_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CodeTextEdit.Text))
            {
                e.Cancel = true;
            }
        }

        private void TinTextEdit_Validating(object sender, CancelEventArgs e)
        {
            if ((CountryCode)TinPrefixComboBoxEdit.EditValue == CountryCode.PL && !TinValidator.IsValid(TinTextEdit.Text))
            {
                e.Cancel = true;
            }
        }

        private void EMailTextEdit_Validating(object sender, CancelEventArgs e)
        {
            if (!EMailValidator.IsValid(EMailTextEdit.Text))
            {
                e.Cancel = true;
            }
        }

        private void CodeTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Code cannot be empty";
        }

        private void TinTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Invalid TIN";
        }

        private void PinTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Invalid PIN";
        }

        private void EMailTextEdit_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Invalid Email";
        }

        private void TinPrefixComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {
            TinTextEdit.DoValidate();
        }

        private void GenerateReportSimpleButton_Click(object sender, EventArgs e)
        {
            if (Contractor?.Id == null)
            {
                return;
            }
            ReportViewer reportViewer = new ReportViewer();
            IReport report = new InvoicesForContractorWithTotalAmountReport(Contractor.Id);
            reportViewer.PrintReport(report);
            reportViewer.ShowDialog();
        }

        private void DisableIndefiniteButtons()
        {
            ActiveCheckEdit.Enabled = false;
            CodeTextEdit.Enabled = false;
        }
    }
}
