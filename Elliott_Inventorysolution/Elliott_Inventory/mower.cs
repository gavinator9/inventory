using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal class mower : ishippable
    {
        public decimal _cost = 24M;
        private string _product = "Lawn Mower";

        decimal ishippable.ShipCost { get => _cost; }
        string ishippable.Product { get => _product; }
    }
}
