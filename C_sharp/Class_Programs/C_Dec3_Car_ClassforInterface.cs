using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Interface_Example
{
    class Car : Vehicle,IPrintable//multiple inheritance not allowed
    {//car class is a concrete class
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public int Seats { get; set; }

        public Car()
        {
            Brand = "Maruti";
            Model = "Dezire";
            Color = "Silver White";
            Seats = 6;
        }

        public void GetSpeed(int s)
        {
            Speed = s;
        }

        public override void ShowSpeed()
        {
            Console.WriteLine(" Speed of Car is " + Speed);
        }

        public void Print()
        {
            Console.WriteLine(" Model: "+Model+" Brand: "+Brand+" color: "+Color);
        }
    }
}
