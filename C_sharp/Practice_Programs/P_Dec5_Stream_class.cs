using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_useOFbase_KEYWORD
{
    class Stream:Web
    {
        string s = "Computer Science";
        public override void Showdata()
        {
            base.Showdata();
            Console.WriteLine("About: "+s);
        }
    }
}
