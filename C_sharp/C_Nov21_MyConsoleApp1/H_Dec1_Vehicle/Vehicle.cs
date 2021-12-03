using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Vehicle
{
    class Vehicle
    {
        public int Vehicle_wheel { get; set; }

        public string Vehicle_type { get; set; }

        public string Vehicle_engine { get; set; }

        public Vehicle()
        {
            Vehicle_wheel = 2;
            Vehicle_type = "Bike";
            Vehicle_engine = "4-stroke";
        }

        public Vehicle( int wheel,string type,string engine)
        {
            Vehicle_wheel = wheel;
            Vehicle_type = type;
            Vehicle_engine = engine;
        }

        public override string ToString()
        {
            return "Wheel's :" + Vehicle_wheel + "  Type of Vehicle : " + Vehicle_type + "  engine type : " + Vehicle_engine;
        }
    }
}
