using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal interface ishippable
    {
        decimal ShipCost { get; } 
        string Product { get; }
    }
}
