using System;

namespace H_Dec1_Electronic_Inherit_3Different_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Electronic_Device e = new Electronic_Device();
            Console.WriteLine(e.ToString());

            Pc p = new Pc();
            Console.WriteLine(p.ToString());

            Mobile m = new Mobile();
            Console.WriteLine(m.ToString());

            Laptop l = new Laptop();
            Console.WriteLine(l.ToString());
                
        }
    }
}
