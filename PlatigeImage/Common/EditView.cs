using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.View.Interfaces.Presenters;
using PlatigeImage.View.Interfaces.Common;
using PlatigeImage.View.Presenters.Common;
using PlatigeImage.View.WinForms.Extensions;
using log4net;

namespace PlatigeImage.View.WinForms
{
    public partial class EditView : XtraForm, IEditView
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(typeof(EditView));
        IEditPresenter? _presenter;

        public EditView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _presenter?.LoadItem();
        }


        public int EditItemId { get; set; }


        protected void AttachPresenter(IEditPresenter presenter)
        {
            _presenter = presenter;
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter?.SaveItem();
                Close();
            }
            catch (DbUpdateException ex)
            {
                Log.Error(ex.Message, ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditView_Validating(object sender, CancelEventArgs e)
        {
            this.ValidateControls();
        }


    }
}
