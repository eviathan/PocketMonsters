using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Enums;

namespace PocketMonsters.Core.Interfaces
{
    public interface IItem
    {
        Guid Id { get; set; }
        ItemType Type { get; set; }
    }
}