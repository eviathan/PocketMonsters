using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Entities;
using PocketMonsters.Core.Enums;

namespace PocketMonsters.Core.Extensions
{
    public static class PlayerClassExtensions
    {
        public static StatTree GetDefaultStats(this PlayerClass playerClass) => 
            _defaultStats.ContainsKey(playerClass)
                ? _defaultStats[playerClass]
                : throw new ArgumentOutOfRangeException(nameof(playerClass));

        private readonly static Dictionary<PlayerClass, StatTree> _defaultStats = new Dictionary<PlayerClass, StatTree>
        {
            // TODO: Add all the player classes
            { 
                PlayerClass.Warrior,
                new StatTree
                {
                    Level = 8,
                    Health = 11,
                    Stamina = 11,
                    Mana = 12,
                    Strength = 10,
                    Dexterity = 11,
                    Intelligence = 10,
                    Faith = 8,
                    Arcane = 9
                }
            }
        };
    }
}