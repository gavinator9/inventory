// Gavin Elliott
// IT112 
// NOTES: slightly confused by rubric item "shipping calculations other than via the interface" is using my inventory array avoiding this or am I
// misunderstanding what you mean? I have the method internally "ask" each array item its properties if that's what you mean in the clarification
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