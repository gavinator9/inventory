// Gavin Elliott
// IT112 
// NOTES: Was pretty interesting learning to implement the interface for the first time, got so focused on that part I forgot trivial errors like making objects from my classes at first lol
// BEHAVIORS NOT IMPLEMENTED AND WHY: Seems to be feature complete as far as I understand the assignment

namespace Elliott_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to megashipping! \n \n");
            Shipper shipper= new Shipper();
            bool isrunning = true;
            string rawinput;
            char input;
            string output;
            while (isrunning==true)
            {
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List shipment items");
                Console.WriteLine("6. Compute Shipping Charges\n");
                rawinput = Console.ReadLine();
                input = char.Parse(rawinput);
                if (input=='1' || input=='2' || input=='3' || input=='4') 
                {
                    output = shipper.Add(input);
                    Console.WriteLine(output);
                }
                if (input == '5')
                {
                    Console.WriteLine(shipper.list());
                }
                if (input == '6')
                {
                    Console.WriteLine(shipper.Compute());
                    Console.WriteLine("\n Have a nice day!");
                    isrunning = false;
                }


                if (1 == 2)
                {
                    isrunning = false;
                }

            }
        }
    }
}
