using DevExpress.Data.WizardFramework;
using DevExpress.Xpf.Core.Native;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using PlatigeImage.DataAccess;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Presenters;
using PlatigeImage.View.Utils;
using PlatigeImage.View.WinForms.Extensions;

namespace PlatigeImage.View.WinForms
{
    public partial class MainView : RibbonForm, IMainView
    {
        private MainPresenter _presenter;
        public MainView()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ViewManager.RegisterRootView(this);

            CheckToDisableRibbonGroups();
            CheckToRunConnectionDatabaseWizard();

#if DEBUG
            ReportsRibbonPageGroup.Visible = true;
            CreateReportBarButtonItem.Visibility = BarItemVisibility.Always;
#endif
        }

        private void ConnectToDbBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunConnectionDatabaseWizard();
        }

        private void ContractorsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ContractorListView view = new ContractorListView();
            view.ShowModal(this);
        }

        private void InvoiceBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceListView view = new InvoiceListView();
            view.ShowModal(this);
        }

        private void WizardOnClosed(object? sender, EventArgs e)
        {
            CheckToDisableRibbonGroups();
        }

        private void CheckToRunConnectionDatabaseWizard()
        {
            if (!_presenter.ConnectionStringWorks())
                RunConnectionDatabaseWizard();
        }

        private void RunConnectionDatabaseWizard()
        {
            ConnectDatabaseWizard wizard = new ConnectDatabaseWizard();
            wizard.Closed += WizardOnClosed;
            wizard.ShowModalDialog(this);
        }

        private void CheckToDisableRibbonGroups()
        {
            if (_presenter.ConnectionStringWorks())
            {
                Ribbon.EnableRibbonGroups(DatabaseRibbonPageGroup);
            }
            else
            {
                Ribbon.DisableRibbonGroups(DatabaseRibbonPageGroup);
            }
        }

        private void CreateReportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportCreatorView creator = new ReportCreatorView();
            creator.Show();
        }
    }
}