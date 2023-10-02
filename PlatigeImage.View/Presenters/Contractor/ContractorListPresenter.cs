using Microsoft.SqlServer.Management.Smo;
using PlatigeImage.DataAccess;
using PlatigeImage.DataAccess.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatigeImage.View.Utils;

using PlatigeImage.View.Database;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Helpers;
using PlatigeImage.View.Generators;
using PlatigeImage.View.Mappers;
using PlatigeImage.View.Repository;
using PlatigeImage.View.Interfaces.Contractor;
using PlatigeImage.View.Presenters.Common;
using PlatigeImage.Models;
using PlatigeImage.View.Services;
using PlatigeImage.Models.Dictionaries;
using PlatigeImage.Models.Enums;
using PlatigeImage.View.ViewModels.Invoice;
using PlatigeImage.View.Exporters;
using PlatigeImage.View.Interfaces;

namespace PlatigeImage.View.Presenters.Contractor
{
    public class ContractorListPresenter : ListPresenter<IContractorListView>
    {
        private readonly ContractorService _contractorService;
        private List<ContractorListVM> _contractorListVM;
        public ContractorListPresenter(IContractorListView view) : base(view)
        {
            _contractorService = new ContractorService();
            _contractorListVM = new List<ContractorListVM>();
        }

        public override object LoadDataSource()
        {
            _contractorListVM = _contractorService.GetList(ContractorVMMapper.ContractorToContractorListVM);
            return new BindingList<ContractorListVM>(_contractorListVM);
        }

        public override void Delete(object? item)
        {
            if (item is ContractorListVM contractorListVM)
            {
                if (contractorListVM.Id == 1)
                {
                    throw new Exception("The default contractor cannot be deleted.");
                }

                _contractorService.Delete(contractorListVM.Id);
                _contractorListVM.Remove(contractorListVM);
            }
        }

        public void Generate(int count)
        {
            var contractorList = new ContractorGenerator().Generate(count);
            _contractorService.AddList(contractorList, ContractorVMMapper.ContractorVMToContractor);
        }

        public void Export(string path, bool openFile)
        {
            List<ContractorListVM> invoices = _contractorService.GetList(ContractorVMMapper.ContractorToContractorListVM);
            IExporter<ContractorListVM>? exporter = ExporterFactory.CreateExporter<ContractorListVM>(path);
            exporter?.Export(invoices, openFile);
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
