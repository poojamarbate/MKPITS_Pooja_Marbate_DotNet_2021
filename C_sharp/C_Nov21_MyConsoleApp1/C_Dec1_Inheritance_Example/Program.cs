using System;

namespace C_Dec1_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mother m = new Mother();
            //Console.WriteLine(m.ToString());

            //Daughter d = new Daughter(12, "Rani", 40, "Rajvi");
            //Console.WriteLine(d.ToString());

            //Employee e1 = new Employee();
            //e1.GrossSalary();//donee


            //Manger m1=new manager(); data
            //Employee.ShowNetSalary(m1);  //dyanmic binding

            //late binding
            //run time binging of function with object





            Employee e1 = new Employee();
            Employee.ShowNetSalary(e1);

        }
       // Console.WriteLine("Grosss Salary ="m1.Salary); data
    }//static  binding
    //early binging    
    //compile time binding
}
