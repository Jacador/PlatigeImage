using PlatigeImage.View.ViewModels.Invoice;

namespace PlatigeImage.View.WinForms.Invoice
{
    partial class InvoiceView
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
            components = new System.ComponentModel.Container();
            CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            InvoiceBindingSource = new BindingSource(components);
            CustomerLabelControl = new DevExpress.XtraEditors.LabelControl();
            DescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            IssueDateEdit = new DevExpress.XtraEditors.DateEdit();
            SaleDateEdit = new DevExpress.XtraEditors.DateEdit();
            PaymentMethodLabelControl = new DevExpress.XtraEditors.LabelControl();
            DescriptionLabelControl = new DevExpress.XtraEditors.LabelControl();
            CurrencyLabelControl = new DevExpress.XtraEditors.LabelControl();
            IssueDateLabelControl = new DevExpress.XtraEditors.LabelControl();
            SaleDateLabelControl = new DevExpress.XtraEditors.LabelControl();
            NumberLabelControl = new DevExpress.XtraEditors.LabelControl();
            CustomerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            CurrencyComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            FullNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            InvoicePositionsGridControl = new DevExpress.XtraGrid.GridControl();
            InvoicePositionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            NameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            NameRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            QuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            QuantityRepositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            VatRateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            VatRateRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            UnitPriceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            UnitPriceRepositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            NetGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            VatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            GrossGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            EditSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            AddSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ToPayLabelControl = new DevExpress.XtraEditors.LabelControl();
            ToPayTextEdit = new DevExpress.XtraEditors.TextEdit();
            PaymentMethodLookUpEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)CustomerNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DescriptionMemoEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IssueDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IssueDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SaleDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SaleDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrencyComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FullNumberTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicePositionsGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicePositionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameRepositoryItemTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityRepositoryItemSpinEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VatRateRepositoryItemLookUpEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnitPriceRepositoryItemSpinEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToPayTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentMethodLookUpEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // SaveSimpleButton
            // 
            SaveSimpleButton.Location = new Point(384, 464);
            SaveSimpleButton.Margin = new Padding(3, 2, 3, 2);
            SaveSimpleButton.Size = new Size(64, 19);
            SaveSimpleButton.TabIndex = 21;
            // 
            // CancelSimpleButton
            // 
            CancelSimpleButton.Location = new Point(12, 464);
            CancelSimpleButton.Margin = new Padding(3, 2, 3, 2);
            CancelSimpleButton.Size = new Size(64, 19);
            CancelSimpleButton.TabIndex = 22;
            // 
            // CustomerNameTextEdit
            // 
            CustomerNameTextEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "CustomerName", true));
            CustomerNameTextEdit.Enabled = false;
            CustomerNameTextEdit.Location = new Point(122, 67);
            CustomerNameTextEdit.Margin = new Padding(3, 2, 3, 2);
            CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            CustomerNameTextEdit.Size = new Size(213, 20);
            CustomerNameTextEdit.TabIndex = 8;
            // 
            // InvoiceBindingSource
            // 
            InvoiceBindingSource.DataSource = typeof(InvoiceVM);
            // 
            // CustomerLabelControl
            // 
            CustomerLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerLabelControl.Appearance.Options.UseFont = true;
            CustomerLabelControl.Location = new Point(12, 50);
            CustomerLabelControl.Margin = new Padding(3, 2, 3, 2);
            CustomerLabelControl.Name = "CustomerLabelControl";
            CustomerLabelControl.Size = new Size(48, 12);
            CustomerLabelControl.TabIndex = 6;
            CustomerLabelControl.Text = "Customer";
            // 
            // DescriptionMemoEdit
            // 
            DescriptionMemoEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionMemoEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "Description", true));
            DescriptionMemoEdit.Location = new Point(12, 378);
            DescriptionMemoEdit.Margin = new Padding(3, 2, 3, 2);
            DescriptionMemoEdit.Name = "DescriptionMemoEdit";
            DescriptionMemoEdit.Properties.ScrollBars = ScrollBars.None;
            DescriptionMemoEdit.Size = new Size(436, 81);
            DescriptionMemoEdit.TabIndex = 20;
            // 
            // IssueDateEdit
            // 
            IssueDateEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "IssueDate", true));
            IssueDateEdit.EditValue = null;
            IssueDateEdit.Location = new Point(231, 29);
            IssueDateEdit.Margin = new Padding(3, 2, 3, 2);
            IssueDateEdit.Name = "IssueDateEdit";
            IssueDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            IssueDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            IssueDateEdit.Size = new Size(103, 20);
            IssueDateEdit.TabIndex = 5;
            // 
            // SaleDateEdit
            // 
            SaleDateEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "SaleDate", true));
            SaleDateEdit.EditValue = null;
            SaleDateEdit.Location = new Point(122, 29);
            SaleDateEdit.Margin = new Padding(3, 2, 3, 2);
            SaleDateEdit.Name = "SaleDateEdit";
            SaleDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            SaleDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            SaleDateEdit.Size = new Size(103, 20);
            SaleDateEdit.TabIndex = 3;
            // 
            // PaymentMethodLabelControl
            // 
            PaymentMethodLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentMethodLabelControl.Appearance.Options.UseFont = true;
            PaymentMethodLabelControl.Location = new Point(122, 88);
            PaymentMethodLabelControl.Margin = new Padding(3, 2, 3, 2);
            PaymentMethodLabelControl.Name = "PaymentMethodLabelControl";
            PaymentMethodLabelControl.Size = new Size(84, 12);
            PaymentMethodLabelControl.TabIndex = 11;
            PaymentMethodLabelControl.Text = "Payment method";
            // 
            // DescriptionLabelControl
            // 
            DescriptionLabelControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescriptionLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabelControl.Appearance.Options.UseFont = true;
            DescriptionLabelControl.Location = new Point(12, 362);
            DescriptionLabelControl.Margin = new Padding(3, 2, 3, 2);
            DescriptionLabelControl.Name = "DescriptionLabelControl";
            DescriptionLabelControl.Size = new Size(57, 12);
            DescriptionLabelControl.TabIndex = 19;
            DescriptionLabelControl.Text = "Description";
            // 
            // CurrencyLabelControl
            // 
            CurrencyLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            CurrencyLabelControl.Appearance.Options.UseFont = true;
            CurrencyLabelControl.Location = new Point(12, 88);
            CurrencyLabelControl.Margin = new Padding(3, 2, 3, 2);
            CurrencyLabelControl.Name = "CurrencyLabelControl";
            CurrencyLabelControl.Size = new Size(46, 12);
            CurrencyLabelControl.TabIndex = 9;
            CurrencyLabelControl.Text = "Currency";
            // 
            // IssueDateLabelControl
            // 
            IssueDateLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            IssueDateLabelControl.Appearance.Options.UseFont = true;
            IssueDateLabelControl.Location = new Point(231, 13);
            IssueDateLabelControl.Margin = new Padding(3, 2, 3, 2);
            IssueDateLabelControl.Name = "IssueDateLabelControl";
            IssueDateLabelControl.Size = new Size(67, 12);
            IssueDateLabelControl.TabIndex = 4;
            IssueDateLabelControl.Text = "Date of Issue";
            // 
            // SaleDateLabelControl
            // 
            SaleDateLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaleDateLabelControl.Appearance.Options.UseFont = true;
            SaleDateLabelControl.Location = new Point(122, 13);
            SaleDateLabelControl.Margin = new Padding(3, 2, 3, 2);
            SaleDateLabelControl.Name = "SaleDateLabelControl";
            SaleDateLabelControl.Size = new Size(61, 12);
            SaleDateLabelControl.TabIndex = 2;
            SaleDateLabelControl.Text = "Date of Sale";
            // 
            // NumberLabelControl
            // 
            NumberLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLabelControl.Appearance.Options.UseFont = true;
            NumberLabelControl.Location = new Point(12, 13);
            NumberLabelControl.Margin = new Padding(3, 2, 3, 2);
            NumberLabelControl.Name = "NumberLabelControl";
            NumberLabelControl.Size = new Size(39, 12);
            NumberLabelControl.TabIndex = 0;
            NumberLabelControl.Text = "Number";
            // 
            // CustomerLookUpEdit
            // 
            CustomerLookUpEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "CustomerLookup", true));
            CustomerLookUpEdit.Location = new Point(10, 67);
            CustomerLookUpEdit.Margin = new Padding(3, 2, 3, 2);
            CustomerLookUpEdit.Name = "CustomerLookUpEdit";
            CustomerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CustomerLookUpEdit.Properties.DisplayMember = "Code";
            CustomerLookUpEdit.Properties.NullText = "";
            CustomerLookUpEdit.Properties.PopupSizeable = false;
            CustomerLookUpEdit.Size = new Size(104, 20);
            CustomerLookUpEdit.TabIndex = 7;
            CustomerLookUpEdit.Validating += CustomerLookUpEdit_Validating;
            // 
            // CurrencyComboBoxEdit
            // 
            CurrencyComboBoxEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "Currency", true));
            CurrencyComboBoxEdit.Location = new Point(10, 104);
            CurrencyComboBoxEdit.Margin = new Padding(3, 2, 3, 2);
            CurrencyComboBoxEdit.Name = "CurrencyComboBoxEdit";
            CurrencyComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CurrencyComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            CurrencyComboBoxEdit.Size = new Size(103, 20);
            CurrencyComboBoxEdit.TabIndex = 10;
            // 
            // FullNumberTextEdit
            // 
            FullNumberTextEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "FullNumber", true));
            FullNumberTextEdit.Enabled = false;
            FullNumberTextEdit.Location = new Point(12, 29);
            FullNumberTextEdit.Margin = new Padding(3, 2, 3, 2);
            FullNumberTextEdit.Name = "FullNumberTextEdit";
            FullNumberTextEdit.Size = new Size(102, 20);
            FullNumberTextEdit.TabIndex = 1;
            // 
            // InvoicePositionsGridControl
            // 
            InvoicePositionsGridControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InvoicePositionsGridControl.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            InvoicePositionsGridControl.Location = new Point(12, 126);
            InvoicePositionsGridControl.MainView = InvoicePositionsGridView;
            InvoicePositionsGridControl.Margin = new Padding(3, 2, 3, 2);
            InvoicePositionsGridControl.Name = "InvoicePositionsGridControl";
            InvoicePositionsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { NameRepositoryItemTextEdit, QuantityRepositoryItemSpinEdit, UnitPriceRepositoryItemSpinEdit, VatRateRepositoryItemLookUpEdit });
            InvoicePositionsGridControl.Size = new Size(436, 220);
            InvoicePositionsGridControl.TabIndex = 15;
            InvoicePositionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { InvoicePositionsGridView });
            // 
            // InvoicePositionsGridView
            // 
            InvoicePositionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { NameGridColumn, QuantityGridColumn, VatRateGridColumn, UnitPriceGridColumn, NetGridColumn, VatGridColumn, GrossGridColumn });
            InvoicePositionsGridView.DetailHeight = 284;
            InvoicePositionsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            InvoicePositionsGridView.GridControl = InvoicePositionsGridControl;
            InvoicePositionsGridView.Name = "InvoicePositionsGridView";
            InvoicePositionsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            InvoicePositionsGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            InvoicePositionsGridView.OptionsView.ShowGroupPanel = false;
            InvoicePositionsGridView.HiddenEditor += InvoicePositionsGridView_HiddenEditor;
            InvoicePositionsGridView.ShownEditor += InvoicePositionsGridView_ShownEditor;
            InvoicePositionsGridView.InvalidRowException += InvoicePositionsGridView_InvalidRowException;
            InvoicePositionsGridView.ValidateRow += InvoicePositionsGridView_ValidateRow;
            InvoicePositionsGridView.ValidatingEditor += InvoicePositionsGridView_ValidatingEditor;
            InvoicePositionsGridView.InvalidValueException += InvoicePositionsGridView_InvalidValueException;
            // 
            // NameGridColumn
            // 
            NameGridColumn.Caption = "Name";
            NameGridColumn.ColumnEdit = NameRepositoryItemTextEdit;
            NameGridColumn.FieldName = "Name";
            NameGridColumn.MinWidth = 21;
            NameGridColumn.Name = "NameGridColumn";
            NameGridColumn.Visible = true;
            NameGridColumn.VisibleIndex = 0;
            NameGridColumn.Width = 81;
            // 
            // NameRepositoryItemTextEdit
            // 
            NameRepositoryItemTextEdit.AutoHeight = false;
            NameRepositoryItemTextEdit.Name = "NameRepositoryItemTextEdit";
            // 
            // QuantityGridColumn
            // 
            QuantityGridColumn.Caption = "Quantity";
            QuantityGridColumn.ColumnEdit = QuantityRepositoryItemSpinEdit;
            QuantityGridColumn.DisplayFormat.FormatString = "d";
            QuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            QuantityGridColumn.FieldName = "Quantity";
            QuantityGridColumn.MinWidth = 21;
            QuantityGridColumn.Name = "QuantityGridColumn";
            QuantityGridColumn.Visible = true;
            QuantityGridColumn.VisibleIndex = 1;
            QuantityGridColumn.Width = 81;
            // 
            // QuantityRepositoryItemSpinEdit
            // 
            QuantityRepositoryItemSpinEdit.AutoHeight = false;
            QuantityRepositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            QuantityRepositoryItemSpinEdit.IsFloatValue = false;
            QuantityRepositoryItemSpinEdit.MaskSettings.Set("mask", "N00");
            QuantityRepositoryItemSpinEdit.MaxValue = new decimal(new int[] { 1000000, 0, 0, 0 });
            QuantityRepositoryItemSpinEdit.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityRepositoryItemSpinEdit.Name = "QuantityRepositoryItemSpinEdit";
            // 
            // VatRateGridColumn
            // 
            VatRateGridColumn.Caption = "VAT Rate";
            VatRateGridColumn.ColumnEdit = VatRateRepositoryItemLookUpEdit;
            VatRateGridColumn.FieldName = "VatRate";
            VatRateGridColumn.MinWidth = 21;
            VatRateGridColumn.Name = "VatRateGridColumn";
            VatRateGridColumn.Visible = true;
            VatRateGridColumn.VisibleIndex = 2;
            VatRateGridColumn.Width = 81;
            // 
            // VatRateRepositoryItemLookUpEdit
            // 
            VatRateRepositoryItemLookUpEdit.AutoHeight = false;
            VatRateRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            VatRateRepositoryItemLookUpEdit.Name = "VatRateRepositoryItemLookUpEdit";
            // 
            // UnitPriceGridColumn
            // 
            UnitPriceGridColumn.Caption = "Price";
            UnitPriceGridColumn.ColumnEdit = UnitPriceRepositoryItemSpinEdit;
            UnitPriceGridColumn.Name = "UnitPriceGridColumn";
            UnitPriceGridColumn.Visible = true;
            UnitPriceGridColumn.VisibleIndex = 3;
            // 
            // UnitPriceRepositoryItemSpinEdit
            // 
            UnitPriceRepositoryItemSpinEdit.AutoHeight = false;
            UnitPriceRepositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            UnitPriceRepositoryItemSpinEdit.MaskSettings.Set("mask", "f2");
            UnitPriceRepositoryItemSpinEdit.MaskSettings.Set("autoHideDecimalSeparator", false);
            UnitPriceRepositoryItemSpinEdit.Name = "UnitPriceRepositoryItemSpinEdit";
            // 
            // NetGridColumn
            // 
            NetGridColumn.Caption = "Net";
            NetGridColumn.DisplayFormat.FormatString = "f2";
            NetGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            NetGridColumn.FieldName = "Net";
            NetGridColumn.MinWidth = 21;
            NetGridColumn.Name = "NetGridColumn";
            NetGridColumn.OptionsColumn.AllowEdit = false;
            NetGridColumn.Visible = true;
            NetGridColumn.VisibleIndex = 4;
            NetGridColumn.Width = 81;
            // 
            // VatGridColumn
            // 
            VatGridColumn.Caption = "VAT";
            VatGridColumn.DisplayFormat.FormatString = "f2";
            VatGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            VatGridColumn.FieldName = "Vat";
            VatGridColumn.MinWidth = 21;
            VatGridColumn.Name = "VatGridColumn";
            VatGridColumn.OptionsColumn.AllowEdit = false;
            VatGridColumn.Visible = true;
            VatGridColumn.VisibleIndex = 5;
            VatGridColumn.Width = 81;
            // 
            // GrossGridColumn
            // 
            GrossGridColumn.Caption = "Gross";
            GrossGridColumn.DisplayFormat.FormatString = "f2";
            GrossGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            GrossGridColumn.FieldName = "Gross";
            GrossGridColumn.MinWidth = 21;
            GrossGridColumn.Name = "GrossGridColumn";
            GrossGridColumn.OptionsColumn.AllowEdit = false;
            GrossGridColumn.Visible = true;
            GrossGridColumn.VisibleIndex = 6;
            GrossGridColumn.Width = 81;
            // 
            // DeleteSimpleButton
            // 
            DeleteSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteSimpleButton.Location = new Point(373, 351);
            DeleteSimpleButton.Margin = new Padding(3, 2, 3, 2);
            DeleteSimpleButton.Name = "DeleteSimpleButton";
            DeleteSimpleButton.Size = new Size(75, 23);
            DeleteSimpleButton.TabIndex = 18;
            DeleteSimpleButton.Text = "Delete";
            DeleteSimpleButton.Click += DeleteSimpleButton_Click;
            // 
            // EditSimpleButton
            // 
            EditSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditSimpleButton.Location = new Point(292, 351);
            EditSimpleButton.Margin = new Padding(3, 2, 3, 2);
            EditSimpleButton.Name = "EditSimpleButton";
            EditSimpleButton.Size = new Size(75, 23);
            EditSimpleButton.TabIndex = 17;
            EditSimpleButton.Text = "Edit";
            EditSimpleButton.Click += EditSimpleButton_Click;
            // 
            // AddSimpleButton
            // 
            AddSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddSimpleButton.Location = new Point(212, 351);
            AddSimpleButton.Margin = new Padding(3, 2, 3, 2);
            AddSimpleButton.Name = "AddSimpleButton";
            AddSimpleButton.Size = new Size(75, 23);
            AddSimpleButton.TabIndex = 16;
            AddSimpleButton.Text = "Add";
            AddSimpleButton.Click += AddSimpleButton_Click;
            // 
            // ToPayLabelControl
            // 
            ToPayLabelControl.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ToPayLabelControl.Appearance.Options.UseFont = true;
            ToPayLabelControl.Location = new Point(231, 88);
            ToPayLabelControl.Margin = new Padding(3, 2, 3, 2);
            ToPayLabelControl.Name = "ToPayLabelControl";
            ToPayLabelControl.Size = new Size(76, 12);
            ToPayLabelControl.TabIndex = 13;
            ToPayLabelControl.Text = "Amount to pay:";
            // 
            // ToPayTextEdit
            // 
            ToPayTextEdit.DataBindings.Add(new Binding("Text", InvoiceBindingSource, "ToPay", true));
            ToPayTextEdit.Enabled = false;
            ToPayTextEdit.Location = new Point(231, 104);
            ToPayTextEdit.Margin = new Padding(3, 2, 3, 2);
            ToPayTextEdit.Name = "ToPayTextEdit";
            ToPayTextEdit.Properties.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ToPayTextEdit.Properties.Appearance.Options.UseFont = true;
            ToPayTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            ToPayTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            ToPayTextEdit.RightToLeft = RightToLeft.No;
            ToPayTextEdit.Size = new Size(103, 18);
            ToPayTextEdit.TabIndex = 14;
            // 
            // PaymentMethodLookUpEdit
            // 
            PaymentMethodLookUpEdit.DataBindings.Add(new Binding("EditValue", InvoiceBindingSource, "PaymentMethod", true));
            PaymentMethodLookUpEdit.Location = new Point(122, 104);
            PaymentMethodLookUpEdit.Margin = new Padding(3, 2, 3, 2);
            PaymentMethodLookUpEdit.Name = "PaymentMethodLookUpEdit";
            PaymentMethodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            PaymentMethodLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            PaymentMethodLookUpEdit.Size = new Size(103, 20);
            PaymentMethodLookUpEdit.TabIndex = 12;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 499);
            Controls.Add(ToPayTextEdit);
            Controls.Add(ToPayLabelControl);
            Controls.Add(AddSimpleButton);
            Controls.Add(EditSimpleButton);
            Controls.Add(DeleteSimpleButton);
            Controls.Add(InvoicePositionsGridControl);
            Controls.Add(FullNumberTextEdit);
            Controls.Add(CustomerNameTextEdit);
            Controls.Add(CustomerLabelControl);
            Controls.Add(DescriptionMemoEdit);
            Controls.Add(IssueDateEdit);
            Controls.Add(SaleDateEdit);
            Controls.Add(PaymentMethodLabelControl);
            Controls.Add(DescriptionLabelControl);
            Controls.Add(CurrencyLabelControl);
            Controls.Add(IssueDateLabelControl);
            Controls.Add(SaleDateLabelControl);
            Controls.Add(NumberLabelControl);
            Controls.Add(CustomerLookUpEdit);
            Controls.Add(CurrencyComboBoxEdit);
            Controls.Add(PaymentMethodLookUpEdit);
            Margin = new Padding(4);
            MinimumSize = new Size(405, 531);
            Name = "InvoiceView";
            Text = "InvoiceView";
            Controls.SetChildIndex(PaymentMethodLookUpEdit, 0);
            Controls.SetChildIndex(SaveSimpleButton, 0);
            Controls.SetChildIndex(CancelSimpleButton, 0);
            Controls.SetChildIndex(CurrencyComboBoxEdit, 0);
            Controls.SetChildIndex(CustomerLookUpEdit, 0);
            Controls.SetChildIndex(NumberLabelControl, 0);
            Controls.SetChildIndex(SaleDateLabelControl, 0);
            Controls.SetChildIndex(IssueDateLabelControl, 0);
            Controls.SetChildIndex(CurrencyLabelControl, 0);
            Controls.SetChildIndex(DescriptionLabelControl, 0);
            Controls.SetChildIndex(PaymentMethodLabelControl, 0);
            Controls.SetChildIndex(SaleDateEdit, 0);
            Controls.SetChildIndex(IssueDateEdit, 0);
            Controls.SetChildIndex(DescriptionMemoEdit, 0);
            Controls.SetChildIndex(CustomerLabelControl, 0);
            Controls.SetChildIndex(CustomerNameTextEdit, 0);
            Controls.SetChildIndex(FullNumberTextEdit, 0);
            Controls.SetChildIndex(InvoicePositionsGridControl, 0);
            Controls.SetChildIndex(DeleteSimpleButton, 0);
            Controls.SetChildIndex(EditSimpleButton, 0);
            Controls.SetChildIndex(AddSimpleButton, 0);
            Controls.SetChildIndex(ToPayLabelControl, 0);
            Controls.SetChildIndex(ToPayTextEdit, 0);
            ((System.ComponentModel.ISupportInitialize)CustomerNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DescriptionMemoEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IssueDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)IssueDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SaleDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)SaleDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrencyComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)FullNumberTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicePositionsGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicePositionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameRepositoryItemTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityRepositoryItemSpinEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)VatRateRepositoryItemLookUpEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnitPriceRepositoryItemSpinEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToPayTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentMethodLookUpEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraEditors.LabelControl CustomerLabelControl;
        private DevExpress.XtraEditors.MemoEdit DescriptionMemoEdit;
        private DevExpress.XtraEditors.DateEdit IssueDateEdit;
        private DevExpress.XtraEditors.DateEdit SaleDateEdit;
        private DevExpress.XtraEditors.LabelControl PaymentMethodLabelControl;
        private DevExpress.XtraEditors.LabelControl DescriptionLabelControl;
        private DevExpress.XtraEditors.LabelControl CurrencyLabelControl;
        private DevExpress.XtraEditors.LabelControl IssueDateLabelControl;
        private DevExpress.XtraEditors.LabelControl SaleDateLabelControl;
        private DevExpress.XtraEditors.LabelControl NumberLabelControl;
        private BindingSource InvoiceBindingSource;
        private DevExpress.XtraEditors.LookUpEdit CustomerLookUpEdit;
        private DevExpress.XtraEditors.ComboBoxEdit CurrencyComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit FullNumberTextEdit;
        private DevExpress.XtraGrid.GridControl InvoicePositionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoicePositionsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn NameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn VatRateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NetGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn VatGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GrossGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit NameRepositoryItemTextEdit;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton EditSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AddSimpleButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit QuantityRepositoryItemSpinEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit UnitPriceRepositoryItemSpinEdit;
        private DevExpress.XtraEditors.LabelControl ToPayLabelControl;
        private DevExpress.XtraEditors.TextEdit ToPayTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit VatRateRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.ComboBoxEdit PaymentMethodLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPriceGridColumn;
    }
}