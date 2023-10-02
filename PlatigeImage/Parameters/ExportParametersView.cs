using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PlatigeImage.View.Interfaces.Parameters;

namespace PlatigeImage.View.WinForms
{
    public partial class ExportParametersView : XtraForm, IExportParametersView
    {
        public ExportParametersView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ExportSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public string Path => PathTextEdit.Text;

        public bool OpenFile => OpenFileCheckEdit.Checked;

        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PathTextEdit_TextChanged(object sender, EventArgs e)
        {
            ExportSimpleButton.Enabled = PathTextEdit.Text.Length > 0;
        }

        private void SelectPathSimpleButton_Click(object sender, EventArgs e)
        {
            if (ExportSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextEdit.Text = ExportSaveFileDialog.FileName;
            }
        }

    }
}
