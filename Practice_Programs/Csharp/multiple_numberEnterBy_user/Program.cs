using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_numberEnterBy_user
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("how many number you want to enter???");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("you enter number: {0}",num1);
            Console.ReadKey();
        }
    }
}
