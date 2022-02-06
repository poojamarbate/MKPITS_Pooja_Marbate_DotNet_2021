using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number of Week:");
            int week_number =int.Parse(Console.ReadLine());
             switch(week_number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wendesday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Week day");
                    break;

            }
            Console.WriteLine("After Switch Statement");
            Console.ReadLine();
        }
    }
}
