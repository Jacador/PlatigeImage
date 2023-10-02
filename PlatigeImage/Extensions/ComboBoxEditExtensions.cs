using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Native;

namespace PlatigeImage.View.WinForms.Extensions
{
    public static class ComboBoxEditExtensions
    {
        public static void Populate<T>(this ComboBoxEdit control, List<T> items)
        {
            control.Properties.Items.Clear();
            control.Properties.Items.AddRange(items);
            if (control.Properties.Items.Count > 0)
                control.SelectedIndex = 0;
        }
    }
}
