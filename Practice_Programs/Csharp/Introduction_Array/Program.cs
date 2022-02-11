using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Array: Collection of elements of a single data type stored in 
             * adjacent memeory location.
             * 
             * elements are ccessed using index numbers
             *  -ve index is not possible.
             */



            //int[] myarray = new int[3];
            //myarray[0] = 23;
            //myarray[1] = 56;
            //myarray[2] = 78;

            //string[] myarry = new string[] { "Pooja", "Jay", "Ishu", "Suju", "suriya" };

            string[] myarry = { "Pooja", "Jay", "Ishu", "Suju", "suriya" };
            //Console.WriteLine(myarry[0]);
            Console.WriteLine(myarry.Length);

            Console.ReadLine();
        }
    }
}
