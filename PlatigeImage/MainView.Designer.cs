namespace PlatigeImage.View.WinForms
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            MainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ConnectToDbBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ContractorsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            InvoicesButtonItem = new DevExpress.XtraBars.BarButtonItem();
            InvoicesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            CreateReportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            MenuRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            DatabaseRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ContractorsInvoicesRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ReportsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)MainRibbonControl).BeginInit();
            SuspendLayout();
            // 
            // MainRibbonControl
            // 
            MainRibbonControl.ExpandCollapseItem.Id = 0;
            MainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { MainRibbonControl.ExpandCollapseItem, MainRibbonControl.SearchEditItem, ConnectToDbBarButtonItem, ContractorsBarButtonItem, InvoicesButtonItem, InvoicesBarButtonItem, CreateReportBarButtonItem });
            MainRibbonControl.Location = new Point(0, 0);
            MainRibbonControl.MaxItemId = 9;
            MainRibbonControl.Name = "MainRibbonControl";
            MainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { MenuRibbonPage });
            MainRibbonControl.Size = new Size(1598, 158);
            // 
            // ConnectToDbBarButtonItem
            // 
            ConnectToDbBarButtonItem.Caption = "Connect";
            ConnectToDbBarButtonItem.Id = 1;
            ConnectToDbBarButtonItem.ImageOptions.Image = (Image)resources.GetObject("ConnectToDbBarButtonItem.ImageOptions.Image");
            ConnectToDbBarButtonItem.ImageOptions.LargeImage = (Image)resources.GetObject("ConnectToDbBarButtonItem.ImageOptions.LargeImage");
            ConnectToDbBarButtonItem.Name = "ConnectToDbBarButtonItem";
            ConnectToDbBarButtonItem.ItemClick += ConnectToDbBarButtonItem_ItemClick;
            // 
            // ContractorsBarButtonItem
            // 
            ContractorsBarButtonItem.Caption = "Contractors";
            ContractorsBarButtonItem.Id = 2;
            ContractorsBarButtonItem.ImageOptions.Image = (Image)resources.GetObject("ContractorsBarButtonItem.ImageOptions.Image");
            ContractorsBarButtonItem.ImageOptions.LargeImage = (Image)resources.GetObject("ContractorsBarButtonItem.ImageOptions.LargeImage");
            ContractorsBarButtonItem.Name = "ContractorsBarButtonItem";
            ContractorsBarButtonItem.ItemClick += ContractorsBarButtonItem_ItemClick;
            // 
            // InvoicesButtonItem
            // 
            InvoicesButtonItem.Caption = "Invoices";
            InvoicesButtonItem.Id = 3;
            InvoicesButtonItem.ImageOptions.Image = (Image)resources.GetObject("InvoicesButtonItem.ImageOptions.Image");
            InvoicesButtonItem.ImageOptions.LargeImage = (Image)resources.GetObject("InvoicesButtonItem.ImageOptions.LargeImage");
            InvoicesButtonItem.Name = "InvoicesButtonItem";
            // 
            // InvoicesBarButtonItem
            // 
            InvoicesBarButtonItem.Caption = "Invoices";
            InvoicesBarButtonItem.Id = 7;
            InvoicesBarButtonItem.ImageOptions.Image = (Image)resources.GetObject("InvoicesBarButtonItem.ImageOptions.Image");
            InvoicesBarButtonItem.ImageOptions.LargeImage = (Image)resources.GetObject("InvoicesBarButtonItem.ImageOptions.LargeImage");
            InvoicesBarButtonItem.Name = "InvoicesBarButtonItem";
            InvoicesBarButtonItem.ItemClick += InvoiceBarButtonItem_ItemClick;
            // 
            // CreateReportBarButtonItem
            // 
            CreateReportBarButtonItem.Caption = "Create";
            CreateReportBarButtonItem.Id = 8;
            CreateReportBarButtonItem.Name = "CreateReportBarButtonItem";
            CreateReportBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            CreateReportBarButtonItem.ItemClick += CreateReportBarButtonItem_ItemClick;
            // 
            // MenuRibbonPage
            // 
            MenuRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { DatabaseRibbonPageGroup, ContractorsInvoicesRibbonPageGroup, ReportsRibbonPageGroup });
            MenuRibbonPage.Name = "MenuRibbonPage";
            MenuRibbonPage.Text = "Menu";
            // 
            // DatabaseRibbonPageGroup
            // 
            DatabaseRibbonPageGroup.ItemLinks.Add(ConnectToDbBarButtonItem);
            DatabaseRibbonPageGroup.Name = "DatabaseRibbonPageGroup";
            DatabaseRibbonPageGroup.Text = "Database";
            // 
            // ContractorsInvoicesRibbonPageGroup
            // 
            ContractorsInvoicesRibbonPageGroup.ItemLinks.Add(ContractorsBarButtonItem);
            ContractorsInvoicesRibbonPageGroup.ItemLinks.Add(InvoicesBarButtonItem);
            ContractorsInvoicesRibbonPageGroup.Name = "ContractorsInvoicesRibbonPageGroup";
            // 
            // ReportsRibbonPageGroup
            // 
            ReportsRibbonPageGroup.ItemLinks.Add(CreateReportBarButtonItem);
            ReportsRibbonPageGroup.Name = "ReportsRibbonPageGroup";
            ReportsRibbonPageGroup.Text = "Reports";
            ReportsRibbonPageGroup.Visible = false;
            // 
            // MainView
            // 
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 899);
            Controls.Add(MainRibbonControl);
            IsMdiContainer = true;
            Name = "MainView";
            Ribbon = MainRibbonControl;
            Text = "Platige Image";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)MainRibbonControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage MenuRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DatabaseRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ContractorsInvoicesRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ConnectToDbBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ContractorsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem InvoicesButtonItem;
        private DevExpress.XtraBars.BarButtonItem InvoicesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem CreateReportBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ReportsRibbonPageGroup;
    }
}