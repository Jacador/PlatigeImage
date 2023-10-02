using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Interfaces;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using PlatigeImage.View.Mappers;

namespace PlatigeImage.View.Repository
{
    public class ContractorRepository : BaseRepository<Contractor>, IContractorRepository
    {
        public ContractorRepository() : base(new MainDbContext())
        {

        }
    }

    public interface IContractorRepository : IBaseRepository<Contractor>
    {

    }
}
