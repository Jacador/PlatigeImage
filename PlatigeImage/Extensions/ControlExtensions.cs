using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.WinForms.Extensions
{
    public static class ControlExtensions
    {
        public static void ValidateControls(this Control controlToValidate)
        {
            foreach (Control control in controlToValidate.Controls)
            {
                if (control is BaseEdit baseEditControl)
                {
                    baseEditControl.DoValidate();
                }
                ValidateControls(control);
            }
        }
    }
}
