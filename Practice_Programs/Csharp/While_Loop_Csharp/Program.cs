using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int i=0;
            while(i<=10) //syntax
            {
                Console.WriteLine(number+" x "+i+" = "+number*i);
               i++;
            }
            Console.ReadLine();
        }
    }
}
