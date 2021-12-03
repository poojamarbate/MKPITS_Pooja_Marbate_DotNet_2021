using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Vehicle
{
    class Car:Vehicle
    {
        public int C_wheel { get; set; }
        public string C_type { get; set; }
        public string C_engine { get; set; }

        public Car()
        {
            C_wheel = 4;
            C_type = "SUV";
            C_engine = "998 CC";
        }
        public Car(int wheel, string type, string engine, int v_wheel, string v_type, string v_engine) : base(v_wheel, v_type, v_engine)
        {
            C_wheel = wheel;
            C_type = type;
            C_engine = engine;
        }

        public override string ToString()
        {
            return base.ToString() + " Car Wheels: " + C_wheel + " Car Type : " + C_type + " Engine : " + C_engine;
        }
    }
}
