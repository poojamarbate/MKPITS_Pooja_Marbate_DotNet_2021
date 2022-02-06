using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDate_andTIME_FORMATESpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;         //bulid in class in .netfreamwork
                                                // Console.WriteLine("{0:d}",dt); //formate specifer 'd'--short date
                                                // Console.WriteLine("{0:D}",dt);  'D' long date time 

            // Console.WriteLine("{0:f}", dt);// full date/time(short time)
            //Console.WriteLine("{0:F}", dt); //full date/time(long time)
            // Console.WriteLine("{0:g} {1:D}", dt,dt); //general date/time (short t
            //Console.WriteLine("{0:G}", dt); //SHORT date /long time
            // Console.WriteLine("{0:m}", dt);  --month show
            // Console.WriteLine("{0:t} {1:T}", dt,dt);
            // Console.WriteLine("{0:yy}", dt);
            //Console.WriteLine("{0:ddd}", dt); ----abbreviated name of day of the week
            //Console.WriteLine("{0:dddd}", dt); full day of week name
            // Console.WriteLine("{0:FF}", dt); ---secenods in fraction
            //Console.WriteLine("{0:HH}", dt);---24hour formate
            //Console.WriteLine("{0:MM}", dt);----month as a number
            //  Console.WriteLine("{0:MMM}", dt); ----SHORT NAME OF MONTH
            //Console.WriteLine("{0:ss}", dt); -----show the second
            // Console.WriteLine("{0:HH:mm:ss  tt}", dt);----tt{for AM PM}
           // Console.WriteLine("{0:dd-MM-yyyy}", dt);----small mm -for min
            Console.ReadLine();
        }
    }
}
