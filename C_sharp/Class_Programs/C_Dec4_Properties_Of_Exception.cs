using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_Properties_Of_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                f1();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("Tata BYEE!!!! End your program");
            }

            Console.ReadKey();
        }
        public static void f1()
        {
            f2();
        }
        public static void f2()
        {
            f3();
        }


        public  static void f3()
        {
            int x=10,y=0;
            Console.WriteLine("X/Y = "+x/y);
        }
        
    }
}
