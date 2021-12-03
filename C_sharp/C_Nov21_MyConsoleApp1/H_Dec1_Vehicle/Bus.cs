using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Vehicle
{
    class Bus:Vehicle
    {
        public int B_wheel { get; set; }
        public string B_type { get; set; }
        public string B_engine { get; set; }

        public Bus()
        {
            B_wheel = 6;
            B_type = "School Bus";
            B_engine = "5660 CC";
        }
        public Bus(int wheel,string type,string engine,int v_wheel,string v_type,string v_engine ):base(v_wheel,v_type,v_engine)
        {
            B_wheel = wheel;
            B_type = type;
            B_engine = engine;
        }

        public override string ToString()
        {
            return base.ToString()+ " Bus Wheels: "+B_wheel+" Bus Type : "+B_type+" Engine : "+B_engine;
        }

    }
}
