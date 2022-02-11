using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Foreach Loop:C# is an extension of the for loop
             */
            int[] myarry = new int[5];
            myarry[0] = 10;
            myarry[1] = 20;
            myarry[2] = 30;
            myarry[3] = 40;
            myarry[4] = 50;
            

            for (int i = 0; i < myarry.Length; i++)//length actual size of array
            {
                Console.WriteLine(myarry[i]);//counter variable
            }

            Console.WriteLine("---------------Foreach loop--------------");
            //foreach loop for retrive array elemts
            //advance version of for loop
            //specifiy data type
            //particularly useful for reference type data
            foreach (int item in myarry)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
