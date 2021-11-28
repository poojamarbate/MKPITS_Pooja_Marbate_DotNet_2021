using System;

namespace H_Nov25_FunctionOverloading_find_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Radius ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Area(radius);
            Console.WriteLine("Enter length and breath ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Area(l, b);
            Console.WriteLine(" Enter Base and Height ");

            int h = Convert.ToInt32(Console.ReadLine());

            Area(b, h);
            
        }
        public static void Area(int a)
        {
            double A = Math.PI * a * a;
            Console.WriteLine("Area of circle {0:F3}", A);
        }
        public static void Area(int l,int b)
        {
            int A = l * b;
            Console.WriteLine("Area of Rectangle : " + A);
        }
        
        public static void Area(int b,float h)
        {
            double A = 0.5 * b * h;
            Console.WriteLine("Area of Triangle :{0:F2}",A);
        }


    }
}
