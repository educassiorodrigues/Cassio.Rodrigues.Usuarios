﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassio.Rodrigues.Usuarios.Domain.Entities
{
    public abstract class Entity
    {
        public string Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString() ;
        }
    }
}
