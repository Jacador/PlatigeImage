using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.DataAccess.Helpers
{
    public static class DbContextCollectionHelper
    {
        public static void MigrateAllDbContexts()
        {
            var assembly = Assembly.GetCallingAssembly();
            var dbContexts = assembly.GetTypes().Where(t => typeof(DbContext).IsAssignableFrom(t) && !t.IsInterface).ToList();

            foreach (var dbContext in dbContexts)
            {
                DbContext? instance = (DbContext?)Activator.CreateInstance(dbContext);
                instance?.Database.Migrate();
            }
        }
    }
}
