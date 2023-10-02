using PlatigeImage.View.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.Interfaces.Presenters
{
    public interface IEditPresenter : IPresenter
    {
        public void LoadItem();
        public void SaveItem();
    }
}
