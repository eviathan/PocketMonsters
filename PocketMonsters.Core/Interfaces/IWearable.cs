using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketMonsters.Core.Interfaces
{
    public interface IWearable : IBuffable, IPurchasable
    {
        int Weight { get; set; }
    }
}