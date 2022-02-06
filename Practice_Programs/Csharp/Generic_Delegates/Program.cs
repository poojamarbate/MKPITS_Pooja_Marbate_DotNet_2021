using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates
{
    //public delegate double delegates1(int x, float y, double z);
    //public delegate void delegate2(int x, float y, double z);
    //public delegate bool delegates3(string str);
    class Program
    {
        public static double Addnum(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void Addnum1(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func <int,float, double,double>obj1  = Addnum;//values returing method
            double result=obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

          Action<int,float,double> obj2 = Addnum1;//non values returing method
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = CheckLength;//take only single parameter.return type is bool
            bool status = obj3.Invoke("hello");
            Console.WriteLine(status);
            Console.ReadKey();

          

        }
    }
}
