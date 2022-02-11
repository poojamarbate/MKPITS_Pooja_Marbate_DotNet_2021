using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Functions
{
    class Program
    {
        public void Show()//declaring / non-static /instance method/non-paramaterized method
        {
            Console.WriteLine("Welcome to C# programming.....");
            Console.WriteLine("hey Bro What'sUp ...");
        }

        public static void Result()//static method
        {
            Console.WriteLine("Welcome to C# programming.....");
            Console.WriteLine("hey Bro What'sUp ...");
        }

        public static void Add(int a,int b)
        {
            int result=a+b; //local varible
            Console.WriteLine("Addition : "+result);
        }


        public static void Showname(string name="Unknown")
        {
            Console.WriteLine("Your name is: "+name);
        }
        static void Main(string[] args)
        {
            /* Methods:Group of statements that together perform a task.
             * - methods are function declare in a class and may be used to perform operations on class.
             * -two types of method 
             * 1)buliden method 
             * 2)user defined method
             * -
             */


            //method call

            //Program p = new Program();//contructor
            //p.Show();


            Program.Result();//static method call
                             //no need to create object
                             //at the time of call it call with class name



            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Program.Add(a,b);//arguments


            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Program.Showname(name);
            //it take default value
            //optinal parameter
            Program.Showname();
            Console.ReadLine();

        }
    }
}
