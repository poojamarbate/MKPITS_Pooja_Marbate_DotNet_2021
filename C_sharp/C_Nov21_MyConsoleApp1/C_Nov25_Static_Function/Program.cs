using System;

namespace C_Nov25_Static_Function
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.WriteLine(" Area of Circle ");
        //    double A = Area_Circle(5);
        //    Console.WriteLine(" Area of circle = {0:F2}",A );
        //    Console.ReadKey();

        //}
        //public static double Area_Circle(int r)
        //{
        //    return Math.PI * r * r; 
        //}
       
        {
            int radius;
            Console.WriteLine("Enter the radius ");
            radius = Convert.ToInt32(Console.ReadLine());
            Area_Circle(radius);
            Area_Circle(7);
            Console.ReadLine();

        }
        public static void Area_Circle(int r)
        {
            double a = Math.PI * r * r;
            Console.WriteLine("the area of circle is = {0:F3}",a);
        }
    }
}
