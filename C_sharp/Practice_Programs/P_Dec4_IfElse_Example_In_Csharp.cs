using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec4_ifElse_Examples_IN_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 78;
            //int b = 45;

            //if(a>b)
            //    Console.WriteLine("a is greater "+a);
            //else
            //    Console.WriteLine("b is greater "+b);
           

            //int time = 22;
            //if(time<10)
            //    Console.WriteLine("Good morning");
            //else if(time<20)
            //    Console.WriteLine("Good Day ...");
            //else
            //    Console.WriteLine("Good Evening");

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
