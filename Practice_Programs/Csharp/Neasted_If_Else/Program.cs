using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neasted_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // if_elseif_else
            // Console.WriteLine("Enter your percentage : ");
            // int Percentage=int.Parse(Console.ReadLine());
            // if(Percentage>=80)
            // {
            //     Console.WriteLine("Grade :A-1");
            // }
            // else if (Percentage >= 60)
            // {
            //     Console.WriteLine("Grade : B");
            // }
            // else if (Percentage >= 50)
            // {
            //     Console.WriteLine("Grade : C");
            // }
            // else if (Percentage >= 40)
            // {
            //     Console.WriteLine("Grade : D");
            // }
            // else if (Percentage >= 33)
            // {
            //     Console.WriteLine("Grade : E");
            // }
            //else
            // {
            //     Console.WriteLine("Fail...........");
            // }   
            //int a = 2;
            //if(a>5)
            //{
            //    if(a==10)
            //    {
            //        Console.WriteLine("A is 10");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A is not 10");
            //    }
            //}
            //else
            //{
            //    if(a==3)
            //    {
            //        Console.WriteLine("A is 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A is not 3");
            //    }

            //}
            //realtime example microsooft account hotmail 
            Console.WriteLine("Enter your Email:");
            string email = Console.ReadLine();
            if(email=="data@gmail.com")
            {
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();
                    if(password=="data123")
                    {
                    Console.WriteLine("Login successfull....");
                    }
                    else
                    { 
                    Console.WriteLine("Invalid password....");
                    }
            }
            else
            {
                Console.WriteLine("Invalid Email...");
            }
            Console.ReadLine();
        }
    }
}
