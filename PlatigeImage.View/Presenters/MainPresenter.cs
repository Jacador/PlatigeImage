using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using PlatigeImage.View.Utils;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Presenters.Common;

namespace PlatigeImage.View.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {
        public MainPresenter(IMainView view) : base(view)
        {

        }

        public bool ConnectionStringWorks()
        {
            string connectionString = ConfigurationUtils.GetConnectionString();
            if (!string.IsNullOrEmpty(connectionString))
            {
                if (SqlServerInstanceHelper.CheckDatabase(connectionString) == 1)
                    return true;
            }
            return false;
        }

    }
}
