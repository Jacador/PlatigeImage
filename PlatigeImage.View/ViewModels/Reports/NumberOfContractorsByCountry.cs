using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.View.ViewModels.Reports
{
    public class NumberOfContractorsByCountry
    {
        public List<CountryAndNumber> ContractorsNumberByCountry { get; set; } = new();

        public List<CountryAndNumber> GetData()
        {
            return ContractorsNumberByCountry;
        }
    }

    public class CountryAndNumber
    {
        public string Country { get; set; }
        public int Number { get; set; }
    }



}
