using PlatigeImage.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.Models.Dictionaries
{
    public static class ContractorDictionary
    {
        public static Dictionary<ContractorKind, string> ContractorKinds()
        {
            return new Dictionary<ContractorKind, string>()
            {
                {ContractorKind.National, "National"},
                {ContractorKind.UE, "UE"},
                {ContractorKind.NonUE, "Non UE"},
            };
        }

        public static Dictionary<ContractorStatus, string> ContractorStatuses()
        {
            return new Dictionary<ContractorStatus, string>()
            {
                {ContractorStatus.NaturalPerson, "Natural Person"},
                {ContractorStatus.BusinessEntity, "Business Entity"}
            };
        }
    }
}
