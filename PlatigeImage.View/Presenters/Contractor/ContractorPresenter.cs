using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Utils;
using PlatigeImage.Models;
using PlatigeImage.View.Database;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Helpers;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Presenters.Common;
using PlatigeImage.View.Services;
using PlatigeImage.Models.Enums;

namespace PlatigeImage.View.Presenters.Contractor
{
    public class ContractorPresenter : EditPresenter<IContractorView>
    {
        private readonly ContractorService _contractorService;
        private ContractorVM? _contractor;
        public ContractorPresenter(IContractorView view) : base(view)
        {
            _contractorService = new ContractorService();
        }

        public override void LoadItem()
        {
            View.Contractor = _contractor = (ContractorVM?)_contractorService.Get(View.EditItemId, ContractorVMMapper.ContractorToContractorVM);
        }

        public override void SaveItem()
        {
            if(_contractor != null)
                _contractorService.Save(_contractor, ContractorVMMapper.ContractorVMToContractor);
        }

        public Dictionary<ContractorKind, string> ContractorKinds()
        {
            return ContractorDictionary.ContractorKinds();
        }

        public Dictionary<ContractorStatus, string> ContractorStatuses()
        {
            return ContractorDictionary.ContractorStatuses();
        }
    }

}
