using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_ArrayEX2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = 5;
            double[] numbers = new double[elements];
            numbers[0] = 10;
            numbers[1] = 25;
            numbers[2] = 27;
            for(int i=0;i<elements;i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int  names = 3;
            string[] myarray = new string[names];
            myarray[0] = "Pooja";
            myarray[1] = "ishant";
            myarray[2] = "kirshna";
            for(int i=0;i<names;i++)
            {
                Console.WriteLine(myarray[i]);
            }


            Console.ReadKey();
        }
    }
}
