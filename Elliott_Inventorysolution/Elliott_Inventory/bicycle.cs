using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal class bicycle : ishippable
    {

        public decimal _cost = 9.5M;
        private string _product = "Bicycle";

        decimal ishippable.ShipCost { get=>_cost; }
        string ishippable.Product { get=>_product; }
    }
}
