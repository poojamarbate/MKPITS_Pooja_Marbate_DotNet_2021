using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor_In_Csharp
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Getname()
        {
            return this.name;
        }

        public int Getage()
        {
            return this.age;
        }
        
        ~Person()   //destructor:free the memory
        {
            Console.WriteLine("Destructor has been invoke!!!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rani", 23);
            Console.WriteLine(p.Getname());
            Console.WriteLine(p.Getage());
            Console.WriteLine("------------------------------");
            Person aarav = new Person("Aarav", 23);
            Console.WriteLine(aarav.Getname());
            Console.WriteLine(aarav.Getage());


            //Console.ReadLine();
        }
    }
}
