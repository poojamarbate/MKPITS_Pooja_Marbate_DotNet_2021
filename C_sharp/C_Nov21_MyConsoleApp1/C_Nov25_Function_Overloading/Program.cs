using System;

namespace C_Nov25_Function_Overloading
{
    class Program
    {
        //fuction overloading : giving extra task to the same function
        //operator overloading: giving extra task to an operator
        static void Main(string[] args)
        
        //what is function Overloading ?
        //same name fuction with different signature in same class is
        //called overload function
        //signature of function : 
        //1- number of parameters
        //2- data type of parameters
        //3- sequence of parameters
        //return data type functionname(data ty d1,data ty d2,data ty d3)
        // example: void Sum(int a,int b, int c);
        //          void Sum(int a,int b);
        //          void Sum(int a,double b);
        //          void Sum(double a,int b);

        
        {
            Console.WriteLine("Enter the values : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Sum(a, b, c);
            Sum(5, 4, 1);
            Sum(12, 24);

            Console.ReadLine();

        }
        public static void Sum(int a,int b,int c)
        {
            int Addition = a + b + c;
            Console.WriteLine(" sum of three number : "+Addition);
        }

        public static void Sum(int a, int b)
        {
            int Addition = a + b;
            Console.WriteLine(" sum of two number : " + Addition);
        }
    }
}
