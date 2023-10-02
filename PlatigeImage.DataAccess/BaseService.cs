
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PlatigeImage.DataAccess.Interfaces;

namespace PlatigeImage.DataAccess
{
    public abstract class BaseService<T> : IBaseService<T> where T : IDatabaseEntity
    {
        private readonly IBaseRepository<T>? _repository;

        protected BaseService()
        {

        }

        protected BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        protected IBaseRepository<T>? Repository => _repository;

        public int[] GetIdsArray()
        {
            if (_repository == null)
                return Array.Empty<int>();
            return _repository.GetAll().Select(c => c.Id).ToArray();
        }

        public List<TVM> GetList<TVM>(Func<T, TVM> mapping)
        {
            if (_repository == null)
                return new List<TVM>();
            return _repository.GetAll().Select(mapping).ToList();
        }

        public List<TVM> GetList<TVM>(Expression<Func<T, bool>> where, Func<T, TVM> mapping)
        {
            if (_repository == null)
                return new List<TVM>();
            return _repository.GetAll().Where(where).Select(mapping).ToList();
        }

        public object? Get<TVM>(int id, Func<T, TVM> mapping) where TVM : new()
        {
            if (_repository == null) return null;

            TVM invoiceVM = new TVM();
            if (id > 0)
            {
                T? invoice = _repository.FindByCondition(c => c.Id == id).FirstOrDefault();
                if (invoice != null)
                    invoiceVM = mapping.Invoke(invoice);
            }
            return invoiceVM;
        }

        public void Save<TVM>(TVM entityVM, Func<TVM, T> mapping)
        {
            T entity = mapping.Invoke(entityVM);
            if (entity.Id == 0)
            {
                Add(entity);
            }
            else
            {
                Update(entity);
            }
        }

        public void Add(T entity)
        {
            _repository?.Add(entity);
            _repository?.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _repository?.Update(entity);
            _repository?.SaveChanges();
        }

        public void Delete(int id)
        {
            _repository?.Delete(id);
            _repository?.SaveChanges();
        }

        public void AddList(List<T> entitiesList)
        {
            _repository?.AddMany(entitiesList);
            _repository?.SaveChanges();
        }

        public void AddList<TVM>(List<TVM> entitiesList, Func<TVM, T> mapping)
        {
            var entities = entitiesList.Select(mapping).ToList();
            _repository?.AddMany(entities);
            _repository?.SaveChanges();
        }
    }
}