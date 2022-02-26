using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Of_Inheritance
{
    //single inheritance
    class BaseClass
    {
        public void show()
        {
            Console.WriteLine("This is a method of Base class");
        }
    }

    class DerivedClass:BaseClass
    {
        public void show2()
        {
            Console.WriteLine("This is a method of Derived  class");
        }
    }

    //Hierarchical inheritance

    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Son:Parent
    {
       public void Display2()
        {
            Console.WriteLine("He is a Son");
        }
    }
    class Daughter:Parent
    {
        public void Display3()
        {
            Console.WriteLine("she is a daughter");
        }
    }

    //multi-level inheritance
    class Animal
    {
        public void result()
        {
            Console.WriteLine("Sea Animal:Base Class");
        }
    }
    class Fish:Animal
    {
        public void result1()
        {
            Console.WriteLine("Fish:intermediate Class");
        }
    }
    class StarFish:Fish
    {
        public void result2()
        {
            Console.WriteLine("StarFish:Derived Class");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass d = new DerivedClass();
            //d.show();
            //d.show2();

            //Daughter d = new Daughter();
            //d.Display();
            //d.Display3();
            //Console.WriteLine("------------------");

            //Son s = new Son();
            //s.Display();
            //s.Display2();

           StarFish a = new StarFish();
            a.result();
            a.result1();
            a.result2();


            Console.ReadLine();
        }
    }
}
