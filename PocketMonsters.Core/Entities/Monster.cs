using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Enums;

namespace PocketMonsters.Core.Entities
{
    public class Monster : EntityBase
    {
        public string Name { get; set; }
        
        public MonsterType Type { get; set; }
        
        // public List<ILearnable> Skill { get; set; }

        public StatTree Stats { get; set; }
    }
}