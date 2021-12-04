using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec4_Array_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car = { "car1", "car2", "car3", "car4" };
            //Console.WriteLine(car[3]);
            //for(int i=0;i<car.Length;i++)
            //{
            //    Console.WriteLine(car[i]);
            //}
            foreach(string i in car)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = { 5, 1, 8, 9 };
          
            Console.WriteLine("Max Number in List : "+myNumbers.Max());  // returns the largest value
            Console.WriteLine("Min number : "+myNumbers.Min());  // returns the smallest value
            Console.WriteLine("Sum = "+myNumbers.Sum());  // returns the sum of elements
            Console.ReadKey();
        }

    }
}
