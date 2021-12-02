using System;
using System.Collections.Generic;
using System.Text;

namespace H_Dec1_Electronic_Inherit_3Different_Classes
{
    class Laptop:Electronic_Device
    {
        public string Lap_processor { get; set; }
        public string Lap_Displaysize { get; set; }

        public Laptop()
        {
            Lap_processor = "intel Core i3";
            Lap_Displaysize = "13.3 inches";
           
        }

        public Laptop(string Lap_processor,string Lap_Displaysize,string Processor,string Display_size):base(Processor,Display_size)
        {
            this.Lap_processor = Lap_processor;
            this.Lap_Displaysize = Lap_Displaysize;
            Console.WriteLine("Laptop Object is created");
        }

        public override string ToString()
        {
            return base.ToString()+" Laptop Processor name: "+Lap_processor+" laptop display size: "+Lap_Displaysize;
        }
    }
}
