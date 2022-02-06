using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //selection ststements
            //int age;
            //Console.WriteLine("Enter Your Age : ");
            //age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Your Age : {0}", age + " Eligible for vote");
            //}

            //else
            //{
            //    Console.WriteLine("Your Age : {0}", age + " Not Eligible for vote");
            //}
            Console.WriteLine(" Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine(" Enter Password : ");
            string Password = Console.ReadLine();

            if(username=="Pooja"&& Password=="Pooja123")
            {
                Console.WriteLine("Login Successful......");
            }
            else
            {
                Console.WriteLine("Incorrect username or password...");
            }
            Console.ReadLine();
        }
    }
}
