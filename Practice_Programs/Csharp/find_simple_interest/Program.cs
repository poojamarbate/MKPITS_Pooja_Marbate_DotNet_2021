using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_simple_interest
{
    class Program
    {
        static void Main(string[] args)
        {
            int amt, time;
            float r, si;
            Console.WriteLine("Enter amount");
            amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter time: ");
            time = Convert.ToInt32(Console.ReadLine());


            si = amt * r * time / 100;
            Console.WriteLine("Simple interest: "+si);

            Console.ReadLine();
        }
    }
}
