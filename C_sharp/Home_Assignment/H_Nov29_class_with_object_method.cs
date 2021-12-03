using System;

namespace H_Nov29_Class_with_object_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Date obj = new Date(12, 7, 1998);
            Console.WriteLine("launched Date:");
            Console.WriteLine(obj.ToString());


            Car c1 = new Car("Alto", "Red", 800,5,9,1999);
            Console.WriteLine(c1.ToString());
        }
       
    }
}
