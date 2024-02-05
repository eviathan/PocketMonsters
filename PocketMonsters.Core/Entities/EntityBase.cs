using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMonsters.Core.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}