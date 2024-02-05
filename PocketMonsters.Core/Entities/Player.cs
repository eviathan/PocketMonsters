using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Enums;
using PocketMonsters.Core.Extensions;

namespace PocketMonsters.Core.Entities
{
    public class Player : EntityBase
    {
        public string Name { get; set; }
        public PlayerClass Class { get; set; }
        public StatTree Stats { get; set; }

        public Inventory Inventory { get; set; } = new();

        public MonsterCatalog Catalog { get; set; } = new();
        public List<Monster> Group { get; set; } = new();
        public Dictionary<Guid, Monster> Monsters { get; set; } = new();

        public Player(string name, PlayerClass playerClass)
        {
            Name = name;
            Class = playerClass;
            Stats = playerClass.GetDefaultStats();
        }
    }
}