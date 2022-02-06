using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neasted_Switch_Case_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pizza flavor:");
            string pizza = Console.ReadLine();
            switch(pizza)
            {
                case "Fajita":
                    Console.WriteLine("You have selected Fajita Pizza");
                    break;
                case "Cheese":
                    Console.WriteLine("You have selected Cheese Pizza");
                    break;
                case "Vegetable":
                    Console.WriteLine("Enter your Vegetable:");
                    string veg = Console.ReadLine();
                    switch(veg)
                    {
                        case "Onion":
                            Console.WriteLine("You have selected Onion");
                            break;
                        case "Capsicum":
                            Console.WriteLine("You have selected Capsicum");
                            break;
                        case "Broklii":
                            Console.WriteLine("You have selected Broklii");
                            break;
                        default:
                            Console.WriteLine("Vegetable not available");
                            break;
                    }
                    break;
                case "Mashroom":
                    Console.WriteLine("You have selected Mashroom Pizza");
                    break;
                case "Paneer":
                    Console.WriteLine("You have selected Paneer Pizza");
                    break;
                default:
                    Console.WriteLine("Pizza Flavor not available");
                    break;



            }
            Console.ReadLine();
        }
    }
}
