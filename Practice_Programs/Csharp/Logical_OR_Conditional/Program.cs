using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_OR_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND(&&)
            //OR(||)
            /*
             * 1 X 1 =1
             * 1 X 0 =0
             * 0 X 1 =0
             * 0 X 0 =0
             */
            int a = 40;
            int b = 30;
            bool c = (a > b) && (a < b); //---------false(username and password)LoginForm
            bool d = (a > b) || (a < b);//----onlineForm(image options jpg or png )
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
