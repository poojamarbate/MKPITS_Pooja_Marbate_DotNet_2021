using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Example
     {
        string name;
        int age;
        public Example(string name,int age)
        {
            this.name = name;
            this.age = age;
            
        }

        public void GetData()
        {
            Console.WriteLine("Name :{0}",name);
            Console.WriteLine("Age:{0}",age);
        }

        public Example(Example e) //copy constructor
        {
            this.name = e.name;
            this.age = e.age;
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("Pooja", 25);
            obj.GetData();
            Example obj1 = new Example(obj); //call copy constructor
            obj1.GetData();
            Console.ReadLine();
        }
    }
}
