using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec2_VirtualNew_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //s.Area();

            Shape s;
            Circle c = new Circle();
            c.Area();
            s = new Circle();
            s = c;    //shadowing effect (new in place ovrride)
            s.Area();


            Shape e ;
            Rectangle r = new Rectangle();
            r.Area();
            s = new Rectangle();
            s = r;
            s.Area();

        }
    }
}
