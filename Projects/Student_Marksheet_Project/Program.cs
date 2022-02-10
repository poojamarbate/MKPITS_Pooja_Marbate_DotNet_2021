using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marksheet_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your rollno.:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Class:");
            string standard = Console.ReadLine();

            Console.WriteLine("Enter English Marks");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths Marks");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Science Marks");
            int sci = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter History Marks");
            int his = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Geography Marks");
            int geo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hindi Marks");
            int hin = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marathi Marks");
            int mar = int.Parse(Console.ReadLine());

            int obt = eng + math + sci + his + geo + hin + mar;
            int per = obt * 100 / 700;

            Console.WriteLine("----------------Student Marksheet------------");
            Console.WriteLine("Your Name:{0}", name);
            Console.WriteLine("Your Rollno:{0}", rollno);
            Console.WriteLine("Your Class:{0}", standard);
            Console.WriteLine("Your Obtain Marks are:{0}", obt);
            Console.WriteLine("Your Percenatge is:{0}", per + "%");


            //for Grade
            if (per >= 80)
            {
                Console.WriteLine("Grade:A-1");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade:A");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade:B");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Grade:C");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //remark
            if (per >= 80)
            {
                Console.WriteLine("Remark:Excellent");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Remark:Good");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Remark:Fair");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Remark:Need Improvement");
            }
            else
            {
                Console.WriteLine("Remark:Bring Your Parents Tomorrow");
            }

            //supply
            int supply = 0;
            //int obt = eng + math + sci + his + geo + hin + mar;
            if (eng >= 33)
            {
                supply++;//eng
            }

            if (math >= 33)
            {
                supply++;//math
            }

            if (sci >= 33)
            {
                supply++;//sci
            }

            if (his >= 33)
            {
                supply++;//his
            }

            if (geo >= 33)
            {
                supply++; //geo
            }

            if (hin >= 33)
            {
                supply++;//hindi
            }

            if (mar >= 33)
            {
                supply++;//marathi
            }
            Console.WriteLine("You are Fail in {0}:", supply);


            Console.ReadLine();

        }
    }
}
