using System;
using System.Collections.Generic;
using System.Text;

namespace H_Dec1_Electronic_Inherit_3Different_Classes
{
    class Pc:Electronic_Device
    {
       

        public string Pc_ProcessorName { get; set; }

        public string Pc_DisplaySize { get; set; }

        


        public Pc()
        {
           
            Pc_ProcessorName = "Intel Core";
            Pc_DisplaySize = "32inches";
          
        }

        public Pc(string Pc_ProcessorName,string Pc_DisplaySize,string Processor,string Display_Size):base(Display_Size,Processor)
        {
            this.Pc_ProcessorName = Pc_ProcessorName;
            this.Pc_DisplaySize = Pc_DisplaySize;
            Console.WriteLine("Pc Object created");
        }

        public override string ToString()
        {
            return base.ToString()+" PC Processor Name :"+Pc_ProcessorName+" Display Size :"+Pc_DisplaySize;
        }

    }
}
