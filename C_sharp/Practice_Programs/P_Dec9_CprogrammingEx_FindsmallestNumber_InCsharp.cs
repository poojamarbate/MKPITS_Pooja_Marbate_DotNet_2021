using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_findSmalllestNumber_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter three number to find smallest Number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if(a<b && a<c)
         
                Console.WriteLine(a+" is smallest number ");
        
            else if(b<c)
                Console.WriteLine(b+" is smallest number");

            else
                Console.WriteLine(c+" is smallest number");

            Console.ReadKey();
         
           
        }
    }
}
