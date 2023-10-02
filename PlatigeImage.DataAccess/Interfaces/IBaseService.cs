using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatigeImage.DataAccess.Interfaces
{
    public interface IBaseService<T>
    {
        List<TVM>? GetList<TVM>(Func<T, TVM> mapping);
        object? Get<TVM>(int id, Func<T, TVM> mapping) where TVM : new();
        void Save<TVM>(TVM entityVM, Func<TVM, T> mapping);
        void Delete(int id);
        void AddList(List<T> entitiesList);
    }
}
