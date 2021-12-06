using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec6_Polymorphism
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("A::Test()");
        }
    }

    //class B : A { }
    //class C : B { }

    //class B : A
    //{
    //    public void Test()
    //    {
    //        Console.WriteLine("B::Test()");
    //    }
    //}

    //class C : B
    //{
    //    public void Test()
    //    {
    //        Console.WriteLine("C::Test()");
    //    }
    //}
    class B : A
    {
        public new void Test()
        {
            Console.WriteLine("B::Test()");
        }
    }

    class C : B
    {
        public new void Test()
        {
            Console.WriteLine("C::Test()");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.Test();       //outout ----->"A::Test()"


            //B b = new B();
            //b.Test();       //outout ----->"A::Test()"

            //C c = new C();
            //c.Test();        //outout ----->"A::Test()"


            A a = new A();
            B b = new B();
            C c = new C();

            a.Test();   //"A::Test()"
            b.Test();   //"B::Test()"
            c.Test();   // "C::Test()"


            a = new B();
            a.Test();        //"A::Test()"

            b = new C();
            b.Test();          //"B::Test()"


            Console.ReadKey();


        }
    }
}
