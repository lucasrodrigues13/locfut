using LocFut.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Application.Interface
{
    public interface IQuadraService
    {
        IEnumerable<Quadra> Get();
        Quadra Get(Guid id);
        Quadra Post(Quadra quadra);
        Quadra Put(Guid id, Quadra quadra);
        void Delete(Guid id);
    }
}
