using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess;
using PlatigeImage.Models;

namespace PlatigeImage.View.Database
{
    public class MainDbContext : BaseDatabaseContext
    {
        public MainDbContext()
        {
        }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contractor>().HasData(
                new Contractor() {Id = 1, Code = "!INDEFINITE!", Active = true}
            );
        }
    }
}
