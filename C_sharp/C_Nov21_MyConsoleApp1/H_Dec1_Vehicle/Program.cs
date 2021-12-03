using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle();
            //Console.WriteLine(v);

            //Bus b = new Bus();
            //Console.WriteLine(b);

            //Car c = new Car();
            //Console.WriteLine(c);

            //Scooter s = new Scooter();
            //Console.WriteLine(s);

            Vehicle v1 = new Vehicle(4, " Car ", "998 CC");
            Console.WriteLine(v1);

            Bus b1 = new Bus(4, "Ambulance", "BS-IV", 4, "Emergency BUS ", "BS-IV");
            Console.WriteLine(b1);

            Car c1 = new Car(4, "Honda Fit", "i-VTEC", 4, "CAR", "i-VTEC");
            Console.WriteLine(c1);


            Scooter s1 = new Scooter(2, "Activa 6G", "109.51 CC", 2, "SCOOTER", "6G");
            Console.WriteLine(s1);


            Console.ReadLine();
        }
    }
}
