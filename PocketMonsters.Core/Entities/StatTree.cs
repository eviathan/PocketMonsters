using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMonsters.Core.Entities
{
    public struct StatTree
    {
        public int Level { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Faith { get; set; }
        public int Arcane { get; set; }
    }
}