using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue_PassByReference
{
    class Program
    {
        //pass by value
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Value:"+a);
        }

        //pass by reference
        public static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine("Value is:"+a);
        }

        //pass By out
        public static void PassByOut(out int a)
        {
            a = 20;
            Console.WriteLine("Value:"+a);
        }
        static void Main(string[] args)
        {
            //pass by value
            int value = 5;
            PassByValue(value);//15
            Console.WriteLine(value);//5


            Console.WriteLine("-------------------Pass By Reference-----------");
            int result = 5;
            PassByRef(ref result);//15
            Console.WriteLine(result);//15

            Console.WriteLine("--------Pass By Out-------");
            int show;
            PassByOut(out show);//20
            Console.WriteLine(show);//20
            Console.ReadLine();
            
        }
    }
}
