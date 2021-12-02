using System;
using System.Collections.Generic;
using System.Text;

namespace H_Dec1_Electronic_Inherit_3Different_Classes
{
    class Mobile:Electronic_Device
    {
        public string  m_processor {get;set;}
        public string m_Displaysize { get; set; }

        public Mobile()
        {
            m_processor = "KitCat";
            m_Displaysize = "14inches";
           
        }

        public Mobile(string m_processor,string m_Displaysize,string Processor,string Display_Size):base(Processor,Display_Size)
        {
            this.m_processor = m_processor;
            this.m_Displaysize = m_Displaysize;
            Console.WriteLine("Moblie Objecte Created");
        }
        public override string ToString()
        {
            return base.ToString()+" Mobile Processor Name: "+m_processor+" mobile Display size: "+m_Displaysize;
        }
    }
}
