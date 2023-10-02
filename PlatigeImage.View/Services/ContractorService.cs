using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.DataAccess;
using PlatigeImage.Models;
using System.Linq.Expressions;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.ViewModels.Reports;

namespace PlatigeImage.View.Services
{
    public class ContractorService : BaseService<Contractor>
    {
        public ContractorService() : base(new ContractorRepository())
        {

        }

        public List<CountryAndNumber> GetContractorsNumbersByCountry()
        {
            if(Repository == null)
                return new List<CountryAndNumber>();
            return Repository.GetAll()
                .GroupBy(c => c.Country)
                .Select(c => new CountryAndNumber()
                {
                    Country = c.Key,
                    Number = c.Count()
                })
                .OrderBy(c => c.Country)
                .ToList();
        }
    }
}
