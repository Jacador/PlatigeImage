using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.DataAccess.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindByConditionWithTracking(Expression<Func<T, bool>> expression);

        T? Add(T entity);
        List<T> AddMany(List<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void Delete(object key);
        bool Exists(T entity);
        int SaveChanges();
        int GetCount();
        T? Find(object?[]? keys);
        T? Find(object? key);
    }
}
