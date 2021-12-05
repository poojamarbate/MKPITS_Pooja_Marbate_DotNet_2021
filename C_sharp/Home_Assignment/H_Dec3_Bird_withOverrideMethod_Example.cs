using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_withOverrideMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdClass b = new BirdClass();
            b.Voice();

            Console.WriteLine();
            Crow c = new Crow("Black", 13);
            c.Voice();

            Console.WriteLine();
            Sparrow s = new Sparrow("dull and  grubby", 24);
            s.Voice();

            Console.WriteLine();
            Parrot p = new Parrot("Green", 64);
            p.Voice();

            Console.ReadKey();
        }
    }
}
