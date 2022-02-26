using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_In_Csharp
{
    class Person
    {
        private string name;
        private int age;

        public void Setname(string name,int age)
        {
            if(string.IsNullOrEmpty(name)==true)
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.name = name;
            }



            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age should not be -tive OR 0");
            }
           
        }

        public void getName()
        {
            if (string.IsNullOrEmpty(this.name) == true)
            {
              
            }
            else
            {
                Console.WriteLine("Your name is:" + this.name);
            }



            if (age > 0)
            {
                Console.WriteLine("Your age:" + this.age);
            }
            else
            {
               
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Setname("Pooja",23);
            p.getName();
           

            Console.ReadLine();
        }
    }
}
