namespace PlatigeImage.View.WinForms
{
    partial class ContractorView
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
            CodeLabelControl = new DevExpress.XtraEditors.LabelControl();
            CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            ContractorBindingSource = new BindingSource(components);
            NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            NameLabelControl = new DevExpress.XtraEditors.LabelControl();
            TinLabelControl = new DevExpress.XtraEditors.LabelControl();
            TinPrefixComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            TinTextEdit = new DevExpress.XtraEditors.TextEdit();
            KindLabelControl = new DevExpress.XtraEditors.LabelControl();
            StatusLabelControl = new DevExpress.XtraEditors.LabelControl();
            RecipientCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            VendorCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            RelatedEntityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ActiveVatCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            InLiquidationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            AdressLabelControl = new DevExpress.XtraEditors.LabelControl();
            AdressTextEdit = new DevExpress.XtraEditors.TextEdit();
            CountryLabelControl = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            EMailTextEdit = new DevExpress.XtraEditors.TextEdit();
            ActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            CountryComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            KindLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            StatusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            GenerateReportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)CodeTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContractorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TinPrefixComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TinTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipientCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VendorCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RelatedEntityCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActiveVatCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InLiquidationCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdressTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EMailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActiveCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountryComboBoxEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KindLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusLookUpEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // SaveSimpleButton
            // 
            SaveSimpleButton.Location = new Point(291, 433);
            SaveSimpleButton.TabIndex = 25;
            // 
            // CancelSimpleButton
            // 
            CancelSimpleButton.Location = new Point(12, 433);
            CancelSimpleButton.TabIndex = 27;
            // 
            // CodeLabelControl
            // 
            CodeLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            CodeLabelControl.Appearance.Options.UseFont = true;
            CodeLabelControl.Location = new Point(12, 19);
            CodeLabelControl.Name = "CodeLabelControl";
            CodeLabelControl.Size = new Size(28, 13);
            CodeLabelControl.TabIndex = 1;
            CodeLabelControl.Text = "Code";
            // 
            // CodeTextEdit
            // 
            CodeTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CodeTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Code", true));
            CodeTextEdit.Location = new Point(12, 38);
            CodeTextEdit.Name = "CodeTextEdit";
            CodeTextEdit.Size = new Size(354, 20);
            CodeTextEdit.TabIndex = 2;
            CodeTextEdit.InvalidValue += CodeTextEdit_InvalidValue;
            CodeTextEdit.Validating += CodeTextEdit_Validating;
            // 
            // ContractorBindingSource
            // 
            ContractorBindingSource.DataSource = typeof(ContractorVM);
            // 
            // NameTextEdit
            // 
            NameTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Name", true));
            NameTextEdit.Location = new Point(12, 83);
            NameTextEdit.Name = "NameTextEdit";
            NameTextEdit.Size = new Size(354, 20);
            NameTextEdit.TabIndex = 4;
            // 
            // NameLabelControl
            // 
            NameLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabelControl.Appearance.Options.UseFont = true;
            NameLabelControl.Location = new Point(12, 64);
            NameLabelControl.Name = "NameLabelControl";
            NameLabelControl.Size = new Size(32, 13);
            NameLabelControl.TabIndex = 3;
            NameLabelControl.Text = "Name";
            // 
            // TinLabelControl
            // 
            TinLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TinLabelControl.Appearance.Options.UseFont = true;
            TinLabelControl.Location = new Point(12, 109);
            TinLabelControl.Name = "TinLabelControl";
            TinLabelControl.Size = new Size(19, 13);
            TinLabelControl.TabIndex = 5;
            TinLabelControl.Text = "TIN";
            // 
            // TinPrefixComboBoxEdit
            // 
            TinPrefixComboBoxEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "TinPrefix", true));
            TinPrefixComboBoxEdit.Location = new Point(12, 128);
            TinPrefixComboBoxEdit.Name = "TinPrefixComboBoxEdit";
            TinPrefixComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TinPrefixComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            TinPrefixComboBoxEdit.Size = new Size(60, 20);
            TinPrefixComboBoxEdit.TabIndex = 6;
            TinPrefixComboBoxEdit.EditValueChanged += TinPrefixComboBoxEdit_EditValueChanged;
            // 
            // TinTextEdit
            // 
            TinTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TinTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Tin", true));
            TinTextEdit.Location = new Point(78, 128);
            TinTextEdit.Name = "TinTextEdit";
            TinTextEdit.Size = new Size(288, 20);
            TinTextEdit.TabIndex = 7;
            TinTextEdit.InvalidValue += TinTextEdit_InvalidValue;
            TinTextEdit.Validating += TinTextEdit_Validating;
            // 
            // KindLabelControl
            // 
            KindLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            KindLabelControl.Appearance.Options.UseFont = true;
            KindLabelControl.Location = new Point(12, 154);
            KindLabelControl.Name = "KindLabelControl";
            KindLabelControl.Size = new Size(24, 13);
            KindLabelControl.TabIndex = 8;
            KindLabelControl.Text = "Kind";
            // 
            // StatusLabelControl
            // 
            StatusLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabelControl.Appearance.Options.UseFont = true;
            StatusLabelControl.Location = new Point(187, 154);
            StatusLabelControl.Name = "StatusLabelControl";
            StatusLabelControl.Size = new Size(37, 13);
            StatusLabelControl.TabIndex = 10;
            StatusLabelControl.Text = "Status";
            // 
            // RecipientCheckEdit
            // 
            RecipientCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Recipient", true));
            RecipientCheckEdit.Location = new Point(12, 199);
            RecipientCheckEdit.Name = "RecipientCheckEdit";
            RecipientCheckEdit.Properties.Caption = "Recipient";
            RecipientCheckEdit.Size = new Size(75, 20);
            RecipientCheckEdit.TabIndex = 12;
            // 
            // VendorCheckEdit
            // 
            VendorCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Vendor", true));
            VendorCheckEdit.Location = new Point(187, 199);
            VendorCheckEdit.Name = "VendorCheckEdit";
            VendorCheckEdit.Properties.Caption = "Vendor";
            VendorCheckEdit.Size = new Size(75, 20);
            VendorCheckEdit.TabIndex = 13;
            // 
            // RelatedEntityCheckEdit
            // 
            RelatedEntityCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "RelatedEntity", true));
            RelatedEntityCheckEdit.Location = new Point(12, 225);
            RelatedEntityCheckEdit.Name = "RelatedEntityCheckEdit";
            RelatedEntityCheckEdit.Properties.Caption = "Related Entity";
            RelatedEntityCheckEdit.Size = new Size(105, 20);
            RelatedEntityCheckEdit.TabIndex = 14;
            // 
            // ActiveVatCheckEdit
            // 
            ActiveVatCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "ActiveVat", true));
            ActiveVatCheckEdit.Location = new Point(187, 225);
            ActiveVatCheckEdit.Name = "ActiveVatCheckEdit";
            ActiveVatCheckEdit.Properties.Caption = "Active VAT Payer";
            ActiveVatCheckEdit.Size = new Size(105, 20);
            ActiveVatCheckEdit.TabIndex = 15;
            // 
            // InLiquidationCheckEdit
            // 
            InLiquidationCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "InLiquidation", true));
            InLiquidationCheckEdit.Location = new Point(12, 251);
            InLiquidationCheckEdit.Name = "InLiquidationCheckEdit";
            InLiquidationCheckEdit.Properties.Caption = "In Liquidation";
            InLiquidationCheckEdit.Size = new Size(105, 20);
            InLiquidationCheckEdit.TabIndex = 16;
            // 
            // AdressLabelControl
            // 
            AdressLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            AdressLabelControl.Appearance.Options.UseFont = true;
            AdressLabelControl.Location = new Point(12, 277);
            AdressLabelControl.Name = "AdressLabelControl";
            AdressLabelControl.Size = new Size(39, 13);
            AdressLabelControl.TabIndex = 17;
            AdressLabelControl.Text = "Adress";
            // 
            // AdressTextEdit
            // 
            AdressTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AdressTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Adress", true));
            AdressTextEdit.Location = new Point(12, 296);
            AdressTextEdit.Name = "AdressTextEdit";
            AdressTextEdit.Size = new Size(354, 20);
            AdressTextEdit.TabIndex = 18;
            // 
            // CountryLabelControl
            // 
            CountryLabelControl.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            CountryLabelControl.Appearance.Options.UseFont = true;
            CountryLabelControl.Location = new Point(12, 322);
            CountryLabelControl.Name = "CountryLabelControl";
            CountryLabelControl.Size = new Size(45, 13);
            CountryLabelControl.TabIndex = 19;
            CountryLabelControl.Text = "Country";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(12, 367);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(35, 13);
            labelControl1.TabIndex = 21;
            labelControl1.Text = "Phone";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(187, 367);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(29, 13);
            labelControl2.TabIndex = 23;
            labelControl2.Text = "EMail";
            // 
            // PhoneTextEdit
            // 
            PhoneTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Phone", true));
            PhoneTextEdit.Location = new Point(12, 386);
            PhoneTextEdit.Name = "PhoneTextEdit";
            PhoneTextEdit.Size = new Size(169, 20);
            PhoneTextEdit.TabIndex = 22;
            // 
            // EMailTextEdit
            // 
            EMailTextEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EMailTextEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "EMail", true));
            EMailTextEdit.Location = new Point(187, 386);
            EMailTextEdit.Name = "EMailTextEdit";
            EMailTextEdit.Size = new Size(179, 20);
            EMailTextEdit.TabIndex = 24;
            EMailTextEdit.InvalidValue += EMailTextEdit_InvalidValue;
            EMailTextEdit.Validating += EMailTextEdit_Validating;
            // 
            // ActiveCheckEdit
            // 
            ActiveCheckEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ActiveCheckEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Active", true));
            ActiveCheckEdit.Location = new Point(313, 12);
            ActiveCheckEdit.Name = "ActiveCheckEdit";
            ActiveCheckEdit.Properties.Caption = "Active";
            ActiveCheckEdit.Size = new Size(53, 20);
            ActiveCheckEdit.TabIndex = 0;
            // 
            // CountryComboBoxEdit
            // 
            CountryComboBoxEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CountryComboBoxEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Country", true));
            CountryComboBoxEdit.Location = new Point(12, 341);
            CountryComboBoxEdit.Name = "CountryComboBoxEdit";
            CountryComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CountryComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            CountryComboBoxEdit.Size = new Size(354, 20);
            CountryComboBoxEdit.TabIndex = 20;
            // 
            // KindLookUpEdit
            // 
            KindLookUpEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Kind", true));
            KindLookUpEdit.Location = new Point(12, 173);
            KindLookUpEdit.Name = "KindLookUpEdit";
            KindLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            KindLookUpEdit.Properties.NullText = "";
            KindLookUpEdit.Properties.PopupSizeable = false;
            KindLookUpEdit.Properties.ShowFooter = false;
            KindLookUpEdit.Properties.ShowHeader = false;
            KindLookUpEdit.Size = new Size(169, 20);
            KindLookUpEdit.TabIndex = 9;
            // 
            // StatusLookUpEdit
            // 
            StatusLookUpEdit.DataBindings.Add(new Binding("EditValue", ContractorBindingSource, "Status", true));
            StatusLookUpEdit.Location = new Point(187, 173);
            StatusLookUpEdit.Name = "StatusLookUpEdit";
            StatusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            StatusLookUpEdit.Properties.NullText = "";
            StatusLookUpEdit.Properties.PopupSizeable = false;
            StatusLookUpEdit.Properties.ShowFooter = false;
            StatusLookUpEdit.Properties.ShowHeader = false;
            StatusLookUpEdit.Size = new Size(179, 20);
            StatusLookUpEdit.TabIndex = 11;
            // 
            // GenerateReportSimpleButton
            // 
            GenerateReportSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateReportSimpleButton.Location = new Point(175, 433);
            GenerateReportSimpleButton.Name = "GenerateReportSimpleButton";
            GenerateReportSimpleButton.Size = new Size(110, 23);
            GenerateReportSimpleButton.TabIndex = 26;
            GenerateReportSimpleButton.Text = "Generate report";
            GenerateReportSimpleButton.Click += GenerateReportSimpleButton_Click;
            // 
            // ContractorView
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 468);
            Controls.Add(GenerateReportSimpleButton);
            Controls.Add(CountryComboBoxEdit);
            Controls.Add(ActiveCheckEdit);
            Controls.Add(EMailTextEdit);
            Controls.Add(PhoneTextEdit);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(CountryLabelControl);
            Controls.Add(AdressTextEdit);
            Controls.Add(AdressLabelControl);
            Controls.Add(InLiquidationCheckEdit);
            Controls.Add(ActiveVatCheckEdit);
            Controls.Add(RelatedEntityCheckEdit);
            Controls.Add(VendorCheckEdit);
            Controls.Add(RecipientCheckEdit);
            Controls.Add(StatusLabelControl);
            Controls.Add(KindLabelControl);
            Controls.Add(TinTextEdit);
            Controls.Add(TinPrefixComboBoxEdit);
            Controls.Add(TinLabelControl);
            Controls.Add(NameTextEdit);
            Controls.Add(NameLabelControl);
            Controls.Add(CodeTextEdit);
            Controls.Add(CodeLabelControl);
            Controls.Add(KindLookUpEdit);
            Controls.Add(StatusLookUpEdit);
            MinimumSize = new Size(380, 500);
            Name = "ContractorView";
            Text = "Contractor";
            Controls.SetChildIndex(SaveSimpleButton, 0);
            Controls.SetChildIndex(CancelSimpleButton, 0);
            Controls.SetChildIndex(StatusLookUpEdit, 0);
            Controls.SetChildIndex(KindLookUpEdit, 0);
            Controls.SetChildIndex(CodeLabelControl, 0);
            Controls.SetChildIndex(CodeTextEdit, 0);
            Controls.SetChildIndex(NameLabelControl, 0);
            Controls.SetChildIndex(NameTextEdit, 0);
            Controls.SetChildIndex(TinLabelControl, 0);
            Controls.SetChildIndex(TinPrefixComboBoxEdit, 0);
            Controls.SetChildIndex(TinTextEdit, 0);
            Controls.SetChildIndex(KindLabelControl, 0);
            Controls.SetChildIndex(StatusLabelControl, 0);
            Controls.SetChildIndex(RecipientCheckEdit, 0);
            Controls.SetChildIndex(VendorCheckEdit, 0);
            Controls.SetChildIndex(RelatedEntityCheckEdit, 0);
            Controls.SetChildIndex(ActiveVatCheckEdit, 0);
            Controls.SetChildIndex(InLiquidationCheckEdit, 0);
            Controls.SetChildIndex(AdressLabelControl, 0);
            Controls.SetChildIndex(AdressTextEdit, 0);
            Controls.SetChildIndex(CountryLabelControl, 0);
            Controls.SetChildIndex(labelControl1, 0);
            Controls.SetChildIndex(labelControl2, 0);
            Controls.SetChildIndex(PhoneTextEdit, 0);
            Controls.SetChildIndex(EMailTextEdit, 0);
            Controls.SetChildIndex(ActiveCheckEdit, 0);
            Controls.SetChildIndex(CountryComboBoxEdit, 0);
            Controls.SetChildIndex(GenerateReportSimpleButton, 0);
            ((System.ComponentModel.ISupportInitialize)CodeTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContractorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TinPrefixComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TinTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipientCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)VendorCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)RelatedEntityCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActiveVatCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InLiquidationCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdressTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EMailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActiveCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountryComboBoxEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)KindLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusLookUpEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl CodeLabelControl;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.LabelControl NameLabelControl;
        private DevExpress.XtraEditors.LabelControl TinLabelControl;
        private DevExpress.XtraEditors.ComboBoxEdit TinPrefixComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit TinTextEdit;
        private DevExpress.XtraEditors.LabelControl KindLabelControl;
        private DevExpress.XtraEditors.LabelControl StatusLabelControl;
        private DevExpress.XtraEditors.CheckEdit RecipientCheckEdit;
        private DevExpress.XtraEditors.CheckEdit VendorCheckEdit;
        private DevExpress.XtraEditors.CheckEdit RelatedEntityCheckEdit;
        private DevExpress.XtraEditors.CheckEdit ActiveVatCheckEdit;
        private DevExpress.XtraEditors.CheckEdit InLiquidationCheckEdit;
        private DevExpress.XtraEditors.LabelControl AdressLabelControl;
        private DevExpress.XtraEditors.TextEdit AdressTextEdit;
        private DevExpress.XtraEditors.LabelControl CountryLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EMailTextEdit;
        private DevExpress.XtraEditors.CheckEdit ActiveCheckEdit;
        private DevExpress.XtraEditors.ComboBoxEdit CountryComboBoxEdit;
        private DevExpress.XtraEditors.LookUpEdit KindLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit StatusLookUpEdit;
        private BindingSource ContractorBindingSource;
        private DevExpress.XtraEditors.SimpleButton GenerateReportSimpleButton;
    }
}