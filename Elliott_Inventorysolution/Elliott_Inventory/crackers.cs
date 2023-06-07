using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal class crackers : ishippable
    {
        public decimal _cost = .57M;
        private string _product = "Crackers";

        decimal ishippable.ShipCost { get => _cost; }
        string ishippable.Product { get => _product; }
    }
}
