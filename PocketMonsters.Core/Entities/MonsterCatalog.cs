using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMonsters.Core.Entities
{
    public class MonsterCatalog : Dictionary<Guid, MonsterCatalogEntry> { }

    public class MonsterCatalogEntry
    {
        public bool HasSeen { get; set; }
    }
}