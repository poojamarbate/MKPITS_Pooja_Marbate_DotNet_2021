using System;

namespace C_Nov26_Class_Object_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee obj, obj1;
            //int x, y;//primitive data type have single value
            //x = 10;
            //y = 50;
            //obj = new Employee();//user defined data type
            //obj.firstname = "Pooja";
            //obj.lastname = "Marbate";
            //obj.salary = 35000;

           
            //obj1 = new Employee();
            //obj1.firstname = "Ram";
            //obj1.lastname = "Kapoor";
            //obj1.salary = 40000;

            //Date birthday = new Date(); //constructor
            ////birthday.day = 5;
            ////birthday.month = 6;
            ////birthday.year = 1998;
            //Console.WriteLine("Pooja's Birthday is "+birthday.day+"/"+birthday.month+"/"+birthday.year);

            ////constructor Example

            Date today = new Date(26, 11, 2021);
            today.Display();
            Date birthday = new Date(5, 6, 1998);
            Console.WriteLine("Pooja's Birthday is : ");
            birthday.Display();
            Date mybirthday = new Date(26, 8, 2004);
            // Console.WriteLine(mybirthday.GetType());
            mybirthday.Display();

            Employee obj = new Employee("Ram","Kapoor",40000);
            obj.Show();
                
        }
    }
}
