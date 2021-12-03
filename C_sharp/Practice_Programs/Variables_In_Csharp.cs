using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_In_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;   //int stored interger value
            double myDoubleNum = 5.99D; //float value
            char myLetter = 'D'; //stored single character
            bool myBool = true; // true or false
            string myText = "Hello"; //string

            Console.WriteLine("Interger Value = "+myNum);
            Console.WriteLine("Floating Value = "+myDoubleNum);
            Console.WriteLine("Single Character :"+myLetter);
            Console.WriteLine("Bool Stored the value T/F = "+myBool);
            Console.WriteLine("String = "+myText);

            Console.ReadKey();
        }

    }
}