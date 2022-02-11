using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiializing_Array_User_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many number of item you want to store in array????");
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];//pass userinput in []array
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Data on location: "+(i+1));
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }

            Console.WriteLine("---------your data-------");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
