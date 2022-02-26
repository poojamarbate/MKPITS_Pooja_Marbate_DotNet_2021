using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier_Part2
{
    //public class Class1
    //{
    //    private void Show1()
    //    {
    //        Console.WriteLine("This is public method...");
    //    }
    //}

    //Protected 
    //public class Class2
    //{
    //   protected void Show()
    //    {
    //        Console.WriteLine("This is public method...");
    //    }
    //}

    //Internal 
    public class class1
    {
        internal void Show()
        {
            Console.WriteLine("This is internal method...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            class1 c = new class1();
            c.Show();
            Console.ReadLine();
        }
    }
}
