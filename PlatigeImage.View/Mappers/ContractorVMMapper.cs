using PlatigeImage.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;

namespace PlatigeImage.View.Mappers
{
    [Mapper]
    public static partial class ContractorVMMapper
    {
        public static partial ContractorVM ContractorToContractorVM(Contractor contractor);
        public static partial Contractor ContractorVMToContractor(ContractorVM contractor);
        [MapEnum(EnumMappingStrategy.ByName)]
        public static partial ContractorListVM ContractorToContractorListVM(Contractor contractor);
    }
}