using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_MagicalMethod_ToString_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 58;
            string sentence = "a equals " + a.ToString();
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
