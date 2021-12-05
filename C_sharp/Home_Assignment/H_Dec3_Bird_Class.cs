using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_Example_VoiceMethod
{
    class Bird
    {
        public int weight { get; set; }
        public string color { get; set; }

        public virtual void Voice()
        {
            Console.WriteLine("Voice of bird : ");
        }

    }
}
