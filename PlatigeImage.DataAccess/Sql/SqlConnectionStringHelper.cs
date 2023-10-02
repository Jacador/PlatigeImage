using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.DataAccess.Sql
{
    public static class SqlConnectionStringHelper
    {
        public static string CreateConnectionString(string serverName, string databaseName, string userId, string password, bool trustedConnection)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            
            sqlBuilder.IntegratedSecurity = trustedConnection;
            if (!trustedConnection)
            {
                sqlBuilder.Password = password;
                sqlBuilder.UserID = userId;
            }

            sqlBuilder.Encrypt = false;

            return sqlBuilder.ConnectionString;
        }
    }
}
