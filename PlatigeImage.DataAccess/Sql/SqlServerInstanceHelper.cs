using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;

namespace PlatigeImage.DataAccess
{
    public class SqlServerInstanceHelper
    {
        private readonly string _serverName;
        private readonly string _login;
        private readonly string _password;
        private readonly bool _trustedConnection;
        private Server _server;

        private string _errorMessage = string.Empty;

        public SqlServerInstanceHelper(string serverName, string login, string password, bool trustedConnection)
        {
            _serverName = serverName;
            _login = login;
            _password = password;
            _trustedConnection = trustedConnection;
        }

        private Server CreateServerInstance()
        {
            _server = new Server(_serverName);
            _server.ConnectionContext.LoginSecure = _trustedConnection;
            if (!_trustedConnection && !string.IsNullOrEmpty(_login))
            {
                _server.ConnectionContext.Login = _login;
                _server.ConnectionContext.Password = _password;
            }
            return _server;
        }

        public void CreateDatabase(string databaseName)
        {
            if (!DatabaseExists(databaseName))
            {
                new Database(_server, databaseName).Create();
            }
        }

        public bool DatabaseExists(string databaseName)
        {
            return _server.Databases.Contains(databaseName);
        }

        public int CheckSqlServer()
        {
            Server server = CreateServerInstance();

            try
            {
                var version = server.Information.Version;
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
                return 0;
            }

            return 1;
        }

        public List<string> GetSqlDatabasesAsList()
        {
            return _server.Databases.Cast<Database>().Where(d => d.ID > 4).Select(d => d.Name).ToList();
        }

        public string ErrorMessage => _errorMessage;

        public static int CheckDatabase(string connectionString)
        {
            try
            {
                using IDbConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
