namespace PlatigeImage.View.WinForms
{
    partial class ConnectDatabaseWizard
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
            WizardControl = new DevExpress.XtraWizard.WizardControl();
            WelcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            ServerWizardPage = new DevExpress.XtraWizard.WizardPage();
            CredentialsGroupControl = new DevExpress.XtraEditors.GroupControl();
            PasswordLabelControl = new DevExpress.XtraEditors.LabelControl();
            LoginLabelControl = new DevExpress.XtraEditors.LabelControl();
            PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            LoginTextEdit = new DevExpress.XtraEditors.TextEdit();
            CredentialsRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            ServerComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ServerLabelControl = new DevExpress.XtraEditors.LabelControl();
            CompletionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            DatabaseWizardPage = new DevExpress.XtraWizard.WizardPage();
            DatabaseComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            DatabaseLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)WizardControl).BeginInit();
            WizardControl.SuspendLayout();
            ServerWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CredentialsGroupControl).BeginInit();
            CredentialsGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CredentialsRadioGroup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServerComboBoxEdit.Properties).BeginInit();
            DatabaseWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatabaseComboBoxEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // WizardControl
            // 
            WizardControl.Controls.Add(WelcomeWizardPage);
            WizardControl.Controls.Add(ServerWizardPage);
            WizardControl.Controls.Add(CompletionWizardPage);
            WizardControl.Controls.Add(DatabaseWizardPage);
            WizardControl.Dock = DockStyle.Fill;
            WizardControl.Name = "WizardControl";
            WizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] { WelcomeWizardPage, ServerWizardPage, DatabaseWizardPage, CompletionWizardPage });
            WizardControl.Size = new Size(455, 383);
            WizardControl.Text = "Connect to Database";
            WizardControl.SelectedPageChanging += WizardControl_SelectedPageChanging;
            WizardControl.CancelClick += WizardControl_CancelClick;
            WizardControl.FinishClick += WizardControl_FinishClick;
            // 
            // WelcomeWizardPage
            // 
            WelcomeWizardPage.IntroductionText = "This wizard will allow you to connect to the selected server and the database located on it.\r\n\r\nIf the database does not exist, a new one will be created.";
            WelcomeWizardPage.Name = "WelcomeWizardPage";
            WelcomeWizardPage.Size = new Size(238, 228);
            WelcomeWizardPage.Text = "Welcome to the connection wizard";
            // 
            // ServerWizardPage
            // 
            ServerWizardPage.Controls.Add(CredentialsGroupControl);
            ServerWizardPage.Controls.Add(ServerComboBoxEdit);
            ServerWizardPage.Controls.Add(ServerLabelControl);
            ServerWizardPage.DescriptionText = "Select the MS SQL server from the list or enter the name of the server you want to connect to";
            ServerWizardPage.Name = "ServerWizardPage";
            ServerWizardPage.Size = new Size(423, 240);
            ServerWizardPage.Text = "Connect to Server";
            // 
            // CredentialsGroupControl
            // 
            CredentialsGroupControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CredentialsGroupControl.Controls.Add(PasswordLabelControl);
            CredentialsGroupControl.Controls.Add(LoginLabelControl);
            CredentialsGroupControl.Controls.Add(PasswordTextEdit);
            CredentialsGroupControl.Controls.Add(LoginTextEdit);
            CredentialsGroupControl.Controls.Add(CredentialsRadioGroup);
            CredentialsGroupControl.Location = new Point(11, 51);
            CredentialsGroupControl.Name = "CredentialsGroupControl";
            CredentialsGroupControl.Size = new Size(399, 186);
            CredentialsGroupControl.TabIndex = 2;
            CredentialsGroupControl.Text = "Enter credientials";
            // 
            // PasswordLabelControl
            // 
            PasswordLabelControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PasswordLabelControl.Location = new Point(87, 164);
            PasswordLabelControl.Name = "PasswordLabelControl";
            PasswordLabelControl.Size = new Size(50, 13);
            PasswordLabelControl.TabIndex = 7;
            PasswordLabelControl.Text = "Password:";
            // 
            // LoginLabelControl
            // 
            LoginLabelControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginLabelControl.Location = new Point(87, 138);
            LoginLabelControl.Name = "LoginLabelControl";
            LoginLabelControl.Size = new Size(29, 13);
            LoginLabelControl.TabIndex = 6;
            LoginLabelControl.Text = "Login:";
            // 
            // PasswordTextEdit
            // 
            PasswordTextEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PasswordTextEdit.Enabled = false;
            PasswordTextEdit.Location = new Point(143, 161);
            PasswordTextEdit.Name = "PasswordTextEdit";
            PasswordTextEdit.Properties.PasswordChar = '*';
            PasswordTextEdit.Size = new Size(251, 20);
            PasswordTextEdit.TabIndex = 5;
            // 
            // LoginTextEdit
            // 
            LoginTextEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginTextEdit.Enabled = false;
            LoginTextEdit.Location = new Point(143, 135);
            LoginTextEdit.Name = "LoginTextEdit";
            LoginTextEdit.Size = new Size(251, 20);
            LoginTextEdit.TabIndex = 4;
            // 
            // CredentialsRadioGroup
            // 
            CredentialsRadioGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CredentialsRadioGroup.EditValue = true;
            CredentialsRadioGroup.Location = new Point(5, 26);
            CredentialsRadioGroup.Name = "CredentialsRadioGroup";
            CredentialsRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "authorization via NT domain", true, null, "NTAuthorization"), new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "authorization on SQL server", true, null, "ServerAuthorization") });
            CredentialsRadioGroup.Size = new Size(389, 103);
            CredentialsRadioGroup.TabIndex = 3;
            CredentialsRadioGroup.SelectedIndexChanged += CredentialsRadioGroup_SelectedIndexChanged;
            // 
            // ServerComboBoxEdit
            // 
            ServerComboBoxEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ServerComboBoxEdit.Location = new Point(160, 25);
            ServerComboBoxEdit.Name = "ServerComboBoxEdit";
            ServerComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ServerComboBoxEdit.Size = new Size(250, 20);
            ServerComboBoxEdit.TabIndex = 1;
            ServerComboBoxEdit.TextChanged += ServerComboBoxEdit_TextChanged;
            // 
            // ServerLabelControl
            // 
            ServerLabelControl.Location = new Point(11, 28);
            ServerLabelControl.Name = "ServerLabelControl";
            ServerLabelControl.Size = new Size(75, 13);
            ServerLabelControl.TabIndex = 0;
            ServerLabelControl.Text = "Server MS SQL:";
            // 
            // CompletionWizardPage
            // 
            CompletionWizardPage.Name = "CompletionWizardPage";
            CompletionWizardPage.Size = new Size(238, 251);
            // 
            // DatabaseWizardPage
            // 
            DatabaseWizardPage.Controls.Add(DatabaseComboBoxEdit);
            DatabaseWizardPage.Controls.Add(DatabaseLabelControl);
            DatabaseWizardPage.DescriptionText = "Select the MS SQL database from the list or enter the name of the database you want to connect to";
            DatabaseWizardPage.Name = "DatabaseWizardPage";
            DatabaseWizardPage.Size = new Size(423, 240);
            DatabaseWizardPage.Text = "Connect to Database";
            // 
            // DatabaseComboBoxEdit
            // 
            DatabaseComboBoxEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DatabaseComboBoxEdit.Location = new Point(161, 110);
            DatabaseComboBoxEdit.Name = "DatabaseComboBoxEdit";
            DatabaseComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DatabaseComboBoxEdit.Size = new Size(250, 20);
            DatabaseComboBoxEdit.TabIndex = 3;
            DatabaseComboBoxEdit.TextChanged += DatabaseComboBoxEdit_TextChanged;
            // 
            // DatabaseLabelControl
            // 
            DatabaseLabelControl.Location = new Point(12, 113);
            DatabaseLabelControl.Name = "DatabaseLabelControl";
            DatabaseLabelControl.Size = new Size(89, 13);
            DatabaseLabelControl.TabIndex = 2;
            DatabaseLabelControl.Text = "Database MS SQL:";
            // 
            // ConnectDatabaseWizard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 383);
            Controls.Add(WizardControl);
            Name = "ConnectDatabaseWizard";
            Text = "Connect to Database";
            ((System.ComponentModel.ISupportInitialize)WizardControl).EndInit();
            WizardControl.ResumeLayout(false);
            ServerWizardPage.ResumeLayout(false);
            ServerWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CredentialsGroupControl).EndInit();
            CredentialsGroupControl.ResumeLayout(false);
            CredentialsGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CredentialsRadioGroup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServerComboBoxEdit.Properties).EndInit();
            DatabaseWizardPage.ResumeLayout(false);
            DatabaseWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatabaseComboBoxEdit.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraWizard.WizardControl WizardControl;
        private DevExpress.XtraWizard.WelcomeWizardPage WelcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage ServerWizardPage;
        private DevExpress.XtraWizard.CompletionWizardPage CompletionWizardPage;
        private DevExpress.XtraEditors.LabelControl ServerLabelControl;
        private DevExpress.XtraEditors.ComboBoxEdit ServerComboBoxEdit;
        private DevExpress.XtraEditors.RadioGroup CredentialsRadioGroup;
        private DevExpress.XtraEditors.GroupControl CredentialsGroupControl;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit LoginTextEdit;
        private DevExpress.XtraEditors.LabelControl PasswordLabelControl;
        private DevExpress.XtraEditors.LabelControl LoginLabelControl;
        private DevExpress.XtraWizard.WizardPage DatabaseWizardPage;
        private DevExpress.XtraEditors.ComboBoxEdit DatabaseComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl DatabaseLabelControl;
    }
}