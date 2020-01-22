using LocFut.Application.Interface;
using LocFut.Data.Interface;
using LocFut.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Application
{
    public class QuadraService : IQuadraService
    {
        protected readonly IQuadraRepository repository;
        public QuadraService(IQuadraRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Quadra> Get()
        {
            return repository.Get();
        }

        public Quadra Get(Guid id)
        {
            return repository.Get(id);
        }

        public Quadra Post(Quadra quadra)
        {
            return repository.Post(quadra);
        }

        public Quadra Put(Guid id, Quadra quadra)
        {
            return repository.Put(id, quadra);
        }
        public void Delete(Guid id)
        {
            repository.Delete(id);
        }
    }
}