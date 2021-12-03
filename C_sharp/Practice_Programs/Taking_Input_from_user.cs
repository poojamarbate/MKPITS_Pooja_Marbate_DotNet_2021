using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type your username and Press Enter
            Console.WriteLine("Enter username : ");

            //Create a string variable and get user input from the keyboard and store it in the variable

            string username = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("UserName is : "+username);


            Console.WriteLine("Enter your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());  //convert string into int
            Console.WriteLine("User's Age : "+Age+"yr old");




        }
    }
}
