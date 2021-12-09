using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_ExpressionDisplay_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("enter the value of i and j");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            
             k=(--i)*2 + 2 * (3 * j + 5);

            Console.WriteLine("Value of K = "+k);
            Console.ReadKey();


        }
    }
}
