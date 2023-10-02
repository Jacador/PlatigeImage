using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Interfaces.Presenters;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.Presenters.Common
{
    public abstract class ListPresenter<T> : Presenter<T>, IListPresenter where T : IListView
    {
        internal ListPresenter(T view) : base(view)
        {
        }

        public abstract void Delete(object? item);
        public abstract object LoadDataSource();

    }
}
