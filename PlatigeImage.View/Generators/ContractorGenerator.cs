using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.Models;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.Utils;

namespace PlatigeImage.View.Generators
{
    public class ContractorGenerator
    {
        public List<ContractorVM> Generate(int count)
        {
            List<ContractorVM> contractors = new List<ContractorVM>(count);

            Random rnd = RandomUtils.SeedRandom();

            for (int i = 0; i < count; i++)
            {
                string firstName = rnd.GetRandomStringFirstUpper(5, 15);
                string lastName = rnd.GetRandomStringFirstUpper(5, 15);
                
                var contractor = new ContractorVM
                {
                    Name = $"{firstName} {lastName}",
                    Code = rnd.GetRandomString(3,10).ToUpper(),
                    Tin = rnd.GetRandomNumberString(10),
                    TinPrefix = rnd.GetRandomEnum<CountryCode>(),
                    Adress = $"{rnd.GetRandomString(3, 10)} {rnd.GetRandomNumberString(1,3)}/{rnd.GetRandomNumberString(1,4)}",
                    Country = rnd.GetRandomEnumDescription<CountryCode>(),
                    Phone = $"+{rnd.GetRandomNumberString(2)} {rnd.GetRandomNumberString(3)} {rnd.GetRandomNumberString(3)} {rnd.GetRandomNumberString(3)}",
                    EMail = $"{firstName}.{lastName}@{rnd.GetRandomString(5, 10)}.{rnd.GetRandomString(2).ToLower()}",
                    Active = rnd.GetRandomBoolean(),
                    Kind = rnd.GetRandomEnum<ContractorKind>(),
                    Status = rnd.GetRandomEnum<ContractorStatus>(),
                    Recipient = rnd.GetRandomBoolean(),
                    Vendor = rnd.GetRandomBoolean(),
                    RelatedEntity = rnd.GetRandomBoolean(),
                    ActiveVat = rnd.GetRandomBoolean(),
                    InLiquidation = rnd.GetRandomBoolean()
                };

                contractors.Add(contractor);
            }

            return contractors;
        }
    }
}
