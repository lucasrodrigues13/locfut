using System;
using System.Collections.Generic;
using System.Text;

namespace LocFut.Domain.Base
{
    public class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
