using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Inheritance_Multiple
{
    class Cylinder:Circle
    {
        public int Height { get; set; }

        public Cylinder()
        {
            
            Height = 100;
        }
        public Cylinder(int h,int r,int x,int y):base(r,x,y)
        {
            Height = h;
        }
        //2*pi*r*r+2*pi*r*h==>2(pi*r*r)+
        //public override double Area()
        //{
        //    return 2 * base.Area() + 2 * Math.PI * Radius * Height;
        //}



        public new double Area()
        {
            return 2* base.Area()+2*Math.PI*Radius*Height;
        }

    }
}

