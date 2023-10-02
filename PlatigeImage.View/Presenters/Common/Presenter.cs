using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Interfaces.Presenters;
using PlatigeImage.View.Interfaces.Common;

namespace PlatigeImage.View.Presenters.Common
{
    public abstract class Presenter<T> : IPresenter where T : IView
    {
        private readonly T _view;

        internal Presenter(T view)
        {
            _view = view;
        }

        public T View => _view;
    }
}
