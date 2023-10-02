using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Utils;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Helpers;
using static Microsoft.SqlServer.Management.Sdk.Sfc.FilterNodeConstant;
using PlatigeImage.View.Interfaces;
using PlatigeImage.View.Presenters.Common;

namespace PlatigeImage.View.Presenters
{
    public class ConnectDatabaseWizardPresenter : Presenter<IConnectDatabaseWizard>
    {
        private string _errorMessage = string.Empty;
        private SqlServerInstanceHelper _serverInstanceHelper;

        public ConnectDatabaseWizardPresenter(IConnectDatabaseWizard view) : base(view)
        {
        }

        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }

        public List<string> GetServers()
        {
            return SqlServerEnumerator.GetLocalSqlServersAsList();
        }

        public List<string> GetDatabases()
        {
            return _serverInstanceHelper.GetSqlDatabasesAsList();
        }

        public int CheckSqlServer()
        {
            _serverInstanceHelper = new SqlServerInstanceHelper(View.ServerName, View.Login, View.Password, View.TrustedConnection);
            int result = _serverInstanceHelper.CheckSqlServer();

            ErrorMessage = _serverInstanceHelper.ErrorMessage;

            return result;
        }

        public void SaveConnectionString()
        {
            string connectionString = SqlConnectionStringHelper.CreateConnectionString(View.ServerName, View.DatabaseName, View.Login, View.Password, View.TrustedConnection);
            ConfigurationUtils.SetConnectionString(connectionString);
        }

        public void CreateDatabaseTables()
        {
            using MainDbContext mainDbContext = new MainDbContext();
            mainDbContext.Database.Migrate();
            //DbContextCollectionHelper.MigrateAllDbContexts();
        }

    }

}
