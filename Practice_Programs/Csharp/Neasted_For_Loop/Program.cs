using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neasted_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("hello.....");
                for (int j = 0; j <=3; j++)
                {
                    Console.WriteLine("Hey");
                }
            }
            Console.ReadLine();
        }
    }
}
