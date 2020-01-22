using LocFut.Data.Context;
using LocFut.Data.Interface;
using LocFut.Domain.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Data.Repository
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : Entidade
    {
        protected readonly DbContextLocFut context;

        public RepositoryBase(DbContextLocFut context)
        {
            this.context = context;
        }

        public RepositoryBase()
        {
        }

        public T Add(T item)
        {
            return context.Add(item).Entity;
        }

        public void Delete(Guid id)
        {
            context.Remove(id);
        }

        public T Get(Guid id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> Get()
        {
            return context.Set<T>().AsNoTracking(); ;
        }

        public T Update(T item)
        {
            return context.Set<T>().Update(item).Entity;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
