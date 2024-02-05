using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Entities;
using PocketMonsters.Core.Interfaces;

namespace PocketMonsters.Core.Extensions
{
    public static class IBuffableExtensions
    {
        public static IEnumerable<StatTree> ProcessBuff(this IWearable wearable, StatTree stats)
        {
            // DO PROCESSING HERE
            yield return stats;
        }
    }
}