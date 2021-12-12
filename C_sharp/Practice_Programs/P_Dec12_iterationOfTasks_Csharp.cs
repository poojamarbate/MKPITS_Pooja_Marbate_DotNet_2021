using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_iterationOfTasks_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 25;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("while Loop");
            int a = 5;
            while(a<=25)
            {
                a = a + 5;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
