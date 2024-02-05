using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PocketMonsters.Core.Entities;

// NOTES: 
/* 
    1.  
*/

namespace PocketMonsters.Core.Interfaces
{
    public interface IBuffable
    {
        TimeSpan TimeSpan { get; set; }
        
        StatTree ApplyBuff(StatTree stats);
    }
}