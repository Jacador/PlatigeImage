using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.View.Interfaces.Presenters;
using PlatigeImage.View.Interfaces.Common;
using PlatigeImage.View.WinForms.Extensions;
using log4net;

namespace PlatigeImage.View.WinForms
{
    public partial class ListView : XtraForm, IListView
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(ListView));
        private IListPresenter? _presenter;

        private GridControl? _listGridControl;
        private Type? _editViewType;

        private SimpleButton? _addButton;
        private SimpleButton? _editButton;
        private SimpleButton? _deleteButton;

        public ListView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ListGridControl != null)
            {
                ListGridControl.DataSource = _presenter?.LoadDataSource();
            }
            
        }

        protected void AttachPresenter(IListPresenter presenter)
        {
            _presenter = presenter;
        }
        
        public GridControl? ListGridControl
        {
            get { return _listGridControl; }
            set
            {
                if (_listGridControl != null)
                {
                    if (_listGridControl.MainView is GridView listGridView)
                    {
                        listGridView.DataSourceChanged -= ListGridView_DataSourceChanged;
                        listGridView.ColumnFilterChanged -= ListGridView_ColumnFilterChanged;
                    }
                }

                _listGridControl = value;

                if (_listGridControl != null)
                {
                    if (_listGridControl.MainView is GridView listGridView)
                    {
                        listGridView.DataSourceChanged += ListGridView_DataSourceChanged;
                        listGridView.ColumnFilterChanged += ListGridView_ColumnFilterChanged;
                    }
                }
            }
        }

        public GridView? ListGridView => ListGridControl?.MainView as GridView;

        public SimpleButton? AddButton
        {
            get { return _addButton; }
            set  {
                if (_addButton != null)
                {
                    _addButton.Click -= AddButtonOnClick;
                }

                _addButton = value;

                if (_addButton != null)
                {
                    _addButton.Click += AddButtonOnClick;
                }
            }
        }

        public SimpleButton? EditButton
        {
            get { return _editButton; }
            set
            {
                if (_editButton != null)
                {
                    _editButton.Click -= EditButtonOnClick;
                }

                _editButton = value;

                if (_editButton != null)
                {
                    _editButton.Click += EditButtonOnClick;
                }
            }
        }

        public SimpleButton? DeleteButton
        {
            get { return _deleteButton; }
            set
            {
                if (_deleteButton != null)
                {
                    _deleteButton.Click -= DeleteButtonOnClick;
                }

                _deleteButton = value;

                if (_deleteButton != null)
                {
                    _deleteButton.Click += DeleteButtonOnClick;
                }
            }
        }

        public Type? EditViewType
        {
            get { return _editViewType; }
            set { _editViewType = value; }
        }

        private void AddButtonOnClick(object? sender, EventArgs e)
        {
            Add();
        }

        private void EditButtonOnClick(object? sender, EventArgs e)
        {
            Edit();
        }

        private void DeleteButtonOnClick(object? sender, EventArgs e)
        {
            Delete();
        }

        private void ListGridView_ColumnFilterChanged(object? sender, EventArgs e)
        {
            SetButtons();
        }

        private void ListGridView_DataSourceChanged(object? sender, EventArgs e)
        {
            SetButtons();
        }

        private void Add()
        {
            EditView view = (EditView)ViewManager.CreateView(EditViewType);
            view.Closed += (o, args) => RefreshData();
            view.ShowModal(this);
        }

        private void Edit()
        {
            int id = ListGridView.GetCurrentRowId();
            EditView view = (EditView)ViewManager.CreateView(EditViewType);
            view.Closed += (o, args) => RefreshData();
            view.EditItemId = id;
            view.ShowModal(this);
        }

        private void Delete()
        {
            try
            {
                _presenter?.Delete(ListGridView?.GetCurrentItem());
                ListGridControl?.RefreshDataSource();
            }
            catch (DbUpdateException ex)
            {
                Log.Error(ex.Message, ex);
                MessageBox.Show(ex.Message);
            }
        }

        protected void RefreshData()
        {
            if (ListGridControl != null)
            {
                ListGridControl.DataSource = _presenter?.LoadDataSource();
            }
            ListGridControl?.RefreshDataSource();
        }

        private void SetButtons()
        {
            bool enabled = ListGridView?.RowCount > 0;
            if (EditButton != null) EditButton.Enabled = enabled;
            if (DeleteButton != null) DeleteButton.Enabled = enabled;
        }
    }
}
