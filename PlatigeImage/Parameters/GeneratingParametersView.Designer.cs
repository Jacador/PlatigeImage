namespace PlatigeImage.View.WinForms
{
    partial class GeneratingParametersView
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
            CountLabelControl = new DevExpress.XtraEditors.LabelControl();
            CountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            GenerateSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)CountSpinEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // CountLabelControl
            // 
            CountLabelControl.Location = new Point(12, 35);
            CountLabelControl.Name = "CountLabelControl";
            CountLabelControl.Size = new Size(152, 13);
            CountLabelControl.TabIndex = 0;
            CountLabelControl.Text = "Number of objects to generate:";
            // 
            // CountSpinEdit
            // 
            CountSpinEdit.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            CountSpinEdit.Location = new Point(170, 32);
            CountSpinEdit.Name = "CountSpinEdit";
            CountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CountSpinEdit.Properties.MaskSettings.Set("mask", "d");
            CountSpinEdit.Properties.MaxValue = new decimal(new int[] { 10000, 0, 0, 0 });
            CountSpinEdit.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            CountSpinEdit.Size = new Size(96, 20);
            CountSpinEdit.TabIndex = 1;
            // 
            // GenerateSimpleButton
            // 
            GenerateSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GenerateSimpleButton.DialogResult = DialogResult.OK;
            GenerateSimpleButton.Location = new Point(191, 83);
            GenerateSimpleButton.Name = "GenerateSimpleButton";
            GenerateSimpleButton.Size = new Size(75, 23);
            GenerateSimpleButton.TabIndex = 2;
            GenerateSimpleButton.Text = "Generate";
            GenerateSimpleButton.Click += GenerateSimpleButton_Click;
            // 
            // GeneratingParametersView
            // 
            AcceptButton = GenerateSimpleButton;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 118);
            Controls.Add(GenerateSimpleButton);
            Controls.Add(CountSpinEdit);
            Controls.Add(CountLabelControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GeneratingParametersView";
            Text = "Generating parameters";
            ((System.ComponentModel.ISupportInitialize)CountSpinEdit.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl CountLabelControl;
        private DevExpress.XtraEditors.SpinEdit CountSpinEdit;
        private DevExpress.XtraEditors.SimpleButton GenerateSimpleButton;
    }
}