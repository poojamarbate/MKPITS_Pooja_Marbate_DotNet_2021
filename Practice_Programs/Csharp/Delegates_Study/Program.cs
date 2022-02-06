using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Study
{
    public delegate void Calculations(int a,int b);//declartion 
    //no body of delegate same as abstract class

    class Program
    {
        public static void Addition(int a,int b)
        {
            //static direct class k name se call kr skte
            int result = a + b;
            Console.WriteLine("Addition result is :{0}",result);

        }
        public static void Subtraction(int a, int b)
        {
            //static direct class k name se call kr skte
            int result = a - b;
            Console.WriteLine("Subtraction result is :{0}", result);

        }
        public static void Multiplication(int a, int b)
        {
            //static direct class k name se call kr skte
            int result = a * b;
            Console.WriteLine("multiplication result is :{0}", result);

        }
        public static void Division(int a, int b)
        {
            //static direct class k name se call kr skte
            int result = a / b;
            Console.WriteLine("Division result is :{0}", result);

        }
        static void Main(string[] args)
        {
            Calculations obj = new Calculations(Program.Addition);
            obj.Invoke(6,8);//method
            Calculations obj1 = new Calculations(Program.Subtraction);
            obj1(67, 60);
            Calculations obj2 = new Calculations(Program.Multiplication);
            obj2(6,7);
            Calculations obj3= new Calculations(Program.Division);
            obj3(25,5);

            Console.WriteLine();


            //using delegates you can call any method which is identifed only at run time.


            //Program.Addition(6,8);
            //obj = Subtraction;
            //obj(20, 10);//direct use
            //obj = Multiplication;
            //obj(2, 4);
            //obj = Division;
            //obj(5, 5);

            Console.ReadKey();
         
        }
    }
}
