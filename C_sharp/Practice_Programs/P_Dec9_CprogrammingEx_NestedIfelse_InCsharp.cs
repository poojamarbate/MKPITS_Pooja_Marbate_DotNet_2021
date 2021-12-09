using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_Nested_ifElse_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the any number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("Number is zero");
            else if (num > 0)
            {
                Console.WriteLine("Number is positive");
            if (num % 2 == 0)
                Console.WriteLine("Number is even ");
            else
                Console.WriteLine("Number is odd ");
            }
            else
            {
                Console.Write("Number is negetive");
                if(num%2==0)
                    Console.Write(" Number is even");
                else
                    Console.Write(" Number is odd");
            }
          
            Console.ReadKey();

        }
    }
}
