using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_variables_in_Csharp
{
    class Program
    {
        public const double PI = 3.14;
        // CONSTANT IS A VALUE TYPE 
        //decimal end "m" compalory
        //float end "f"
        //access specifer class mi use krte h variable declare k liye..
        static void Main(string[] args)
        {

            //Console.WriteLine(int.MaxValue);
            // PI = 5.34;  ----error occure
             int a;   //declareation
             a = 10;  //initilization
             int b = 30;//initilazation
            

            Console.WriteLine(PI);
            Console.ReadKey();
        }
    }
}
