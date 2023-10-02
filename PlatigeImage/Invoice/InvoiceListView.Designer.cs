using PlatigeImage.View.WinForms.Invoice;

namespace PlatigeImage.View.WinForms
{
    partial class InvoiceListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InvoicesGridControl = new DevExpress.XtraGrid.GridControl();
            InvoicesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            NumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            CustomerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            SaleDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            GrossGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            CurrencySymbolGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            AddSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            EditSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            GenerateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ExportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            GenerateReportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).BeginInit();
            SuspendLayout();
            // 
            // InvoicesGridControl
            // 
            InvoicesGridControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InvoicesGridControl.Location = new Point(12, 12);
            InvoicesGridControl.MainView = InvoicesGridView;
            InvoicesGridControl.Name = "InvoicesGridControl";
            InvoicesGridControl.Size = new Size(974, 515);
            InvoicesGridControl.TabIndex = 0;
            InvoicesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { InvoicesGridView });
            // 
            // InvoicesGridView
            // 
            InvoicesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { NumberGridColumn, CustomerNameGridColumn, SaleDateGridColumn, GrossGridColumn, CurrencySymbolGridColumn });
            InvoicesGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            InvoicesGridView.GridControl = InvoicesGridControl;
            InvoicesGridView.Name = "InvoicesGridView";
            InvoicesGridView.OptionsBehavior.Editable = false;
            InvoicesGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            InvoicesGridView.OptionsView.ShowFooter = true;
            // 
            // NumberGridColumn
            // 
            NumberGridColumn.Caption = "Number";
            NumberGridColumn.FieldName = "FullNumber";
            NumberGridColumn.Name = "NumberGridColumn";
            NumberGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Code", "{0}") });
            NumberGridColumn.Visible = true;
            NumberGridColumn.VisibleIndex = 0;
            // 
            // CustomerNameGridColumn
            // 
            CustomerNameGridColumn.Caption = "Customer";
            CustomerNameGridColumn.FieldName = "CustomerName";
            CustomerNameGridColumn.Name = "CustomerNameGridColumn";
            CustomerNameGridColumn.Visible = true;
            CustomerNameGridColumn.VisibleIndex = 1;
            // 
            // SaleDateGridColumn
            // 
            SaleDateGridColumn.Caption = "Sale date";
            SaleDateGridColumn.DisplayFormat.FormatString = "d";
            SaleDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            SaleDateGridColumn.FieldName = "SaleDate";
            SaleDateGridColumn.Name = "SaleDateGridColumn";
            SaleDateGridColumn.Visible = true;
            SaleDateGridColumn.VisibleIndex = 2;
            // 
            // GrossGridColumn
            // 
            GrossGridColumn.Caption = "Gross";
            GrossGridColumn.DisplayFormat.FormatString = "f2";
            GrossGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            GrossGridColumn.FieldName = "Gross";
            GrossGridColumn.MinWidth = 21;
            GrossGridColumn.Name = "GrossGridColumn";
            GrossGridColumn.Visible = true;
            GrossGridColumn.VisibleIndex = 3;
            // 
            // CurrencySymbolGridColumn
            // 
            CurrencySymbolGridColumn.Caption = "Currency";
            CurrencySymbolGridColumn.FieldName = "Currency";
            CurrencySymbolGridColumn.Name = "CurrencySymbolGridColumn";
            CurrencySymbolGridColumn.Visible = true;
            CurrencySymbolGridColumn.VisibleIndex = 4;
            // 
            // AddSimpleButton
            // 
            AddSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddSimpleButton.Location = new Point(749, 533);
            AddSimpleButton.Name = "AddSimpleButton";
            AddSimpleButton.Size = new Size(75, 23);
            AddSimpleButton.TabIndex = 1;
            AddSimpleButton.Text = "Add";
            // 
            // EditSimpleButton
            // 
            EditSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditSimpleButton.Location = new Point(830, 533);
            EditSimpleButton.Name = "EditSimpleButton";
            EditSimpleButton.Size = new Size(75, 23);
            EditSimpleButton.TabIndex = 2;
            EditSimpleButton.Text = "Edit";
            // 
            // DeleteSimpleButton
            // 
            DeleteSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteSimpleButton.Location = new Point(911, 533);
            DeleteSimpleButton.Name = "DeleteSimpleButton";
            DeleteSimpleButton.Size = new Size(75, 23);
            DeleteSimpleButton.TabIndex = 3;
            DeleteSimpleButton.Text = "Delete";
            // 
            // GenerateSimpleButton
            // 
            GenerateSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GenerateSimpleButton.Location = new Point(12, 533);
            GenerateSimpleButton.Name = "GenerateSimpleButton";
            GenerateSimpleButton.Size = new Size(75, 23);
            GenerateSimpleButton.TabIndex = 4;
            GenerateSimpleButton.Text = "Generate";
            GenerateSimpleButton.Click += GenerateSimpleButton_Click;
            // 
            // ExportSimpleButton
            // 
            ExportSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExportSimpleButton.Location = new Point(93, 533);
            ExportSimpleButton.Name = "ExportSimpleButton";
            ExportSimpleButton.Size = new Size(75, 23);
            ExportSimpleButton.TabIndex = 5;
            ExportSimpleButton.Text = "Export";
            ExportSimpleButton.Click += ExportSimpleButton_Click;
            // 
            // GenerateReportSimpleButton
            // 
            GenerateReportSimpleButton.Location = new Point(174, 533);
            GenerateReportSimpleButton.Name = "GenerateReportSimpleButton";
            GenerateReportSimpleButton.Size = new Size(110, 23);
            GenerateReportSimpleButton.TabIndex = 6;
            GenerateReportSimpleButton.Text = "Generate report";
            GenerateReportSimpleButton.Click += GenerateReportSimpleButton_Click;
            // 
            // InvoiceListView
            // 
            AddButton = AddSimpleButton;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 568);
            Controls.Add(GenerateReportSimpleButton);
            Controls.Add(ExportSimpleButton);
            Controls.Add(GenerateSimpleButton);
            Controls.Add(DeleteSimpleButton);
            Controls.Add(EditSimpleButton);
            Controls.Add(AddSimpleButton);
            Controls.Add(InvoicesGridControl);
            DeleteButton = DeleteSimpleButton;
            EditButton = EditSimpleButton;
            EditViewType = typeof(InvoiceView);
            ListGridControl = InvoicesGridControl;
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1000, 600);
            Name = "InvoiceListView";
            Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)InvoicesGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl InvoicesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoicesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn NumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SaleDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CurrencySymbolGridColumn;
        private DevExpress.XtraEditors.SimpleButton AddSimpleButton;
        private DevExpress.XtraEditors.SimpleButton EditSimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton GenerateSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ExportSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GrossGridColumn;
        private DevExpress.XtraEditors.SimpleButton GenerateReportSimpleButton;
    }
}