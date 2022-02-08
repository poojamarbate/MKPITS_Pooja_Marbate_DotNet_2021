using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Contructs_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //looping means repeartation 
            /* display a series of numbers taking repetiyive inputs
             * conatins a condition that helps the compiler identify the no. of times
             * a specific blocks will be execute.
             * if condition is not specfied ,the loop goes infinitely loop
             * 1)for loop
             * 2)while loop
             * 3)do...while
             * 4)foreach loop-----use array,list,collections.
             */



            /* For Loop:
             * syntax::
             * intialization
             * condition
             * increment/decrement
             */
            //Console.WriteLine("Enter a Number :");
            //int num = int.Parse(Console.ReadLine());
            //for(int i=1;i<=10;i++) //counter variable
            //{
            //    Console.WriteLine(num+" x "+ i +" = "+ num*i); //2 x 2 =4
            //}
            for (int i = 10; i >0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For Loop END.......");
            Console.ReadLine();
            
            
        }
    }
}
