using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_Twofloat_number_enter_byUser
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, product;

            Console.WriteLine("enter the number: ");
            num1 = Convert.ToSingle(Console.ReadLine());  //convert floating ponit number



            Console.WriteLine("enter the number: ");
            num2= Convert.ToSingle(Console.ReadLine());  //convert floating ponit number


            product = num1 * num2;
            Console.WriteLine("Product of two number : "+product);
            Console.ReadLine();


        }
    }
}
