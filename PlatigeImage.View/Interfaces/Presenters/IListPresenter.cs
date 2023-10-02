using PlatigeImage.View.Presenters.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlatigeImage.View.Interfaces.Presenters
{
    public interface IListPresenter : IPresenter
    {
        void Delete(object? item);

        object LoadDataSource();
    }
}
