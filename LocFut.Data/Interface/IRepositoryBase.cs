using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Data.Interface
{
    public interface IRepositoryBase<T>
    {
        T Add(T item);

        void Delete(Guid id);

        T Update(T item);

        T Get(Guid id);

        IEnumerable<T> Get();
    }
}
