using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Desgin_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] pattern = new string[4][];
            pattern[0] = new[] { "*"};
            pattern[1] = new[] { "*","*" };
            pattern[2] = new[] { "*","*","*" };
            pattern[3] = new[] { "*", "*", "*" ,"*"};

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern[i].Length; j++)
                {
                    Console.Write(pattern[i][j]+" "); //remove line word in writeline()
                }
                Console.WriteLine();
            }


            Console.WriteLine("---------------------------------------");
            string[][] my_pattern = new string[3][];
            my_pattern[0] = new[] { " "," ","*"," "," " };

            my_pattern[1] = new[] { " ", "* "," ", "*", " " };

            my_pattern[2] = new[] { "*","","","*","","","","*"};


            for (int i = 0; i < my_pattern.GetLength(0); i++)
            {
                for (int j = 0; j < my_pattern[i].Length; j++)
                {
                    Console.Write(my_pattern[i][j]+" ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("-----------Dot pattern----------");
            string[][] dot_pattern = new string[3][];
            dot_pattern[0] = new[] {"","",".","","" };
            dot_pattern[1] = new[] { "", "", ".", "", ".", "", "" };
            dot_pattern[2] = new[] { "", "", ".", "", "", ".", "", "", ".", "", "" };

            for (int i = 0; i < dot_pattern.GetLength(0); i++)
            {
                for (int j = 0; j < dot_pattern[i].Length; j++)
                {
                    Console.Write(dot_pattern[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
