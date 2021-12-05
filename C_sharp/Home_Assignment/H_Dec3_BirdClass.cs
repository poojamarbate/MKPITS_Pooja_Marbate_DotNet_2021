using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_withOverrideMethod_Example
{
    class BirdClass
    {
        public string color { get; set; }
        public int weight { get; set; }

        public BirdClass()
        {
            Console.WriteLine();
        }

        public BirdClass(string c,int w)
        {
            color = c;
            weight = w;
        }

        public virtual void Voice()
        {
            Console.WriteLine("Voice of Bird is");
        }
    }
}
