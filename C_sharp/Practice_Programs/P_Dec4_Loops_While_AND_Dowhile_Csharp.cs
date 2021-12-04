using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec4_Loops_While_AND_dowhile_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);


            Console.ReadKey();

        }
    }
}
