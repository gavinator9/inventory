using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal class bballglove: ishippable
    {
        public decimal _cost = 3.23M;
        private string _product = "Baseball Glove";

        decimal ishippable.ShipCost { get => _cost; }
        string ishippable.Product { get => _product; }
    }
}
