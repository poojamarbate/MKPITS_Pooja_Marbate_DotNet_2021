using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_ArrayProgram_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" how many attended today: ");
            int c = int.Parse(Console.ReadLine());
            string[] students = new string[c];
            for(int i=0;i<c;i++)
            {
                Console.WriteLine("Name of Students : ");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("Attended to school today :");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(students[i]);
            }


          Console.ReadKey();
        }
    }
}
