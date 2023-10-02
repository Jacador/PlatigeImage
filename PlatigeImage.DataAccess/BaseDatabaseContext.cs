
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Interfaces;

namespace PlatigeImage.DataAccess
{
    public abstract class BaseDatabaseContext : DbContext, IBaseDatabaseContext
    {
        protected BaseDatabaseContext()
        {
        }

        protected BaseDatabaseContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString ?? string.Empty;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}