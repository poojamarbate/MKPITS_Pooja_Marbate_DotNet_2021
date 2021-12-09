using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_celcius_Far_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int celcius = 100,f;
            f = (celcius * 9 / 5) + 32;
            Console.WriteLine("Farenheit = "+f);
            Console.ReadKey();
        }
    }
}
