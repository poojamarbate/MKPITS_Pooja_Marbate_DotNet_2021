using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_In_Csharp
{
    class Employees
    {
        int Emp_Id;
        string Emp_Name;
        int Emp_Age;
        public Employees(int id,string name,int age)
        {
            this.Emp_Id = id;
            this.Emp_Name = name;
            this.Emp_Age = age;
        }

        //getter method
        public int getID()
        {
            return this.Emp_Id;
        }
        public string getName()
        {
            return this.Emp_Name;
        }
        public int getAge()
        {
            return this.Emp_Age;
        }
    }
}
