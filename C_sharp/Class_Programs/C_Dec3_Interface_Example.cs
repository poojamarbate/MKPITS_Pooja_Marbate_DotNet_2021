using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.GetSpeed(120);//define in class car
            c.ShowSpeed();//From Vehicle
            c.Print(); // from intreface IPrintable

            Console.ReadKey();
        }
    }
}
