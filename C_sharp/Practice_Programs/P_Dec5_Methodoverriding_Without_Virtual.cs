using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_MethodOveriding_wihout_Virtual
{
    //Method Overriding without using virtual and ovrride  modifier
    class Program
    {
        static void Main(string[] args)
        {
            //obj is the object of base class
            base_Class obj = new base_Class();

            //invokes the method 'show()' of class 'base_class'
            obj.Show();
            obj = new Derived();
            obj.Show();

            Console.ReadKey();

        }
    }
}
