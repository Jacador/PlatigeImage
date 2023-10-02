namespace PlatigeImage.View.WinForms
{
    partial class EditView
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
            SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // SaveSimpleButton
            // 
            SaveSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveSimpleButton.Location = new Point(291, 493);
            SaveSimpleButton.Name = "SaveSimpleButton";
            SaveSimpleButton.Size = new Size(75, 23);
            SaveSimpleButton.TabIndex = 0;
            SaveSimpleButton.Text = "Save";
            SaveSimpleButton.Click += SaveSimpleButton_Click;
            // 
            // CancelSimpleButton
            // 
            CancelSimpleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CancelSimpleButton.Location = new Point(12, 493);
            CancelSimpleButton.Name = "CancelSimpleButton";
            CancelSimpleButton.Size = new Size(75, 23);
            CancelSimpleButton.TabIndex = 1;
            CancelSimpleButton.Text = "Cancel";
            CancelSimpleButton.Click += CancelSimpleButton_Click;
            // 
            // EditView
            // 
            AcceptButton = SaveSimpleButton;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelSimpleButton;
            ClientSize = new Size(378, 528);
            Controls.Add(CancelSimpleButton);
            Controls.Add(SaveSimpleButton);
            Name = "EditView";
            Text = "EditView";
            Validating += EditView_Validating;
            ResumeLayout(false);
        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        protected DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
    }
}