using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov29_Class_with_object_method
{
    class Car
    {
       
        public string carname;
        public string color;
        public int model;
        public Date launched;


        public Car(string carname,string color,int model,int day,int month,int year)
        {
            this.carname = carname;
            this.color = color;
            this.model = model;
            launched = new Date(day,month,year);
        } 

        public override string ToString()
        {
            return carname+" "+color+" "+model;
        }





    }
    //ToString() method is coming from object class
    //GetHashCode()
    //GetType()
    //Equals()
    //what is overriding
    //function  signature is same but body is different

}
