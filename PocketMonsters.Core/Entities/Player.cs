using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMonsters.Core.Entities
{
    public class Player : EntityBase
    {
        public string Name { get; set; }
        public StatTree Stats { get; set; }

        public Inventory Inventory { get; set; }

        public MonsterCatalog Catalog { get; set; } = new();
        public List<Monster> Group { get; set; } = new();
        public Dictionary<Guid, Monster> Monsters { get; set; } = new();
    }
}