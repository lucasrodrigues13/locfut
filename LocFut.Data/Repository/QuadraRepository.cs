using LocFut.Data.Interface;
using LocFut.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Data.Repository
{
    public class QuadraRepository : IQuadraRepository
    {
        protected readonly IRepositoryBase<Quadra> repositoryBase;
        public QuadraRepository(IRepositoryBase<Quadra> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public Quadra Post(Quadra quadra)
        {
            return repositoryBase.Add(quadra);
        }

        public void Delete(Guid id)
        {
            repositoryBase.Delete(id);
        }

        public Quadra Put(Guid id, Quadra quadra)
        {
            return repositoryBase.Update(quadra);
        }

        public IEnumerable<Quadra> Get()
        {
            return repositoryBase.Get();
        }

        public Quadra Get(Guid id)
        {
            return repositoryBase.Get(id);
        }
    }
}
