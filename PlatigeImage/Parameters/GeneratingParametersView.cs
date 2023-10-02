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
using PlatigeImage.View.Interfaces.Parameters;

namespace PlatigeImage.View.WinForms
{
    public partial class GeneratingParametersView : XtraForm, IGeneratingParametersView
    {
        public GeneratingParametersView()
        {
            InitializeComponent();
        }

        public int Count => Convert.ToInt32(CountSpinEdit.Value);

        private void GenerateSimpleButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
