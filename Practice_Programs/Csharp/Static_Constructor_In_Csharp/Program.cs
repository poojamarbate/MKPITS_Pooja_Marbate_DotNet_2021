using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor_In_Csharp
{
    class Person
    {
        public static string Person_Name;
        public static int Person_Age;
       static Person() //static construtor
       {
            Person_Name = "Pooja";
            Person_Age = 23;
            Console.WriteLine("Static constructor invoke !!!");
       }
      public static void GetDetails()
       {
            Console.WriteLine("Person Name :{0}",Person_Name);
            Console.WriteLine("Person Age:{0}",Person_Age);
       }

        public Person() //instance constructor
        {
            Console.WriteLine("Default constructor invoke!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = new Person();



            Console.ReadLine();
        }
    }
}
