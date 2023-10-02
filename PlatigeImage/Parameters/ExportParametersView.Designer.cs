namespace PlatigeImage.View.WinForms
{
    partial class ExportParametersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportParametersView));
            PathLabelControl = new DevExpress.XtraEditors.LabelControl();
            ExportSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            PathTextEdit = new DevExpress.XtraEditors.TextEdit();
            ExportSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(components);
            SelectPathSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            OpenFileCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)PathTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpenFileCheckEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // PathLabelControl
            // 
            PathLabelControl.Location = new Point(12, 35);
            PathLabelControl.Name = "PathLabelControl";
            PathLabelControl.Size = new Size(74, 13);
            PathLabelControl.TabIndex = 0;
            PathLabelControl.Text = "Path to export:";
            // 
            // ExportSimpleButton
            // 
            ExportSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExportSimpleButton.DialogResult = DialogResult.OK;
            ExportSimpleButton.Enabled = false;
            ExportSimpleButton.Location = new Point(288, 107);
            ExportSimpleButton.Name = "ExportSimpleButton";
            ExportSimpleButton.Size = new Size(75, 23);
            ExportSimpleButton.TabIndex = 4;
            ExportSimpleButton.Text = "Export";
            ExportSimpleButton.Click += GenerateSimpleButton_Click;
            // 
            // PathTextEdit
            // 
            PathTextEdit.Location = new Point(12, 54);
            PathTextEdit.Name = "PathTextEdit";
            PathTextEdit.Properties.ReadOnly = true;
            PathTextEdit.Size = new Size(325, 20);
            PathTextEdit.TabIndex = 1;
            PathTextEdit.TextChanged += PathTextEdit_TextChanged;
            // 
            // ExportSaveFileDialog
            // 
            ExportSaveFileDialog.DefaultExt = "XML";
            ExportSaveFileDialog.FileName = "Export";
            ExportSaveFileDialog.Filter = "XML File|*.xml|CSV File|*.csv";
            // 
            // SelectPathSimpleButton
            // 
            SelectPathSimpleButton.ImageOptions.Image = (Image)resources.GetObject("SelectPathSimpleButton.ImageOptions.Image");
            SelectPathSimpleButton.Location = new Point(343, 54);
            SelectPathSimpleButton.Name = "SelectPathSimpleButton";
            SelectPathSimpleButton.Size = new Size(20, 20);
            SelectPathSimpleButton.TabIndex = 2;
            SelectPathSimpleButton.Click += SelectPathSimpleButton_Click;
            // 
            // OpenFileCheckEdit
            // 
            OpenFileCheckEdit.EditValue = true;
            OpenFileCheckEdit.Location = new Point(12, 80);
            OpenFileCheckEdit.Name = "OpenFileCheckEdit";
            OpenFileCheckEdit.Properties.Caption = "Open file after export";
            OpenFileCheckEdit.Size = new Size(136, 20);
            OpenFileCheckEdit.TabIndex = 3;
            // 
            // ExportParametersView
            // 
            AcceptButton = ExportSimpleButton;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 142);
            Controls.Add(OpenFileCheckEdit);
            Controls.Add(SelectPathSimpleButton);
            Controls.Add(PathTextEdit);
            Controls.Add(ExportSimpleButton);
            Controls.Add(PathLabelControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportParametersView";
            Text = "Export parameters";
            ((System.ComponentModel.ISupportInitialize)PathTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpenFileCheckEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl PathLabelControl;
        private DevExpress.XtraEditors.SimpleButton ExportSimpleButton;
        private DevExpress.XtraEditors.TextEdit PathTextEdit;
        private DevExpress.XtraEditors.XtraSaveFileDialog ExportSaveFileDialog;
        private DevExpress.XtraEditors.SimpleButton SelectPathSimpleButton;
        private DevExpress.XtraEditors.CheckEdit OpenFileCheckEdit;
    }
}