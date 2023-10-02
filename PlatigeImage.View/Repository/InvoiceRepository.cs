using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Interfaces;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using PlatigeImage.View.Mappers;

namespace PlatigeImage.View.Repository
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository() : base(new MainDbContext())
        {

        }

        public List<Invoice> AddManyWithPositions(List<Invoice> entities)
        {
            AddMany(entities);

            entities.ForEach(f => f.InvoicePositions.ForEach(ip => ip.InvoiceId = f.Id));

            AddMany(entities);

            return entities;
        }
    }

    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {

    }
}
