using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Csharp
{
    class Program
    {
        static void Main(string[] args)//entry point of appluication
        {
        //    Console.WriteLine("Welcome to Csharp !!!");//system namspace
        //    //take input from user
        //    //fully qulified name
        //    //system. Console.WriteLine("Welcome to Csharp !!!");

        //    Console.WriteLine("Enter your first name ");
        //    string fname = Console.ReadLine();
        //    //Console.WriteLine("Your name is : "+name);//concatenation syntax

        //    Console.WriteLine("Enter your last name ");
        //    string lname = Console.ReadLine();
        //    Console.WriteLine("Your Name is :{0} {1}",fname,lname);//placeholder syntax{0} name values print hogi


            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addition resulit is : {0}",sum);


            Console.ReadLine();
        }
    }
}
