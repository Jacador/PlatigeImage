using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatigeImage.DataAccess;
using PlatigeImage.View.Interfaces.Presenters;
using PlatigeImage.View.Interfaces.Common;
using PlatigeImage.View.Services;
using PlatigeImage.View.ViewModels.Invoice;

namespace PlatigeImage.View.Presenters.Common
{
    public abstract class EditPresenter<T> : Presenter<T>, IEditPresenter where T : IEditView
    {
        internal EditPresenter(T view) : base(view)
        {
        }

        public abstract void LoadItem();
        public abstract void SaveItem();
    }
}
