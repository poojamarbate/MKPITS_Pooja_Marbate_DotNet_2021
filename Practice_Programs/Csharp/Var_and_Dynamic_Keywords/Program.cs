using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_and_Dynamic_Keywords
{
    class Program
    {
        //public static int Show(var b,int a)
        //{
        //    return 0;
        //}

        public static dynamic Show(dynamic a)
        {
            return a;
        }
        static void Main(string[] args)
        {

            //int a = 20;//only store integer value
            //var b = "Pooja";//it store all type of data.
            ////var keyword is value type
            //Console.WriteLine(b.GetType());//to find the data type use get.method()
            //Console.WriteLine(b.Length);
            //Console.WriteLine(b.ToUpper());

            //Dynamic 

           // dynamic a = "Pooja";
          
            dynamic b;
            b = 10;
            //Console.WriteLine(a.GetType());
            Program.Show("pooja");
            Program.Show(5);
            Program.Show(true);
            Console.ReadLine();
        }
    }
}
