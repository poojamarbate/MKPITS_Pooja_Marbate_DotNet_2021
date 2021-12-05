using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_Example_VoiceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b1 = new Bird();
            b1.Voice();

            Sparrow s = new Sparrow();
            s.Voice();

            Crow c = new Crow();
            c.Voice();

            Parrot p = new Parrot();
            p.Voice();



            Console.ReadKey();

        }
    }
}
