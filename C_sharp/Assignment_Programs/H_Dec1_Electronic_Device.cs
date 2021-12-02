using System;
using System.Collections.Generic;
using System.Text;

namespace H_Dec1_Electronic_Inherit_3Different_Classes
{
    class Electronic_Device
    {
        
        public string Processor { get; set; }

        public string Display_Size { get; set; }

        

        public Electronic_Device()
        {
           
            Processor = "Lower Voltage";
            Display_Size = "21 inches";
        }

        public Electronic_Device(string Processor,string Display_Size)
        {
           
            this.Processor = Processor;
            this.Display_Size = Display_Size;
   
        }

        public override string ToString()
        {
            return "Electronic Device Details : "+Display_Size+" "+Processor ;
   
        }


    }
}
