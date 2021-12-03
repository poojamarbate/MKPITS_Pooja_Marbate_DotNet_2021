using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Vehicle
{
    class Scooter:Vehicle
    {
        public int S_wheel { get; set; }
        public string S_type { get; set; }
        public string S_engine { get; set; }

        public Scooter()
        {
            S_wheel = 2;
            S_type = "TVS Jupiter";
            S_engine = "125 CC";
        }
        public Scooter(int wheel, string type, string engine, int v_wheel, string v_type, string v_engine) : base(v_wheel, v_type, v_engine)
        {
            S_wheel = wheel;
            S_type = type;
            S_engine = engine;
        }

        public override string ToString()
        {
            return base.ToString() + " Scooter Wheels: " + S_wheel + " Scooter Type : " + S_type + " Engine : " + S_engine;
        }
    }
}
