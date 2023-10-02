namespace PlatigeImage.View.WinForms
{
    partial class ContractorListView
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
            ContractorsGridControl = new DevExpress.XtraGrid.GridControl();
            ContractorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            CodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            NameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            TinGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            AdressGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            CountryGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            KindGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            StatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            AddSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            EditSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            DeleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            GenerateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ExportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            GenerateReportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)ContractorsGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContractorsGridView).BeginInit();
            SuspendLayout();
            // 
            // ContractorsGridControl
            // 
            ContractorsGridControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContractorsGridControl.Location = new Point(12, 12);
            ContractorsGridControl.MainView = ContractorsGridView;
            ContractorsGridControl.Name = "ContractorsGridControl";
            ContractorsGridControl.Size = new Size(974, 515);
            ContractorsGridControl.TabIndex = 0;
            ContractorsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ContractorsGridView });
            // 
            // ContractorsGridView
            // 
            ContractorsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { CodeGridColumn, NameGridColumn, TinGridColumn, AdressGridColumn, CountryGridColumn, KindGridColumn, StatusGridColumn });
            ContractorsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            ContractorsGridView.GridControl = ContractorsGridControl;
            ContractorsGridView.Name = "ContractorsGridView";
            ContractorsGridView.OptionsBehavior.Editable = false;
            ContractorsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            ContractorsGridView.OptionsView.ShowFooter = true;
            ContractorsGridView.CustomColumnDisplayText += ContractorsGridView_CustomColumnDisplayText;
            // 
            // CodeGridColumn
            // 
            CodeGridColumn.Caption = "Code";
            CodeGridColumn.FieldName = "Code";
            CodeGridColumn.Name = "CodeGridColumn";
            CodeGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Code", "{0}") });
            CodeGridColumn.Visible = true;
            CodeGridColumn.VisibleIndex = 0;
            // 
            // NameGridColumn
            // 
            NameGridColumn.Caption = "Name";
            NameGridColumn.FieldName = "Name";
            NameGridColumn.Name = "NameGridColumn";
            NameGridColumn.Visible = true;
            NameGridColumn.VisibleIndex = 1;
            // 
            // TinGridColumn
            // 
            TinGridColumn.Caption = "Tin";
            TinGridColumn.FieldName = "Tin";
            TinGridColumn.Name = "TinGridColumn";
            TinGridColumn.Visible = true;
            TinGridColumn.VisibleIndex = 2;
            // 
            // AdressGridColumn
            // 
            AdressGridColumn.Caption = "Adress";
            AdressGridColumn.FieldName = "Adress";
            AdressGridColumn.Name = "AdressGridColumn";
            AdressGridColumn.Visible = true;
            AdressGridColumn.VisibleIndex = 3;
            // 
            // CountryGridColumn
            // 
            CountryGridColumn.Caption = "Country";
            CountryGridColumn.FieldName = "Country";
            CountryGridColumn.Name = "CountryGridColumn";
            CountryGridColumn.Visible = true;
            CountryGridColumn.VisibleIndex = 5;
            // 
            // KindGridColumn
            // 
            KindGridColumn.Caption = "Kind";
            KindGridColumn.FieldName = "Kind";
            KindGridColumn.Name = "KindGridColumn";
            KindGridColumn.Visible = true;
            KindGridColumn.VisibleIndex = 4;
            // 
            // StatusGridColumn
            // 
            StatusGridColumn.Caption = "Status";
            StatusGridColumn.FieldName = "Status";
            StatusGridColumn.Name = "StatusGridColumn";
            StatusGridColumn.Visible = true;
            StatusGridColumn.VisibleIndex = 6;
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
            // ContractorListView
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
            Controls.Add(ContractorsGridControl);
            DeleteButton = DeleteSimpleButton;
            EditButton = EditSimpleButton;
            EditViewType = typeof(ContractorView);
            ListGridControl = ContractorsGridControl;
            MinimumSize = new Size(1000, 600);
            Name = "ContractorListView";
            Text = "Contractors";
            ((System.ComponentModel.ISupportInitialize)ContractorsGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContractorsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl ContractorsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ContractorsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn CodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn NameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TinGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CountryGridColumn;
        private DevExpress.XtraEditors.SimpleButton AddSimpleButton;
        private DevExpress.XtraEditors.SimpleButton EditSimpleButton;
        private DevExpress.XtraEditors.SimpleButton DeleteSimpleButton;
        private DevExpress.XtraEditors.SimpleButton GenerateSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ExportSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn AdressGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn KindGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn StatusGridColumn;
        private DevExpress.XtraEditors.SimpleButton GenerateReportSimpleButton;
    }
}