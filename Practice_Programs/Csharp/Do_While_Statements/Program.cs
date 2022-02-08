using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /* In do.... while loop atleast onces check condition
             * while statements along with the condition end of the statements
             */
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<=10);





            //difference between forLoop & whileLoop
            
            for(int i=0;i<10;i++)
            {
                //counter variable does not use out of forloop body
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");



            int j = 0;
            while(j<10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

        }
    }
}
