using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_FindOddNumber_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine(" Enter the number : ");
            i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine(i+" number is Even ");
            }
            else
                Console.WriteLine(i+" number is Odd ");

            Console.ReadKey();
        }
    }
}
