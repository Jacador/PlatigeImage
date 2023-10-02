using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Presenters;
using PlatigeImage.View.WinForms.Extensions;

namespace PlatigeImage.View.WinForms
{
    public partial class ConnectDatabaseWizard : XtraForm, IConnectDatabaseWizard
    {
        private ConnectDatabaseWizardPresenter _presenter;

        public ConnectDatabaseWizard()
        {
            InitializeComponent();
            _presenter = new ConnectDatabaseWizardPresenter(this);
        }

        public string ServerName => ServerComboBoxEdit.Text;
        public string Login => LoginTextEdit.Text;
        public string Password => PasswordTextEdit.Text;
        public bool TrustedConnection => CredentialsRadioGroup.SelectedIndex == 0;
        public string DatabaseName => DatabaseComboBoxEdit.Text;

        private void CredentialsRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginTextEdit.Enabled = !TrustedConnection;
            PasswordTextEdit.Enabled = !TrustedConnection;
        }

        private void ServerComboBoxEdit_TextChanged(object sender, EventArgs e)
        {
            ServerWizardPage.AllowNext = ServerName.Length > 0;
        }

        private void DatabaseComboBoxEdit_TextChanged(object sender, EventArgs e)
        {
            DatabaseWizardPage.AllowNext = DatabaseName.Length > 0;
        }

        private void WizardControl_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Direction == Direction.Forward)
            {
                if (e.PrevPage == WelcomeWizardPage)
                {
                    PopulateServersList();
                }
                else if (e.PrevPage == ServerWizardPage)
                {
                    if (_presenter.CheckSqlServer() == 1)
                        PopulateDatabasesList();
                    else
                    {
                        XtraMessageBox.Show(_presenter.ErrorMessage, "Error", MessageBoxButtons.OK);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void PopulateServersList()
        {
            List<string> servers = _presenter.GetServers();
            ServerComboBoxEdit.Populate(servers);
        }

        private void PopulateDatabasesList()
        {
            List<string> databases = _presenter.GetDatabases();
            DatabaseComboBoxEdit.Populate(databases);
        }

        private void WizardControl_FinishClick(object sender, CancelEventArgs e)
        {
            _presenter.SaveConnectionString();
            _presenter.CreateDatabaseTables();

            Close();
        }

        private void WizardControl_CancelClick(object sender, CancelEventArgs e)
        {
            Close();
        }
    }
}
