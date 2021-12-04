using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec4_forLoop_Break_Continue_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine( "increment by +2" );

            for(int i=0; i<=10;i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Break statement when i=5");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {

                    break;
                    
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("Continue statement : 4 is not display in List");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {

                    continue;
                    
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
