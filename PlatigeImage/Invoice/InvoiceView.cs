using PlatigeImage.View.ViewModels.Invoice;
using PlatigeImage.View.Interfaces.Invoice;
using PlatigeImage.View.Presenters.Invoice;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace PlatigeImage.View.WinForms.Invoice
{
    public partial class InvoiceView : EditView, IInvoiceView
    {
        private readonly InvoicePresenter _presenter;
        private BaseEdit? _activeEditor = null;
        public InvoiceView()
        {
            InitializeComponent();
            _presenter = new InvoicePresenter(this);
            AttachPresenter(_presenter);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InvoiceBindingSource.DataSource = Invoice;

            //PaymentMethodLookUpEdit.Properties.DataSource = _presenter.PaymentMethods();
            PaymentMethodLookUpEdit.Properties.Items.AddRange(_presenter.PaymentMethods());
            CurrencyComboBoxEdit.Properties.Items.AddRange(_presenter.Currencies());

            VatRateRepositoryItemLookUpEdit.DataSource = _presenter.VatRates();

            var customers = _presenter.Customers();
            CustomerLookUpEdit.Properties.DataSource = customers;

            if (Invoice != null && customers.Count > 0)
            {
                Invoice.CustomerLookup = Invoice.CustomerId > 0 ? customers.FirstOrDefault(c => c.Id == Invoice.CustomerId) : customers.First();
            }

            if (Invoice != null)
            {
                InvoicePositionsGridControl.DataSource = new BindingList<InvoicePositionVM>(Invoice.InvoicePositions);
                (InvoicePositionsGridControl.DataSource as BindingList<InvoicePositionVM>)!.ListChanged += InvoiceView_ListChanged;
            }
        }

        private void InvoiceView_ListChanged(object? sender, ListChangedEventArgs e)
        {
            ToPayTextEdit.DataBindings[0]?.ReadValue();
        }

        public InvoiceVM? Invoice { get; set; }

        private void AddSimpleButton_Click(object sender, EventArgs e)
        {
            AddPosition();
        }

        private void EditSimpleButton_Click(object sender, EventArgs e)
        {
            EditPosition();
        }

        private void DeleteSimpleButton_Click(object sender, EventArgs e)
        {
            DeletePosition();
        }

        private void InvoicePositionsGridView_ShownEditor(object sender, EventArgs e)
        {
            _activeEditor = InvoicePositionsGridView.ActiveEditor;
            if (_activeEditor != null)
            {
                _activeEditor.EditValueChanged += Edit_EditValueChanged;
            }
        }

        private void Edit_EditValueChanged(object? sender, EventArgs e)
        {
            InvoicePositionsGridView.PostEditor();
        }

        private void InvoicePositionsGridView_HiddenEditor(object sender, EventArgs e)
        {
            if (_activeEditor != null)
            {
                _activeEditor.EditValueChanged -= Edit_EditValueChanged;
                _activeEditor = null;
            }
        }

        private void InvoicePositionsGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (sender is ColumnView view)
            {
                GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
                if (column == NameGridColumn)
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.Valid = false;
                        InvoicePositionsGridView.SetColumnError(NameGridColumn, "Field can't be empty.");
                        InvoicePositionsGridView.FocusedColumn = NameGridColumn;
                        InvoicePositionsGridView.ShowEditor();
                    }
                }
            }
            if (e.Valid)
                InvoicePositionsGridView.ClearColumnErrors();
        }

        private void InvoicePositionsGridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void InvoicePositionsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Row is InvoicePositionVM position && string.IsNullOrEmpty(position.Name))
            {
                e.Valid = false;
                InvoicePositionsGridView.SetColumnError(NameGridColumn, "Field can't be empty.");
                InvoicePositionsGridView.FocusedColumn = NameGridColumn;
                InvoicePositionsGridView.ShowEditor();
            }
            if (e.Valid)
                InvoicePositionsGridView.ClearColumnErrors();
        }

        private void InvoicePositionsGridView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        private void AddPosition()
        {
            InvoicePositionsGridView.AddNewRow();
            InvoicePositionsGridView.FocusedColumn = NameGridColumn;
            InvoicePositionsGridView.ShowEditor();
            InvoicePositionsGridView.ValidateEditor();
        }

        private void EditPosition()
        {
            InvoicePositionsGridView.FocusedColumn = NameGridColumn;
            InvoicePositionsGridView.ShowEditor();
        }

        private void DeletePosition()
        {
            if (InvoicePositionsGridView.FocusedRowHandle >= 0)
            {
                InvoicePositionsGridView.DeleteRow(InvoicePositionsGridView.FocusedRowHandle);
            }
        }

        private void CustomerLookUpEdit_Validating(object sender, CancelEventArgs e)
        {
            if (CustomerLookUpEdit.EditValue == null)
                e.Cancel = true;
        }
    }
}
