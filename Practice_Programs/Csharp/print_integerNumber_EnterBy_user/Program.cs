using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_integerNumber_EnterBy_user
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            Console.WriteLine("Enter a number:");
            numbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You enter:{0}",numbers);
            Console.ReadKey();
        }
    }
}
