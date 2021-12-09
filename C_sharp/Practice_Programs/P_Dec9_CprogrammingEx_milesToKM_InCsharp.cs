using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_milesTOkilometers_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 250;
            double km;
            km = 1.609 * miles;
            Console.WriteLine("Kilometer = "+km);
            Console.ReadKey();
      
        }
    }
}
