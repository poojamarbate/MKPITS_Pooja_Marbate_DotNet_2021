using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet_Project_For_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
           
            Console.WriteLine("Enter Your Rollno.:");
            string rollnumber = Console.ReadLine();
            
            Console.WriteLine("Enter your class:");
            string standard = Console.ReadLine();
            
            Console.WriteLine("Enter your Maths marks:");
            int math =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your English marks:");
            int eng =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your Science:");
            int sci = int.Parse(Console.ReadLine());

            int obt = math + eng + sci;
            int per = obt*100/300;

            Console.WriteLine("***********************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------MARKSHEET-----------");
            Console.WriteLine("Your name is:{0}",name);
            Console.WriteLine("Your Rollno is:{0}",rollnumber);
            Console.WriteLine("Your class is :{0}",standard);
            Console.WriteLine("Your Obtained marks are:{0}",obt);
            Console.WriteLine("Your percenatge is :{0}",per);
            //for grades
            if(per>=80)
            {
                Console.WriteLine("Grade:A-1");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Grade:A");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade:B");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade:C");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Grade:D");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            //if else if for remarks
            if (per >= 80)
            {
                Console.WriteLine("Remarks:Excellent");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Remarks:Very Good");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Remarks: Good");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Remarks:Fair");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Remarks:Poor");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Remarks:Needs lots of improverments");
            }
            else
            {
                Console.WriteLine("Remarks:Bring Your Parents Tomorrow!!!!");
            }
            //fail subjects
            int supply = 0;

            if(math<33)
            {
               supply++;
               
            }
            if (eng < 33)
            {
                supply++;
            }
            if (sci < 33)
            {
                supply++;
            }

            Console.WriteLine("Your Fail in {0} Subjects",supply);


            Console.ReadLine();
        }
    }
}
