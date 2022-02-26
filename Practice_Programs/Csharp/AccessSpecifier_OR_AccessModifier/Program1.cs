using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier_OR_AccessModifier
{
    public class Class1
    {
        public void Show()
        {
            Console.WriteLine("This is a Public method");
        }
        public void show1()
        {

            Class1 obj = new Class1();
            obj.Show();
        }

    }



    class Program1
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.show1();
            
            Console.ReadLine();
        }
    }
}
