using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Shape_inheritance
{
    class Shape
    {
        public string Shape_para { get; set; }
         public string Shape_Name { get; set; }
       
        public Shape()
        {
            Shape_Name = "Shape";
            Shape_para = "Shape Parameters";
          
        }

        public Shape(string Shape_Name,string Shape_para)
        {
            
            this.Shape_Name = Shape_Name;
            this.Shape_para = Shape_para;

        }
        public override string ToString()
        {
            return "Shape Name =  "+ Shape_Name +" parameters of shapes = "+Shape_para;
        }
    }
}
