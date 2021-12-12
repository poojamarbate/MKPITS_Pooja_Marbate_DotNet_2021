using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_FindArmstrongNumber_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder, sum = 0;
            Console.WriteLine("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;

            }
            if (sum == number)
            {
                Console.Write("Entered Number is an Armstrong Number.");
            }
            else
                Console.Write("Entered Number is not an Armstrong Number.");
            Console.ReadLine();
        }
    }
}
