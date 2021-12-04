using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_CustomException_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x % 2 != 0)
            //        throw new MYCustomException("Number is not Even ! ,please enter Even number");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("BYE!!!!!!!!");
            //}
                try
                {
                    Console.WriteLine("Enter a number");
                    x = Convert.ToInt32(Console.ReadLine());
                    if(x%5!=0)
                
                    throw new MYCustomException("Number is not Divisible by 5  ! please enter the number which is divided by 5");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("BYE!!!!!!!!");
                }
            
            Console.ReadLine();
        }
    }
}
