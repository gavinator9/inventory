using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elliott_Inventory
{
    internal class Shipper
    {

        private bool _manifestfull=false;
        private int _capacitytracker=0;

        ishippable[] shippingmanifest;
        private string selection;

        public Shipper()
        {
            shippingmanifest= new ishippable[10];

        }

        public string Add(char input)
        {
            if (_capacitytracker == 10)
            {
                _manifestfull = true;
            }
            if (_manifestfull == false)
            {
                selection = "";

                if (input == '1')
                {

                    shippingmanifest[_capacitytracker] = new bicycle();
                    selection = "1 Bike";
                }
                if (input == '2')
                {
                    shippingmanifest[_capacitytracker] = new mower();
                    selection = "1 Lawn Mower";
                }
                if (input == '3')
                {
                    shippingmanifest[_capacitytracker] = new bballglove();
                    selection = "1 Baseball Glove";
                }
                if (input == '4')
                {
                    shippingmanifest[_capacitytracker] = new crackers();
                    selection = "1 Pack of Crackers";
                }
                _capacitytracker++;

                return selection + " Has been added\n";
            }
            else
            {
                return "The manifest is full.\n";
            }
        }

        public string list()
        {
            string result = "";
            string item = "";
            int gloves=0;
            int crackers = 0;
            int bicycle = 0;
            int mower = 0;
            string g = "";
            string b = "";
            string l="";

            for (int i = 0; i<shippingmanifest.Length; i++ )
            {

                if (shippingmanifest[i] != null)
                {
                    item = shippingmanifest[i].Product;
                    if (item == "Baseball Glove")
                    {
                        gloves++;
                    }
                    if (item == "Crackers")
                    {
                        crackers++;
                    }
                    if (item=="Lawn Mower")
                    {
                        mower++;
                    }
                    if (item == "Bicycle")
                    {
                        bicycle++;
                    }
                }


            }
            if (gloves>1)
            {
                g = "s";
            }
            if (mower>1)
            {
                l= "s";
            }
            if (bicycle>1)
            {
                b = "s";
            }
            result = "Shipping Manifest: \n" + gloves.ToString() + " Baseball Glove"+g+"\n"+crackers.ToString()+" Crackers\n" + bicycle.ToString()+" Bicycle"+b+"\n"+mower.ToString()+" Lawn Mower"+l+"\n";
            return result;
        }

        public string Compute()
        {
            string result = "";
            decimal total=0;
            for (int i=0; i<shippingmanifest.Length-1; i++)
            {
                if (shippingmanifest[i] != null)
                {
                    total += shippingmanifest[i].ShipCost;
                }
            }
            result= total.ToString("C");
            return "\nTotal shipping cost for this order:"+result+"\n";
        }


    }
}
