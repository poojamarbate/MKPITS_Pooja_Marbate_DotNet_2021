using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax error -programming
            //logical error -testing
            //run time error - can not be removed(avoided)
            //Exception handling
            int x, y;
            try
            {
                Console.WriteLine("Enter a number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x/y = " + x / y);
                int[] marks = { 67, 78, 89 };
                for(int i=0;i<7;i++)
                {
                    Console.WriteLine(marks[i]);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
