using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.WinForms
{
    public static class ViewManager
    {
        private static Form _rootView = null;
        private static List<Form> _openForms = new();

        public static void RegisterRootView(Form rootView)
        {
            _rootView = rootView;
        }

        public static void ShowModal(this Form child, Form parent)
        {
            var openForm = _openForms.FirstOrDefault(v => v.GetType() == child.GetType());
            if (openForm == null)
            {
                child.Shown += (o, e) =>
                {
                    DeactivateParents(parent, false);
                    _openForms.Add(child);
                };
                child.Closed += (o, e) =>
                {
                    ReactivateParents(parent, false);
                    _openForms.Remove(child);
                };
                child.MdiParent = parent.IsMdiContainer ? parent : _rootView;
                child.Show();
            }
            else
            {
                if(openForm.Enabled)
                    openForm.Focus();
            }
        }
        public static void ShowModalDialog(this Form child, Form parent)
        {
            child.Shown += (o, e) => DeactivateParents(parent, true);
            child.Closed += (o, e) => ReactivateParents(parent, true);
            child.MdiParent = _rootView;
            child.Show();
            
        }

        public static IView? CreateView(Type viewType)
        {
            return (IView?)Activator.CreateInstance(viewType);
        }

        private static void DeactivateParents(Form parent, bool dialog)
        {
            ChangeEnabledState(parent, dialog, false);
        }

        private static void ReactivateParents(Form parent, bool dialog)
        {
            ChangeEnabledState(parent, dialog, true);
        }

        private static void ChangeEnabledState(Form parent, bool dialog, bool state)
        {
            if (dialog)
            {
                if (_rootView is RibbonForm form)
                    form.Ribbon.Enabled = state;
                _openForms.ForEach(v => v.Enabled = state);
            }
            else
            {
                if (parent != _rootView)
                    parent.Enabled = state;
            }
        }
    }
}
