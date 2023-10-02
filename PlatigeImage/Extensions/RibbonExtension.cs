using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace PlatigeImage.View.WinForms.Extensions
{
    public static class RibbonExtension
    {
        public static void DisableRibbonGroups(this DevExpress.XtraBars.Ribbon.RibbonControl ribbon, RibbonPageGroup? exceptGroup = null)
        {
            foreach (RibbonPage ribbonPage in ribbon.Pages)
            {
                foreach (RibbonPageGroup ribbonPageGroup in ribbonPage.Groups)
                {
                    if (exceptGroup == null || ribbonPageGroup != exceptGroup)
                        ribbonPageGroup.Enabled = false;
                }
            }
        }

        public static void EnableRibbonGroups(this DevExpress.XtraBars.Ribbon.RibbonControl ribbon, RibbonPageGroup? exceptGroup = null)
        {
            foreach (RibbonPage ribbonPage in ribbon.Pages)
            {
                foreach (RibbonPageGroup ribbonPageGroup in ribbonPage.Groups)
                {
                    if (exceptGroup == null || ribbonPageGroup != exceptGroup)
                        ribbonPageGroup.Enabled = true;
                }
            }
        }
    }
}
