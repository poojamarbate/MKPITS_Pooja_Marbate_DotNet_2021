using System;

namespace C_Dec1_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother m = new Mother();
            Console.WriteLine(m.ToString());

            Daughter d = new Daughter(12, "Rani", 40, "Rajvi");
            Console.WriteLine(d.ToString());
        }
    }
}
